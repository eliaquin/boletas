using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletas.DAL.Models;

namespace Boletas.DAL.Configurations
{
    public class PeliculaConf : EntityTypeConfiguration<Pelicula>
    {
        public PeliculaConf()
        {
            ToTable("Peliculas");
            Property(x => x.HorarioCartelera)
                .HasMaxLength(100);
            Property(x => x.Nombre)
                .HasMaxLength(150);
        }
    }
}
