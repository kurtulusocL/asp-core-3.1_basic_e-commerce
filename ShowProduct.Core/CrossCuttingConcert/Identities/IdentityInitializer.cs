using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Core.CrossCuttingConcert.Identities
{
    public static class IdentityInitializer
    {
        public static void CreateAdmin(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser appUser = new ApplicationUser
            {
                NameSurname = "Kurtuluş Öcal",
                UserName = "kurtulusocL",
                Birthdate = DateTime.Now.ToLocalTime(),
                Email = "kurtulusocal@gmail.com",
                PhoneNumber = "+905444939494",
                Gender = "Man",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true
            };

            if (userManager.FindByNameAsync("kurtulusocL").Result == null)
            {
                var identityResult = userManager.CreateAsync(appUser, "ocL_2514").Result;
            }

            if (roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin"
                };

                var identityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(appUser, role.Name).Result;
            }
        }
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string[] roleNames = { "Admin", "Helpers", "Users" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
