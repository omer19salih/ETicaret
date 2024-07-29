using Microsoft.AspNet.Identity.EntityFramework;
namespace WebApplication2.Identity
{

    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}