using ISMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ISMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");
            builder.Entity<ApplicationUser>(
              entity => {
                  entity.ToTable(name: "User");
              }
            );

            builder.Entity<IdentityRole>(
              entity => {
                  entity.ToTable(name: "Role");
              }
            );
            builder.Entity<IdentityUserRole<String>>(
              entity => {
                  entity.ToTable(name: "UserRoles");
              }
            );
            builder.Entity<IdentityUserClaim<String>>(
              entity => {
                  entity.ToTable(name: "UserClaims");
              }
            );
            builder.Entity<IdentityUserLogin<String>>(
              entity => {
                  entity.ToTable(name: "UserLogins");
              }
            );

            builder.Entity<IdentityRoleClaim<String>>(
              entity => {
                  entity.ToTable(name: "RoleClaims");
              }
            );
            builder.Entity<IdentityUserClaim<String>>(
              entity => {
                  entity.ToTable(name: "UserTokens");
              }
            );
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}