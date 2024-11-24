using System.ComponentModel.DataAnnotations;

namespace MyProj.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}



