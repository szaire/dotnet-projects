using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa2.Models;
using Microsoft.EntityFrameworkCore;

// O Contexto será a representação do banco de dados no projeto. Ele é quem será
// responsável para ser utilizado pela Migration para realizar a integração entre
// EntityFramework e Banco de Dados e gerenciar as tabelas, elementos, dados
// e etc.

// É uma classe que acessa o banco de dados e realiza a conexão com o banco por
// meio do parâmetro "options", que representa justamente a connection string
// determinada								

namespace Etapa2.Contexts
{
	public class AgendaContext : DbContext
	{
		public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

		public DbSet<Contato> Contatos { get; set; }
	}
}