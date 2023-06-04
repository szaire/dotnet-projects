using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa2.Entities;
using Microsoft.EntityFrameworkCore;

// O Contexto é uma classe que centraliza todas as informações
// desejadas em um banco de dados.

namespace Etapa2.Context
{
	// O banco de dados a ser criado irá se basear nessa classe chamada
	// AgendaContext, a qual será responsável por possuir uma tabela de Contatos
	// Para evidenciar que essa classe será um context, ela deverá herdar
	// da classe abstrata "DbContext" do pacote Entity Framework Core
	public class AgendaContext : DbContext
	{
		// Para que essa context possa se conectar com o banco de dados, seu construtor
		// deverá ser declarado da seguinte maneira:
		public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }
		// As opções de conexão com o banco será dada pelo parâmetro "options" que será
		// repassado ao construtor da classe DbContext

		// Criando a tabela de Contatos:
		public DbSet<Contato> Contatos { get; set; }
	}
}