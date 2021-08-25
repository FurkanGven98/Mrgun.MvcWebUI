using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Mrgun.MvcWebUI.Entity;

namespace Mrgun.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){Name = "admin", Description = "admin rolü"};
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){ Name = "user", Description = "user rolü"};
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "furkanguven"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser(){Name = "furkan",Surname = "güven",UserName = "furkangven",Email = "furkanguven@yahoo.com"};
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");


            }
            if (!context.Users.Any(i => i.Name == "michaelscott"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Michael", Surname = "Scott", UserName = "michaelscott", Email = "michaelscott@yahoo.com" };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");


            }

            base.Seed(context);

        }
    }
}