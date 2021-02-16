namespace CarDealership2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarDealership2.CarDealership2Entities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarDealership2.CarDealership2Entities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
         //do not have access to foreign keys yet, so need to use different unique identifier
         u => u.Email,
         new Models.User { FirstName = "Tom", LastName = "Baker", Email = "tbaker@sgcars.com", Role = "Admin", Password = "Tardis4" },
         new Models.User { FirstName = "William", LastName = "Hartnell", Email = "whartnell@sgcars.com", Role = "Admin", Password = "Tardis1" }
         );
            context.SaveChanges();

            context.Makes.AddOrUpdate(
                m => m.MakeName,
                new Models.Make
                {
                    MakeName = "Tesla",
                    DateAdded = "2/15/2021",
                    UserId = context.Users.First(u => u.Email == "tbaker@sgcars.com").UserId
                }

                );
        }
    }
}
