using Seguridad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Seguridad.DAL
{
    public class SeguridadContext:DbContext
    {


        public DbSet<Libro> Libros { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


        }


        public SeguridadContext() : base("DefaultConnection")
        {
        }
    }
}