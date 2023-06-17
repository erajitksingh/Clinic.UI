using Clinic.UI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Clinic.UI.Data.Helpers
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Business> Business { get; set; }
        public DbSet<BusinessLocation> BusinessLocation { get; set; }
        public DbSet<BusinessRoles> BusinessRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(x => x.Id).IsRequired();
                entity.Property(x => x.ParentBusinessId).IsRequired();
                entity.Property(x => x.BusinessName).IsRequired();
                entity.Property(x => x.BusinessLogo);
                entity.Property(x => x.EmailId);
                entity.Property(x => x.BusinessRegistrationName);
                entity.Property(x => x.BusinessRegistrationNo);
                entity.Property(x => x.ContactPerson);
                entity.Property(x => x.Address1);
                entity.Property(x => x.Address2);
                entity.Property(x => x.Country);
                entity.Property(x => x.State);
                entity.Property(x => x.City);
                entity.Property(x => x.PostCode);
                entity.Property(x => x.Phone);
                entity.Property(x => x.Mobile);
                entity.Property(x => x.Fax);
                entity.Property(x => x.Website);
                entity.Property(x => x.Status);
                entity.Property(x => x.IsDefault);
                entity.Property(x => x.TimeZone);
                entity.Property(x => x.StartTime);
                entity.Property(x => x.EndTime);
                entity.Property(x => x.BankName);
                entity.Property(x => x.BsbNumber);
                entity.Property(x => x.AccountNumber);
                entity.Property(x => x.InvoiceTerms);
                entity.Property(x => x.Notes);
                entity.Property(x => x.CreatedBy);
                entity.Property(x => x.CreatedDate);
                entity.Property(x => x.ModifiedBy);
                entity.Property(x => x.ModifiedDate);
            });

            modelBuilder.Entity<BusinessLocation>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(x => x.Id).IsRequired();
                entity.Property(x => x.ParentBusinessId).IsRequired();
                entity.Property(x => x.LocationName).IsRequired();
                entity.Property(x => x.LocationLogo);
                entity.Property(x => x.EmailId);
                entity.Property(x => x.LocationRegistrationName);
                entity.Property(x => x.LocationRegistrationNo);
                entity.Property(x => x.ContactPerson);
                entity.Property(x => x.Address1);
                entity.Property(x => x.Address2);
                entity.Property(x => x.Country);
                entity.Property(x => x.State);
                entity.Property(x => x.City);
                entity.Property(x => x.PostCode);
                entity.Property(x => x.Phone);
                entity.Property(x => x.Mobile);
                entity.Property(x => x.Fax);
                entity.Property(x => x.Website);
                entity.Property(x => x.Status);
                entity.Property(x => x.IsDefault);
                entity.Property(x => x.TimeZone);
                entity.Property(x => x.StartTime);
                entity.Property(x => x.EndTime);
                entity.Property(x => x.TimeSlot);
                entity.Property(x => x.TimeSlotSize);
                entity.Property(x => x.CalendarColor);
                entity.Property(x => x.IsDoubleBooking);
                entity.Property(x => x.IsPatientOnlineBooking);
                entity.Property(x => x.BankName);
                entity.Property(x => x.BsbNumber);
                entity.Property(x => x.AccountNumber);
                entity.Property(x => x.InvoiceTerms);
                entity.Property(x => x.Notes);
                entity.Property(x => x.CreatedBy);
                entity.Property(x => x.CreatedDate);
                entity.Property(x => x.ModifiedBy);
                entity.Property(x => x.ModifiedDate);
            });

        }
    }
}
