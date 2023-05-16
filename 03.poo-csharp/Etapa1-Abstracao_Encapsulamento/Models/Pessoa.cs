using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Models
{
	public class Pessoa
	{
		// características de um objeto:
		public string? Nome { get; set; }
		public string? Sobrenome { get; set; }
		public int Idade { get; set; }
		
		// ações de um objeto:
		public void Apresentar() { Console.WriteLine($"Oi, meu nome é {Nome} {Sobrenome}"); }
	}
}