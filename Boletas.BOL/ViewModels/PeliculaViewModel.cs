using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletas.BOL.ViewModels
{
    public class PeliculaViewModel
    {
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}