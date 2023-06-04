using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TesteController : ControllerBase
	{
		[HttpGet("ObterDadosTeste")]
		public IActionResult obterDados()
		{
			var dados = new
			{
				DadosObtidos = "Obtidos com sucesso!"
			};

			return Ok(dados);
		}
	}
}