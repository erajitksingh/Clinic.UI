using Clinic.UI.Data.Model;

namespace Clinic.UI.Data.Interface
{
    public interface IRolePermissionRepository
    {

        //#region Roles
        ////Roles GetRoles(Guid id);
        ////List<Roles> GetAllRoles();

        //List<BusinessRoles> GetBusinessRoles(Guid parentBusinessId);
        BusinessRoles GetBusinessOwnerRoles(Guid parentBusinessId);
        //BusinessRoles GetBusinessRoles(Guid parentBusinessId, Guid id);
        //public Guid Create(BusinessRoles businessRoles);
        //public Guid Update(BusinessRoles businessRoles);
        //public bool Remove(BusinessRoles businessRoles);
        //#endregion

        //#region Application Modules
        //public List<ApplicationModules> GetAllApplicationModules();
        //#endregion
        //public List<UserModuleAccessbyBusiness> GetUserModuleAccessbyBusiness(Guid parentBusinessId, string ModuleLevel0, string ModuleLevel1, string ModuleLevel2);
        //public List<ApplicationBusinessRoleModulesAccess> GetAllModuleAccessbyBusiness(Guid parentBusinessId);
        //public BusinessRoleModulesAccess GetBusinessRoleModulesAccess(Guid parentBusinessId, Guid id);
        //public List<BusinessRoleModulesAccess> GetBusinessRoleModulesAccessbyRoleId(Guid parentBusinessId, Guid businessRoleId);
        //public BusinessRoleModulesAccess Update(BusinessRoleModulesAccess businessRoleModulesAccess);
        
        //public List<Guid> Update(List<BusinessRoleModulesAccess> businessRoleModulesAccess);
        //public List<Guid> Create(List<BusinessRoleModulesAccess> businessRoleModulesAccess);
        //public List<Guid> Remove(List<BusinessRoleModulesAccess> businessRoleModulesAccess);
        //public bool ResetBusinessRoleModuleAccess(Guid parentBusinessId);

    }
}
