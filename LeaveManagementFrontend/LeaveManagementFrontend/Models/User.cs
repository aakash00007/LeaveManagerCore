using Microsoft.AspNetCore.Identity;

namespace LeaveManagementFrontend.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

    }
}
