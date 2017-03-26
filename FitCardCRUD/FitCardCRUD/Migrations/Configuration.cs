namespace FitCardCRUD.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FitCardCRUD.Models.FitCardCRUDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //Migration automática
            AutomaticMigrationDataLossAllowed = true; //Evita a perda de dados durante uma Migration
        }

        protected override void Seed(FitCardCRUD.Models.FitCardCRUDContext context)
        {
            context.Categorias.AddOrUpdate(c => c.Name,
                      new Categoria { Name = "Supermercado" },
                      new Categoria { Name = "Restaurante" },
                      new Categoria { Name = "Borracharia" },
                      new Categoria { Name = "Posto" },
                      new Categoria { Name = "Oficina" }
                );

        }
    }
}
