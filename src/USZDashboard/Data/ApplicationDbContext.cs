using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using USZDashboard.Models;
using USZDashboard.Models.DashboardViewModels;

namespace USZDashboard.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }


        public DbSet<User> User { get; set; }

        public DbSet<Clinic> Clinic { get; set; }

        public DbSet<Dashboard> Dashboard { get; set; }

        public DbSet<Widget> Widget { get; set; }

        public DbSet<AdminRight> AdminRight { get; set; }

        public DbSet<UserDashboard> UserDashboard { get; set; }

        public DbSet<UserGroup> UserGroup { get; set; }

        public DbSet<TableColumn> TableColumn { get; set; }

        public DbSet<TableRow> TableRow { get; set; }

        public DbSet<Structure> Structure { get; set; }

        public DbSet<WidgetConfigration> WidgetConfigration { get; set; }
    }
}
