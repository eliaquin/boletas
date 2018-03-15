using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Boletas.BOL.ViewModels;
using Boletas.DAL.Models;

namespace Boletas.BOL.Core
{
    public class Peliculas : Repository<Pelicula>
    {
        public bool GuardarOActualizar(PeliculaViewModel pelicula)
        {
            var p = new Pelicula
            {
                Id = pelicula.Id,
                Nombre = pelicula.Nombre,
                HorarioCartelera = pelicula.Horario,
                Precio = pelicula.Precio,
                InicioCartelera = pelicula.FechaInicio,
                FinCartelera = pelicula.FechaFin
            };
            if (p.Id > 0)
            {
                Context.Entry(p).State = EntityState.Modified;
                Context.SaveChanges();
            }
            else
            {
                Add(p);
            }
            return Context.SaveChanges() > 0;
        }

        public IEnumerable<PeliculaViewModel> BuscarDisponibles()
        {
            var res = Find(x => x.InicioCartelera >= DateTime.Today && x.FinCartelera >= DateTime.Today).ToList();
           
            return res.Select(x => 
                new PeliculaViewModel
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Horario = x.HorarioCartelera,
                    Precio = x.Precio,
                    FechaInicio = x.InicioCartelera,
                    FechaFin = x.FinCartelera
                }
            );
        }
    }
}
