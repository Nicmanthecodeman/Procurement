using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebClient.Models;

namespace WebClient.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser,
        ApplicationRole,
        int,
        IdentityUserClaim<int>,
        ApplicationUserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("proc");

            builder.Entity<ApplicationUser>(user =>
            {
                user.ToTable("Users");

                user.Property(u => u.Id)
                    .HasColumnName("User_ID");

                user.Property(u => u.Email)
                    .HasColumnName("User_Email")
                    .HasMaxLength(100)
                    .IsRequired();

                user.Property(u => u.UserName)
                    .HasColumnName("Username")
                    .HasMaxLength(50)
                    .IsRequired();

                user.Property(u => u.PhoneNumber)
                    .HasColumnName("User_Phone_Number")
                    .HasMaxLength(50)
                    .IsRequired();

                user.Property(u => u.PasswordHash)
                    .HasColumnName("Password")
                    .HasMaxLength(100)
                    .IsRequired();

                user.Ignore(u => u.AccessFailedCount);
                user.Ignore(u => u.ConcurrencyStamp);
                user.Ignore(u => u.PhoneNumberConfirmed);
                user.Ignore(u => u.EmailConfirmed);
                user.Ignore(u => u.TwoFactorEnabled);
                user.Ignore(u => u.LockoutEnd);
                user.Ignore(u => u.LockoutEnabled);

                user.HasMany(u => u.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                user.HasMany(e => e.Claims)
                    .WithOne()
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                user.HasMany(e => e.Logins)
                    .WithOne()
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                user.HasMany(e => e.Tokens)
                    .WithOne()
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();
            });

            builder.Entity<ApplicationRole>(role =>
            {
                role.ToTable("Roles");

                role.Ignore(r => r.ConcurrencyStamp);

                role.Property(r => r.Id)
                    .HasColumnName("Role_ID");

                role.Property(r => r.Name)
                    .HasColumnName("Role_Name")
                    .HasMaxLength(50)
                    .IsRequired();

                role.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            builder.Entity<ApplicationUserRole>(ur =>
            {
                ur.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<int>>(uc =>
            {
                uc.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<int>>(ul =>
            {
                ul.ToTable("UserLogins");
            });

            builder.Entity<IdentityUserToken<int>>(ut =>
            {
                ut.ToTable("UserTokens");
            });

            builder.Entity<IdentityRoleClaim<int>>(rc =>
            {
                rc.ToTable("RoleClaims");
            });
        }
    }
}
