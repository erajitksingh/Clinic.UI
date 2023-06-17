using Clinic.UI.Data.Model;

namespace Clinic.UI.Data.Interface
{
    public interface IBusinessRepository
    {
        Guid CreateParentBusiness(Business business);
    }
}
