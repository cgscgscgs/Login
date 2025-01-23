using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
//Authorization ensures users identity is verified

namespace Login.Pages
{
    // This ensures that users not logged in cannot access this page
    [Authorize]
    public class SecurePageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
