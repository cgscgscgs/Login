using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Login.Areas.Identity;
namespace Login.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // this allows us to use ApplicationUser class
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
