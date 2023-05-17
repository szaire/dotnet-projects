using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Models
{
	// Selando a classe Professor com a keyword "sealed"
	// -> Indica que a herança acaba a partir de Professor,
	// ou seja, nada pode derivar dela.
	public sealed class Professor : Pessoa
	{
		// A mesma coisa ocorre com a classe Professor:
		public Professor(string nome) : base(nome) { }

		// Assim como Aluno, Professor também irá herdar
		// de Pessoa as propriedades Nome, Sobrenome e
		// Idade.
		public decimal Salario { get; set; }

		// Polimorfismo (sobrecarga):
		public sealed override void Apresentar()
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