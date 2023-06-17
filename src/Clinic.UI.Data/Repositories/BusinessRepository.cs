using Clinic.UI.Data.Helpers;
using Clinic.UI.Data.Interface;
using Clinic.UI.Data.Model;

namespace Clinic.UI.Data.Repositories
{
    public class BusinessRepository : BaseRepository, IBusinessRepository
    {
        public BusinessRepository(DataContext context) : base(context)
        {
        }
        public Guid CreateParentBusiness(Business business)
        {
            this.Create<Business>(business);
            return business.ParentBusinessId;
        }
    }
}
