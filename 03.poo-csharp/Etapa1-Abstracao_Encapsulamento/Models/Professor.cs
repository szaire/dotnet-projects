using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Models
{
	public class Professor : Pessoa
	{
		// Assim como Aluno, Professor também irá herdar
		// de Pessoa as propriedades Nome, Sobrenome e
		// Idade.
		public decimal Salario { get; set; }

		// Polimorfismo (sobrecarga):
		public override void Apresentar()
		{
			Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade: {Idade}, Salário: {Salario}");
		}

		// Polimorfismo em tempo de compilação:
		public int SomarMentalmente(int a, int b)
		{
			return a + b;
		}

		public int SomarMentalmente(int a, int b, int c)
		{
			return a + b;
		}
	}
}