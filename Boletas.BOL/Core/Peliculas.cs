using Boletas.DAL.Models;

namespace Boletas.BOL.Core
{
    public class Peliculas : Repository<Pelicula>
    {

    }

    public class MiClase
    {
        public void MiMetodo()
        {
            var peliculas = new Peliculas();
            peliculas.Add(new Pelicula
            {
                Nombre = "Duro de Programar",
                HorarioCartelera = "5:00 PM, 7:00 PM, 10:00 PM",
                Precio = 250.00m
            });
            peliculas.Context.SaveChanges();



        }
    }
}
