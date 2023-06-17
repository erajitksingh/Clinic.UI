using Clinic.UI.Services.Model;

namespace Clinic.UI.Services.Interface
{
    public interface IBusinessService
    {
        Guid RegisterBusinessUser(BusinessModel model);
    }
}
