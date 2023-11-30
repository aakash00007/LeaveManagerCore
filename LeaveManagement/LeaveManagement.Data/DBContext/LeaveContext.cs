using LeaveManagement.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.DBContext
{
    public class LeaveContext : IdentityDbContext<User>
    {
        public LeaveContext(DbContextOptions<LeaveContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<RoleConfig> RoleConfigs { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; } 
        public DbSet<Approval> Approvals { get; set; }
    }
}
