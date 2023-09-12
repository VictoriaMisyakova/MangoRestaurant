using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace Mango.Services.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
