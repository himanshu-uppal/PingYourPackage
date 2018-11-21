namespace PingYourPackage.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PingYourPackage.Domain.Entities;
    using PingYourPackage.Domain.Concrete;

    public sealed class Configuration : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFDbContext context)
        {
            context.Roles.AddOrUpdate(role=>role.Name,
                new Role { Key = Guid.NewGuid(),Name="Admin"},
                new Role { Key = Guid.NewGuid(), Name = "Affiliate" },
                new Role { Key = Guid.NewGuid(), Name = "Employee" });
            
        }
    }
}
