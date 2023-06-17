using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.UI.Data.Model
{
    public class BusinessRoles
    {
        public Guid Id { get; set; } // uniqueidentifier
        public Guid ParentBusinessId { get; set; } // uniqueidentifier
        public string RoleName { get; set; } // nvarchar(255)
        public string RoleDescription { get; set; } // nvarchar(max)
        public bool IsCustomRole { get; set; } // bit
        public Guid CreatedBy { get; set; } // nvarchar(255)
        public DateTime CreatedDate { get; set; } // datetime
        public Guid? ModifiedBy { get; set; } // nvarchar(255)
        public DateTime? ModifiedDate { get; set; } // datetime
        [NotMapped]
        public int Sequence { get; set; }
    }
}
