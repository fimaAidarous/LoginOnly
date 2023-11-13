using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWithLogin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ProjectWithLogin.Models.Domain
{
        public class DatabaseContext : IdentityDbContext<ApplicationUser>
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {}
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetMovement> AssetMovements { get; set; }
        public DbSet<AssetMaintenance> AssetMaintenances { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
    
}
