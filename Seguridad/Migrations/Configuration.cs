namespace Seguridad.Migrations
{
    using Seguridad.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Seguridad.DAL.SeguridadContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Seguridad.DAL.SeguridadContext context)
        {
            var libros = new List<Libro>
            {
                new Libro {  tittle ="La tabla de Flandes"},
                new Libro {  tittle ="El diario de Anna Frank"},
            };


            libros.ForEach(c => context.Libros.AddOrUpdate(c));
            context.SaveChanges();
        }
    }
}
