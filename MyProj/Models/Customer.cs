using System.ComponentModel.DataAnnotations;

namespace MyProj.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Nationality { get; set; }

        public string Status { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}

