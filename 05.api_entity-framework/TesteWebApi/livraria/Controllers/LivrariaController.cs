using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livraria.Context;
using Microsoft.AspNetCore.Mvc;

namespace livraria.Controllers
{
    public class LivrariaController : Controller
    {
        private readonly AppDbContext _context;

        public LivrariaController(AppDbContext context)
        {
			_context = context;
		}

		[HttpGet("ListaLivros")]
		public IActionResult ListaLivros()
        {
			var books = _context.Livros.ToList();
			return View(books);
		}
	}
}