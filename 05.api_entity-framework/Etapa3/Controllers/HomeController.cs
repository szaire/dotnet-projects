using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Etapa3.Models;

namespace Etapa3.Controllers;

/*
Como funcionam as rotas do MVC?

Para que a integração entre Controller e View seja respeitada no padrão,
o nosso projeto ASP.NET MVC será estruturado da seguinte maneira:

	- No momento de uma requisição, será identificada qual é a classe
	Controller responsável pela requisição. Neste caso, é a classe HomeController
	- A classe HomeController terá dois métodos de acesso: Index e Privacy.
	Caso uma requisição de um desses dois métodos ocorra, a classe irá se
	comunicar com o diretório View para identificar se há alguma View com o seu
	padrão de nome (Home)
	- Caso haja, dentro do diretório correspondente, será identificado qual a página
	web que a classe HomeController está tentando requisitar.

Exemplo: 
Caso haja alguma requisição no servidor local para a página "Privacy" 
(localhost:7262/Home/Privacy), a classe HomeController será chamada para tratar essa
requisição. Como no caso é uma requisição para acessar uma página do próprio projeto,
a HomeController irá tratar essa requisição identificando se há algum método declarado
com a identificação correspondente ao nome do arquivo .cshtml dentro do diretório
"Views/Home" que é onde será efetuada a busca. Caso haja algum arquivo .cshtml dentro do
diretório, este é retornado como uma View para a visualização do usuário

Tradução de Conceitos:
--------------------------------------------------------------------x
Controller:			        |			|View:						|
                            |           |                           |
(classe) HomeController		|			|View/Home					|
(método) Index		        | acessa ->	|View/Home/Index.cshtml		|
(método) Privacy	        |			|View/Home/Privacy.cshtml	|
--------------------------------------------------------------------x
*/

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
