using Microsoft.AspNetCore.Identity;
using WebClient.Models;
using WebClient.Utility;

namespace WebClient.DataAccess.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync(SD.ADMIN_USERNAME).Result == null)
            {
                ApplicationUser admin = new ApplicationUser
                {
                    UserName = SD.ADMIN_USERNAME,
                    Email = SD.ADMIN_EMAIL,
                    PhoneNumber = SD.ADMIN_PHONE_NUMBER,
                    FirstName = SD.ADMIN_FIRST_NAME,
                    Surname = SD.ADMIN_SURNAME
                };

                IdentityResult result = userManager.CreateAsync(admin, SD.ADMIN_PASSWORD).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, SD.ROLE_ADMIN).Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
            if (roleManager.FindByNameAsync(SD.ROLE_ADMIN).Result == null)
            {
                ApplicationRole adminRole = new ApplicationRole
                {
                    Name = SD.ROLE_ADMIN
                };

                roleManager.CreateAsync(adminRole);
            }
        }
    }
}
