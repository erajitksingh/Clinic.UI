using Clinic.UI.Data.Helpers;
using Clinic.UI.Data.Interface;
using Clinic.UI.Data.Model;

namespace Clinic.UI.Data.Repositories
{
    public class RolePermissionRepository : BaseRepository, IRolePermissionRepository
    {
        public RolePermissionRepository(DataContext context) : base(context)
        {

        }
        public BusinessRoles GetBusinessOwnerRoles(Guid parentBusinessId)
        {
            List<BusinessRoles> roles = null;
            DatabaseAccess(context =>
            {
                roles = context.BusinessRoles.Where(x => x.ParentBusinessId.Equals(parentBusinessId)).ToList();
            });
            return roles.FirstOrDefault(x => x.RoleName.Equals("Owner", StringComparison.OrdinalIgnoreCase));
        }
    }
}
