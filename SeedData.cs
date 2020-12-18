using System;
using Microsoft.AspNetCore.Identity;

namespace leave_management
{
    public static class SeedData
    {
        public static void Seed(UserManager<IdentityUser> manager, RoleManager<IdentityRole> roleManager)
        {
            // Roles need to be created first
            SeedRoles(roleManager);
            SeedUsers(manager);
        }

        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if(userManager.FindByNameAsync("admin").Result == null) {
                var user = new IdentityUser { UserName = "admin@localhost.com", Email = "admin@localhost.com" };
                var result = userManager.CreateAsync(user, "Password1@").Result;

                if(result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }

            if (userManager.FindByNameAsync("employee").Result == null)
            {
                var user = new IdentityUser { UserName = "employee@localhost.com", Email = "employee@localhost.com" };
                var result = userManager.CreateAsync(user, "Password1@").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Employee").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if(!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole { Name = "Administrator" };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole { Name = "Employee" };
                var result = roleManager.CreateAsync(role);
            }
        }
    }
}
