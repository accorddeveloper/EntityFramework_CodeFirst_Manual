namespace EntityFramework_CodeFirst_Manual.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework_CodeFirst_Manual.Model.LunchBoxModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityFramework_CodeFirst_Manual.Model.LunchBoxModel context)
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
            context.Product.AddOrUpdate(
                p => p.Name,
                new Product { Name = "�ư���", Price = 60, Category = 1, SPrice= 0},
                new Product { Name = "�ư���", Price = 65, Category = 2, SPrice = 0 },
                new Product { Name = "�ޱƶ�", Price = 70, Category = 1, SPrice = 0 },
                new Product { Name = "���L��", Price = 70, Category = 1, SPrice = 0 },
                new Product { Name = "���K��", Price = 35, Category = 2, SPrice = 0 },
                new Product { Name = "���궺", Price = 35, Category = 1, SPrice = 0 },
                new Product { Name = "�J����", Price = 35, Category = 1, SPrice = 0 },
                new Product { Name = "������", Price = 60, Category = 2, SPrice = 0 },
                new Product { Name = "�ư���", Price = 50, Category = 3, SPrice = 0 },
                new Product { Name = "�J���", Price = 30, Category = 3, SPrice = 0 },
                new Product { Name = "�����׶�", Price = 60, Category = 1, SPrice = 0 },
                new Product { Name = "�Ļ���", Price = 30, Category = 3, SPrice = 0 },
                new Product { Name = "������", Price = 30, Category = 3, SPrice = 0 }
                );
        }
    }
}
