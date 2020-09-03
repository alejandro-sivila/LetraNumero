using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumeroaLetra.Helpers;

namespace NumeroaLetra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string Literalget(int num) {
            return (Conversores.NumeroALetras(num));
        }

        [HttpPost]
        public string Literalpost([FromHeader] int num)
        {
            return (Conversores.NumeroALetras(num));
        }
    }
}
