/*
 * 
 * date             dev                 changes
 * 1/21/2025        celina schlecht     creation of this class that extends identity user, to facilitate 
 *                                      adding first name and last name to register page
 */

using Microsoft.AspNetCore.Identity;

namespace Login.Areas.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
