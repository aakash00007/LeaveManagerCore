using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models.DtoModels
{
    public class SetPasswordDto
    {
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\\s).{8,15}$", ErrorMessage = "Password must contain one Uppercase, Lowercase,Numeric and Special Symbol")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\\s).{8,15}$", ErrorMessage = "Password must contain one Uppercase, Lowercase,Numeric and Special Symbol")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
