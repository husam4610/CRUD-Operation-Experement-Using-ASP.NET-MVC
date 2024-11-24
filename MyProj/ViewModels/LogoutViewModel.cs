using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MyProj.Areas.Identity.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LogoutModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        // This is the action method for logging out the user
        public async Task<IActionResult> OnPostAsync()
        {
            // Sign the user out
            await _signInManager.SignOutAsync();

            // Redirect to the login page after logout
            return RedirectToPage("/Account/Login");
        }
    }
}

