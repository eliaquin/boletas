using Boletas.BOL.ViewModels;
using Boletas.DAL.Models;

namespace Boletas.BOL.Core
{
    public class Peliculas : Repository<Pelicula>
    {
        public bool InsertarPelicula(PeliculaViewModel pelicula)
        {
            var p = new Pelicula
            {
                Nombre = pelicula.Nombre,
                HorarioCartelera = pelicula.Horario,
                Precio = pelicula.Precio,
                InicioCartelera = pelicula.FechaInicio,
                FinCartelera = pelicula.FechaFin
            };
            Add(p);
            return Context.SaveChanges() > 0;
        }
    }
}
