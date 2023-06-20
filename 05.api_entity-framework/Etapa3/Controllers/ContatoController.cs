using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa3.Contexts;
using Etapa3.Models;
using Microsoft.AspNetCore.Mvc;

/*
    A ContatoController será responsável por criar as páginas web que irão
    interagir com a tabela Contatos do banco de dados relacional. Ela será a
    responsável, também, por criar as rotas de acesso a partir da url ".../Contato/..."
*/

namespace Etapa3.Controllers
{
    // Em vez de herdar da ControllerBase (como no caso de uma API), uma página
    // Web irá herdar da classe Controller
    public class ContatoController : Controller
    {
        // Criando a única instância da variável context para acessar o banco de dados
		private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            // Atribuindo o banco de dados AgendaMVC para nossa context
			_context = context;
		}

		// Para definirmos uma página padrão, podemos utilizar o método especial
		// "Index" que indica uma página inicial. A estrutura do método é semelhante
		// a de uma API.
		public IActionResult Index()
        {
            // Acessando a tabela contatos e retornando uma lista ordenada para
            // a variável contatos
			var contatos = _context.Contatos.ToList();

			// Caso o método seja criado com um retorno View, é necessário que uma
			// página web com a mesma identificação da assinatura do método exista
			// para que o ASP.NET possa reconhcer a página cshtml e carregar ela
			// no browser.
            // Por fim, retorna a View recebendo o parâmetro contatos, o qual será
            // a base para construir o modelo da tabela da página Index nas Views
			return View(contatos);
		}
        // Nesse caso, como criamos uma controller "Contato" e um método que retorna
        // uma View por um método com assinatura "Index", a estrutura do nosso dessa 
        // nossa página MVC será dada por Views/Contato/Index.cshtml

        // Esse método Criar está fazendo referência à página web "Criar" que é
        // responsável por adicionar contatos ao banco de dados. Está localizada no
        // diretório "Views/Contato/Criar.cshtml".
        public IActionResult Criar()
        {
			return View();
		}

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            // O que é model state?
            if (ModelState.IsValid)
            {
				_context.Contatos.Add(contato);
				_context.SaveChanges();
                // O que é redirect to action
                // O que é nameof(Index)
				return RedirectToAction(nameof(Index));
			}
			return View(contato);
		}
    }
}