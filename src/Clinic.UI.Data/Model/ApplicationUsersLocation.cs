using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.UI.Data.Model
{
    
    [Table("ApplicationUsersLocation")]
    public class ApplicationUsersLocation
    {
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Application User Id is required")]
        public Guid ApplicationUsersId { get; set; }
        [Required(ErrorMessage = "Location Id is required")]
        public Guid LocationId { get; set; }
        [MaxLength(12)]
        [Required(ErrorMessage = "Appointment Colour is required")]
        public string AppointmentColour { get; set; }
        [Required(ErrorMessage = "Include In Scheduler is required")]
        public bool IncludeInScheduler { get; set; }
        [Required(ErrorMessage = "Treatment Notes Privacy is required")]
        public bool TreatmentNotesPrivacy { get; set; }
        [Required(ErrorMessage = "Double Booking is required")]
        public bool DoubleBooking { get; set; }
        [Required(ErrorMessage = "Online Booking is required")]
        public bool OnlineBooking { get; set; }
        [Required(ErrorMessage = "Online Booking Confirmation is required")]
        public bool IsOnlineBookingConfirmation { get; set; }
        [Required(ErrorMessage = "Online Booking Cancellation is required")]
        public bool IsOnlineBookingCancellation { get; set; }
        [Required(ErrorMessage = "Created Date is required")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Modified Date is required")]
        public DateTime ModifiedDate { get; set; }
        [Required(ErrorMessage = "Last Modified By is required")]
        public Guid LastModifiedBy { get; set; }
        [Required(ErrorMessage = "Is Disabled is required")]
        public bool IsDisabled { get; set; }

        public ApplicationUsersLocation()
        {
            ApplicationUsersLocationRoles = new List<ApplicationUsersLocationRoles>();
            ApplicationUsersPractApptAccess = new List<ApplicationUsersPractApptAccess>();
            CreatedDate = DateTime.Now.Date;
            ModifiedDate = DateTime.Now.Date;
        }
        public List<ApplicationUsersLocationRoles> ApplicationUsersLocationRoles { get; set; }
        public List<ApplicationUsersPractApptAccess> ApplicationUsersPractApptAccess { get; set; }
    }

    [Table("ApplicationUsersLocationRoles")]
    public class ApplicationUsersLocationRoles
    {
        public ApplicationUsersLocationRoles()
        {
            ApplicationUsersPractSpltyandOths = new List<ApplicationUsersPractSpltyandOths>();
            CreatedDate = DateTime.Now.Date;
            ModifiedDate = DateTime.Now.Date;
            //ApplicationUsersPractSplty = new List<ApplicationUsersPractSplty>();
            //ApplicationUsersPractSpltyOths = new List<ApplicationUsersPractSpltyOths>();
        }

        //[Obsolete]
        //public List<ApplicationUsersPractSplty> ApplicationUsersPractSplty { get; set; }
        //[Obsolete] 
        //public List<ApplicationUsersPractSpltyOths> ApplicationUsersPractSpltyOths { get; set; }
        public List<ApplicationUsersPractSpltyandOths> ApplicationUsersPractSpltyandOths { get; set; }
        
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Application Users Location Id is required")]
        public Guid ApplicationUsersLocationId { get; set; }
        [Required(ErrorMessage = "Role Id is required")]
        public Guid RoleId { get; set; }
        [Required(ErrorMessage = "Created Date is required")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Modified Date is required")]
        public DateTime ModifiedDate { get; set; }
        [Required(ErrorMessage = "Last Modified By is required")]
        public Guid LastModifiedBy { get; set; }
        public bool IsDisabled { get; set; }
    }

    [Table("ApplicationUsersPractApptAccess")]
    public class ApplicationUsersPractApptAccess
    {
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Application User Location Id is required")]
        public Guid ApplicationUsersLocationId { get; set; }
        [Required(ErrorMessage = "Practitoner Id is required")]
        public Guid PractitonerId { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsDisabled { get; set; }
    }



    [Table("ApplicationUsersPractSpltyandOths")]
    public class ApplicationUsersPractSpltyandOths
    {
        public ApplicationUsersPractSpltyandOths()
        {
            this.Type = 0;
            this.IsDisabled = false;
        }

        [Key]
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Application Users Location Roles Id is required")]
        public Guid ApplicationUsersLocationRolesId { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public byte Type { get; set; }
        public int? ServiceTypeId { get; set; }
        [Required(ErrorMessage = "Is Disabled is required")]
        public bool IsDisabled { get; set; }
        [Required(ErrorMessage = "Speciality Id is required")]
        public Guid SpecialityId { get; set; }
        [MaxLength(100)]
        public string ProviderNumber { get; set; }
        [MaxLength(255)]
        public string OtherIdName { get; set; }
        [MaxLength(100)]
        public string OtherID { get; set; }
    }


    //[Table("ApplicationUsersPractSplty")]
    //public class ApplicationUsersPractSplty
    //{
    //    [Key]
    //    [Required(ErrorMessage = "Id is required")]
    //    public Guid Id { get; set; }
    //    [Required(ErrorMessage = "Application Users Location Roles Id is required")]
    //    public Guid ApplicationUsersLocationRolesId { get; set; }
    //    public int? ServiceTypeId { get; set; }
    //    [Required(ErrorMessage = "Speciality Id is required")]
    //    public Guid SpecialityId { get; set; }
    //    [MaxLength(100)]
    //    public string ProviderNumber { get; set; }
    //    public bool IsDisabled { get; set; }
    //}

    //[Table("ApplicationUsersPractSpltyOths")]
    //public class ApplicationUsersPractSpltyOths
    //{
    //    [Key]
    //    [Required(ErrorMessage = "Id is required")]
    //    public Guid Id { get; set; }
    //    [Required(ErrorMessage = "Application Users Location Roles Id is required")]
    //    public Guid ApplicationUsersLocationRolesId { get; set; }
    //    [Required(ErrorMessage = "Speciality Id is required")]
    //    public Guid SpecialityId { get; set; }
    //    [MaxLength(255)]
    //    public string OtherIdName { get; set; }
    //    [MaxLength(100)]
    //    public string OtherID { get; set; }
    //    public bool IsDisabled { get; set; }
    //}




    public class ViewPractitionersSpeciality
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApplicationUsersId { get; set; }
        public Guid LocationId { get; set; }
        public Guid RoleId { get; set; }
        public Guid SpecialityId { get; set; }
        public string ProviderNumber { get; set; }
        public int? ServiceTypeId { get; set; }
        public string OtherIdName { get; set; }
        public string OtherID { get; set; }
        public string NickName { get; set; }
        public string SpecialityName { get; set; }
        public bool SpecialityIsStatus { get; set; }
        public bool ApplicationUserIsStatus { get; set; }

        public string LocationName { get; set; }
        public Guid ParentBusinessId { get; set; }
    }


    public class ViewAllPractitioners
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApplicationUsersId { get; set; }
        public Guid LocationId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string NickName { get; set; }
        public string LocationName { get; set; }
        public Guid ParentBusinessId { get; set; }
    }

    public class ViewAllApplicationUserLocationRole
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApplicationUsersId { get; set; }
        public Guid LocationId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string NickName { get; set; }
        public string LocationName { get; set; }
        public Guid ParentBusinessId { get; set; }
    }

    public class ViewAllApplicationUsersPractApptAccess
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApplicationUsersId { get; set; }
        public Guid LocationId { get; set; }
        public Guid PractitonerId { get; set; }
        public string NickName { get; set; }
        public string LocationName { get; set; }
        public Guid ParentBusinessId { get; set; }
        public bool IsUserLocationDisabled { get; set; }
        public bool IsPractApptAccessDisabled { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IncludeInScheduler { get; set; }
    }

}
