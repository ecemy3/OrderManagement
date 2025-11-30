namespace OrderManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OrderManagement.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // Otomatik Migration aktif
            AutomaticMigrationDataLossAllowed = true; // Veri kaybına izin (Opsiyonel)
        }

        protected override void Seed(OrderManagement.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
