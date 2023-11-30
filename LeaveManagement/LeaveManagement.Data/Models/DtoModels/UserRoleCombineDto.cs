using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models.DtoModels
{
    public class UserRoleCombineDto
    {
        public User User { get; set; }
        public string? Role { get; set; }
    }
}
