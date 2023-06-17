using Clinic.UI.Data.Interface;
using Clinic.UI.Data.Model;
using Clinic.UI.Services.Interface;
using Clinic.UI.Services.Model;

namespace Clinic.UI.Services.Services
{
    public class BusinessService : IBusinessService
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public BusinessService(IBusinessRepository businessRepository, IUserRepository userRepository, IRolePermissionRepository rolePermissionRepository)
        {
            _businessRepository = businessRepository;
            _userRepository = userRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }
        public Guid RegisterBusinessUser(BusinessModel model)
        {
            var parentBusinessId = Guid.NewGuid(); // Get unique ParentBusiness ID
            var parentBusiness = new Business
            {
                Id = parentBusinessId,
                BusinessName = model.BusinessName,
                ParentBusinessId = parentBusinessId,
                CreatedDate = DateTime.Now,
                Status = true,
                IsDefault = true,
                TimeZone = "AUS Eastern Standard Time",
                CreatedBy = "ADMIN"
            };
            var newUserId = Guid.NewGuid();
            
            _businessRepository.CreateParentBusiness(parentBusiness);

            var roleId = _rolePermissionRepository.GetBusinessOwnerRoles(parentBusinessId).Id;
            var users = new ApplicationUsers
            {
                Id = newUserId,
                Username = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ParentBusinessId = parentBusiness.ParentBusinessId,
                RoleId = roleId, //new Guid("D2B581EB-DE12-4ACA-9CB1-93E52153FC2E"), //todo from the roles table jwt configsetting
                EmailId = model.Username,
                IsTermOfServicee = model.IsTermOfService,
                IsStatus = true,
                IsVerified = false,
                TimeZone = "AUS Eastern Standard Time",
                CreatedDate = DateTime.Now,
                CreatedBy = "ADMIN",
            };
            var userid = _userRepository.CreateUser(users);

            return userid;
        }
    }
}
