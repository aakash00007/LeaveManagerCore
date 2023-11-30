using Microsoft.AspNetCore.Identity;

namespace LeaveManagementFrontend.Models.DtoModels
{
    public class UserDto
    {
        public User? User { get; set; }
        public string? Role { get; set; }
    }
}
