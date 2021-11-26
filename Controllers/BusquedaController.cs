using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerNubiMetrics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusquedaController : ControllerBase
    {
        // GET: api/<BusquedaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Pruebame en Postman con la url https://localhost:[nroPuerto]/api/Busqueda/iphone" };

        }

        // GET api/<BusquedaController>/iphone

        [HttpGet("{filter}")]
        public ActionResult<IEnumerable<string>> Get(string filter)
        {
            //results” solo incluir los fields: “id, site_id, title, price, seller.id, permalink
            string url = "https://api.mercadolibre.com/sites/MLA/search?q=" + filter+ "?fields=id, site_id, title,price, seller.id, permalink";
            return Redirect(url);
         
        }
    }
}
