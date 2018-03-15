using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Boletas.BOL.Core;
using Boletas.BOL.ViewModels;

namespace Boletas.Controllers.Api
{
    [RoutePrefix("api/boletas")]
    public class BoletasController : ApiController
    {
        [HttpPost]
        [Route("guardarpelicula")]
        public bool GuardarPelicula([FromBody]PeliculaViewModel pelicula)
        {
            var p = new Peliculas();
            return p.GuardarOActualizar(pelicula);
        }

        [HttpGet]
        [Route("buscartodo")]
        public IEnumerable<PeliculaViewModel> BuscarTodo()
        {
            var p = new Peliculas();
            return p.BuscarDisponibles();
        }
    }
}
