
using Microsoft.AspNetCore.Identity;

namespace MyProj.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}

