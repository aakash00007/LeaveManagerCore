using System.ComponentModel.DataAnnotations;

namespace LeaveManagementFrontend.Models.DtoModels
{
    public class UserRegisterationDto
    {
        public string? Id { get; set; }
        [Required(ErrorMessage = "Name Field is Required")]
        [MinLength(3)]
        [MaxLength(15)]
        [RegularExpression("^[a-zA-z]+([\\s][a-zA-Z]+)*$", ErrorMessage = "Name Field Contain Only Letter with Space")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Email Is not Valid")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string? Role { get; set; } = string.Empty;
        public List<string>? Roles { get; set; } = new List<string>();
    }
}
