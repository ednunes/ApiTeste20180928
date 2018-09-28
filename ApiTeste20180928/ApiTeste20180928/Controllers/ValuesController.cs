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
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0) return StatusCode(400, "Informe um número maior que zero!");
            return StatusCode(200, $"Você digitou o número {id}.");
        }
    }
}
