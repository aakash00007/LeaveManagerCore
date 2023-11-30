using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models.DtoModels
{
    public class UserRegisterationDto
    {
        [Required(ErrorMessage = "Name Field is Required")]
        [MinLength(3)]
        [MaxLength(15)]
        [RegularExpression("^[a-zA-z]+([\\s][a-zA-Z]+)*$", ErrorMessage = "Name Field Contain Only Letter with Space")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Email Is not Valid")]
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        
        
    }
}
