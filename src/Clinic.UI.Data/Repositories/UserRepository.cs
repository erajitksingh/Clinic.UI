using Clinic.UI.Data.Helpers;
using Clinic.UI.Data.Interface;
using Clinic.UI.Data.Model;

namespace Clinic.UI.Data.Repositories
{
    internal class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public Guid CreateUser(ApplicationUsers users)
        {
            this.Create<ApplicationUsers>(users);
            return users.Id;
        }
    }
}
