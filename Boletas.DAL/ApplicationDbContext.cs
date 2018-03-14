using Boletas.DAL.Configurations;
using Boletas.DAL.Models;

namespace Boletas.DAL
{
    using System.Data.Entity;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PeliculaConf());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Pelicula> Peliculas { get; set; }
    }
}