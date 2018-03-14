using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletas.DAL.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string HorarioCartelera { get; set; }
        public decimal Precio { get; set; }
        public DateTime InicioCartelera { get; set; }
        public DateTime FinCartelera { get; set; }
    }
}
