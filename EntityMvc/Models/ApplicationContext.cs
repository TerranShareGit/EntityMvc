using Microsoft.AspNet.Identity.EntityFramework;

namespace EntityMvc.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("MvcContext") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}