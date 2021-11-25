using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengerNubiMetrics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        // GET: api/<PaisesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            
        }

       // GET api/<PaisesController>/PAIS:AR,BR,CO
       [HttpGet("{pais}")]
        public IActionResult Get(string pais)
        {

            if (pais == "AR")
                return Redirect("https://api.mercadolibre.com/classified_locations/countries/AR");
            else
            {
                if (pais == "BR" || pais == "CO")
                {
                    return Unauthorized();
                }
                return NotFound();
            }


        }       
    }
}
