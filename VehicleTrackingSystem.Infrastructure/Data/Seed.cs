using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleTrackingSystem.Domain.Entities;
using VehicleTrackingSystem.Infrastructure.Identity;

namespace VehicleTrackingSystem.Infrastructure.Data
{
    public class Seed
    {

        public static void SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager, IActionDescriptorCollectionProvider provider, AppDbContext context)
        {
            if (!userManager.Users.Any())
            {
                // Creating some roles
                var roles = new List<Role>
                {
                    new Role {Name = "Admin"},
                    new Role {Name = "Driver"},
                    new Role {Name = "Customer"}
                };

                foreach (var role in roles)
                {
                    roleManager.CreateAsync(role).Wait();
                }

                //Creating admin user
                var adminUser = new User
                {
                    UserName = "Admin",
                    UserTypeId=1, //1 indicate as an administrator user 
                    CountryCode="BD",
                    Email="netsazzad@gmail.com",
                    PhoneNumber="01722536673",
                    ActiveStatus="Y",

                    
                };

                var result = userManager.CreateAsync(adminUser, "Admin").Result;

                if (result.Succeeded)
                {
                    var admin = userManager.FindByNameAsync("Admin").Result;
                    userManager.AddToRolesAsync(admin, new[] { "Admin" });
                }
            }

            List<string> actionEntities = new List<string>();
            var controllerList = provider.ActionDescriptors.Items.Select(x => x.RouteValues["Controller"]).Distinct().ToList();

            foreach (var controller in controllerList)
            {
                var actionList = provider.ActionDescriptors.Items.Where(c => c.RouteValues["Controller"] == controller).Select(x => x.RouteValues["Action"]).ToList();
                foreach (var action in actionList)
                {
                    string actionEntity = "/" + controller + "/" + action;
                    actionEntities.Add(actionEntity);
                }
            }

            //AddActionToRole(actionEntities, roleManager);

            AddActionToView(actionEntities, context);
        }

        private static void AddActionToRole(List<string> entities, RoleManager<Role> roleManager)
        {
            var roles = new List<Role>();

            foreach (var entity in entities)
            {
                var role = new Role { Name = entity };
                roles.Add(role);
            }

            var allRole = roleManager.Roles.Where(c => c.Name != "Admin");

            foreach (var role in roles)
            {
                var hasInRole = allRole.FirstOrDefault(c => c.Name == role.Name);
                if (hasInRole != null)
                    continue;
                roleManager.CreateAsync(role).Wait();
            }
        }

        private static void AddActionToView(List<string> entities, AppDbContext context)
        {
            var actions = new List<UrlAction>();

            foreach (var entity in entities)
            {
                var role = new UrlAction { Name = entity };
                actions.Add(role);
            }

            var allRole = context.UrlActions.Where(c => c.Deleted == false);

            foreach (var role in actions)
            {
                var hasInRole = allRole.FirstOrDefault(c => c.Name == role.Name);
                if (hasInRole != null)
                    continue;
                context.UrlActions.Add(role);
                context.SaveChanges();
            }
        }



    }
}
