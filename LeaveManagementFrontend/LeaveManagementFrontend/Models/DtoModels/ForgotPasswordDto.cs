using System.ComponentModel.DataAnnotations;

namespace LeaveManagementFrontend.Models.DtoModels
{
    public class ForgotPasswordDto
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Email Is not Valid")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
