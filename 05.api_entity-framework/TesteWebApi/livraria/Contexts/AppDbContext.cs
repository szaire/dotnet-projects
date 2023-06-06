using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace livraria.Context
{
		public class AppDbContext : DbContext
		{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public List<Livro>? Livros { get; set; }
	}
}