using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Etapa2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult obterDataHora()
        {
			var data = DateTime.Now.ToLongDateString();
			var hora = DateTime.Now.ToLongTimeString();
			return Ok(new { data, hora });
		}
    }
}