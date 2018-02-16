using Microsoft.AspNet.Identity.EntityFramework;

namespace EntityMvc.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Description { get; set; }

        public ApplicationUser()
        {
        }
    }
}