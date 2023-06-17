using System.Linq.Expressions;
using Clinic.UI.Data.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Clinic.UI.Data.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly DataContext Context;

        protected BaseRepository(DataContext context)
        {
            Context = context;
        }

        protected void DatabaseAccess(Action<DataContext> action, bool saveChanges = false)
        {
            if (Context.Database.CurrentTransaction != null) 
            {
                action(Context);

                if (saveChanges)
                {
                    Context.SaveChanges();
                }
            }
            else
            {
                using var transaction = Context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
                action(Context);

                if (saveChanges)
                {
                    Context.SaveChanges();
                }

                transaction.Commit();
            }
        }
        public List<T> Get<T>(Expression<Func<T, bool>> whereClause) where T : class
        {
            var rv = new List<T>();

            DatabaseAccess(c =>
            {
                var queryable = Context.Set<T>().AsNoTracking();

                if (whereClause != null)
                    queryable = queryable.Where(whereClause);

                rv = queryable.ToList();

            }, false);

            return rv;
        }
        public void Create<T>(T entity) where T : class
        {
            DatabaseAccess(c =>
            {
                Context.Set<T>().Add(entity);
            }, true);
        }

        public void Create<T>(List<T>  entity) where T : class
        {
            DatabaseAccess(c =>
            {
                Context.Set<T>().AddRange(entity);
            }, true);
        }

        public void Update<T>(T entity) where T : class
        {
            DatabaseAccess(c =>
            {
                Context.Set<T>().Update(entity);
            }, true);
        }
        public void Update<T>(List<T> entity) where T : class
        {
            DatabaseAccess(c =>
            {
                Context.Set<T>().UpdateRange(entity);
            }, true);
        }


        public void Remove<T>(T entity) where T : class
        {
            DatabaseAccess(c =>
            {
                Context.Set<T>().Remove(entity);
            }, true);
        }
        public void Remove<T>(List<T> entity) where T : class
        {
            DatabaseAccess(c =>
            {
                Context.Set<T>().RemoveRange(entity);
            }, true);
        }


        public List<T> GetAll<T>(T entity) where T : class
        {
            var rv = new List<T>();

            DatabaseAccess(c =>
            {
                var queryable = Context.Set<T>().AsNoTracking();
                rv = queryable.ToList();

            }, false);

            return rv;
        }

        public bool ValidateBusinessLocation(Guid parentBusinessId, Guid? locationId)
        {
            return Context.BusinessLocation.Any(x => x.ParentBusinessId.Equals(parentBusinessId) && x.Id.Equals(locationId));
        }
        //public bool ValidateBusinessPatient(Guid parentBusinessId, Guid? parentId)
        //{
        //    return Context.Patient.Where(x => x.Id.Equals(parentId)).Any(x => x.ParentBusinessId.Equals(parentBusinessId));
        //}

    }
}

