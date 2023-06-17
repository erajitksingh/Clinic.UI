using System.ComponentModel.DataAnnotations;

namespace Clinic.UI.Services.Model
{
    public class BusinessModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public bool IsTermOfService { get; set; }
    }
}
