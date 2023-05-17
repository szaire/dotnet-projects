using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Models
{
	public class Pessoa
	{
		// Construtor por herança:
		// Quando há a necessidade de declarar um construtor em uma
		// relação de herança entre classes, as classes filhas terão de
		// obedecer essa declaração incrementando os construtores que
		// farão referência à classe Pai. (Ver classe Aluno)
		public Pessoa(string nome)
		{
			Nome = nome;
		}

		// características de um objeto:
		public string? Nome { get; set; }
		public string? Sobrenome { get; set; }
		public int Idade { get; set; }
		
		// ações de um objeto:
		public virtual void Apresentar() { Console.WriteLine($"Oi, meu nome é {Nome} {Sobrenome}"); }
		// a keyword "virtual" sinaliza e permite que um
		// método possa ser sobrescrito (polimorfismo)
		// por uma classe derivada (filha)
		// virtual não pode ser declarado junto à:
		// static, abstract, private ou override
	}
}