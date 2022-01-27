using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.Login
{

    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Pass1234?";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            UserManager<User> userManager = (UserManager<User>)scope
            .ServiceProvider.GetRequiredService(typeof(UserManager<User>));
            RoleManager<IdentityRole> roleManager = (RoleManager<IdentityRole>)scope
            .ServiceProvider.GetRequiredService(typeof(RoleManager<IdentityRole>));


            //var userManager = (UserManager<User>)scope.ServiceProvider.GetService(typeof(UserManager<User>));
            User user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new User { 
                    UserName=adminUser,
                    Email = "",
                    Name = "",
                    LastName = "",
                    CreationDate = DateTime.Now,
                };

                await userManager.CreateAsync(user, adminPassword);
            }
        }

    }
}
