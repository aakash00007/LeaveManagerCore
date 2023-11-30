﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models
{
    public class RoleConfig : IdentityRole
    {
        public int Priority { get; set; }

    }
}
