using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models.ResponseModels
{
    public class ApiResponse
    {
        public bool? Success { get; set; }
        public string? Error { get; set; }
        public string? Message { get; set; }

    }
}
