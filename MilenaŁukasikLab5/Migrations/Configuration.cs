namespace MilenaŁukasikLab5.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MilenaŁukasikLab5.Models.EfDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MilenaŁukasikLab5.Models.EfDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(i => i.Id, new Student { Name = "Janusz", Surname = "Tracz", Email = "traczek@polska.pl", Index = "124578" });
            context.Students.AddOrUpdate(i => i.Id, new Student { Name = "Andrzej", Surname = "Duda", Email = "przypal@polska.pl", Index = "854596" });
            context.Students.AddOrUpdate(i => i.Id, new Student { Name = "Jarosław", Surname = "Kaczyński", Email = "smolensk@polska.pl", Index = "041010" });

        }
    }
}
