namespace Clinic.UI.Data.Model
{
    public class Business
    {
        public Guid Id { get; set; }
        public Guid ParentBusinessId { get; set; }
        public string BusinessName { get; set; }
        public byte[] BusinessLogo { get; set; }
        public string EmailId { get; set; }
        public string BusinessRegistrationName { get; set; }
        public string BusinessRegistrationNo { get; set; }
        public string ContactPerson { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public bool Status { get; set; }
        public bool IsDefault { get; set; }
        public string TimeZone { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string BankName { get; set; }
        public string BsbNumber { get; set; }
        public string AccountNumber { get; set; }
        public string InvoiceTerms { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
