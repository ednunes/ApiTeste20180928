using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste20180928.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values/5
        [Route("GetNumeroMultiplicadoPorEleMesmo")]
        [HttpGet("{id}")]
        public IActionResult GetNumeroMultiplicadoPorEleMesmo(int id)
        {
            return StatusCode(200, $"O número {id} multiplicado por ele mesmo é igual a {id*id}.");
        }

        // POST api/values/ValidarNumero
        [Route("ValidarNumero")]
        [HttpGet("{id}")]
        public IActionResult ValidarNumero(int id)
        {
            if (id <= 0) return StatusCode(400, "Informe um número maior que zero!");
            return StatusCode(200, id);
        }
    }
}
