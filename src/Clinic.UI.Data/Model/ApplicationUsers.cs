namespace Clinic.UI.Data.Model
{
    public class ApplicationUsers
    {
        public ApplicationUsers()
        {
            //   UserLocationRoles = new List<UserLocationRoles>();
            //  UserLocationRolesPractitoner = new List<UserLocationRolesPractitoner>();
            //  UserPractitonerAccess = new List<UserPractitonerAccess>();
            ApplicationUsersLocation = new List<ApplicationUsersLocation>();
        }
        public List<ApplicationUsersLocation> ApplicationUsersLocation { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }
        public Guid ParentBusinessId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid RoleId { get; set; }
        public string Speciality { get; set; }
        public string PractitionerNo { get; set; }
        public string Qualification { get; set; }
        public string Position { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public byte[] Photo { get; set; }
        public string PostCode { get; set; }
        public string TimeZone { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public byte[] Signature { get; set; }
        public string EmailSignature { get; set; }
        public string Biography { get; set; }
        public string Notes { get; set; }
        public bool IsStatus { get; set; }
        public bool IsTermOfServicee { get; set; }
        public bool IsVerified { get; set; }
        public bool IsTreatmentPrivateNote { get; set; }
        public bool IsTreatmentSharedNote { get; set; }
        public bool IsPractitionerCalendar { get; set; }
        public bool IsDoubleBooking { get; set; }
        public bool IsPatientOnlineBooking { get; set; }
        public bool IsCancelledAppointment { get; set; }
        public bool IsOnlineBooking { get; set; }
        public bool IsAccess { get; set; }
        public string PrivateNotes { get; set; }
        public string SharedNotes { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogoutDateTime { get; set; }
        public string PractitionerCalendarColor { get; set; }

        #region for Internal use only
        public string GetFullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        public string FullNameWithTitle
        {
            get { return string.Format("{0} {1} {2}", Title, FirstName, LastName); }
        }
        #endregion
    }

}
