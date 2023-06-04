using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// A classe controller é simplesmente uma classe que vai agrupar
// as "requisições HTTP" e "disponibilizar os endpoints", ou seja
// as ações da classe.
// + Requisições HTTP: GET, PUT, POST, DELETE, etc...
// + Disponibilizar EndPoints: URL's com o endereço que apontam para
//   determinada informação na rede.
// Tudo que tenha relação com a classe Usuário será colocado aqui
// É possível colocar artefatos que não são pertencentes ao usuário
// também, porém não faria sentido.
namespace Web_API.Controllers
{
    // A classe UsuarioController herda de ControllerBase, a qual é
    // uma classe abstrata que disponibiliza métodos para suas classes
    // filhas utilizarem.
    // Observação: O nome da classe Sempre deve ser [AlgumaCoisa]Controller,
    // pois o .NET irá interpretar esse nome e, assim, criar uma rota com
    // essa identificação.

    // Atributos da classe:
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        // Como esse método será referenciado nas requisições API
        [HttpGet("ObterDataHoraAtual")] // Esse método representará um endpoint HTTP,
                                        // ou seja, uma URL (endereço) que realizará
                                        // alguma ação, nesse caso, uma requisição de
                                        // GET
        public IActionResult ObterDataHora()
        {
			var obj = new
			{
				Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
			};

			return Ok(obj);
		}
        // QUANDO OBTIVER DÚVIDAS: Ver vídeo aula "Módulo 5/Etapa 1/Entendendo as Rotas

        // Criando uma rota com parâmetros
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
			var mensagem = $"Olá, {nome}! Seja bem vindo!";
			return Ok(new { mensagem });
		}
    }
}