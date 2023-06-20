using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etapa3.Models;
using Microsoft.EntityFrameworkCore;

namespace Etapa3.Contexts
{
    public class AgendaContext : DbContext
    {
		public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}