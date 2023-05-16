using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Models
{
	// Como aluno é uma pessoa, é possível dizer que ele
	// herda da classe Pessoa, a qual permite que ele
	// possua um nome, sobrenome, idade e tenha a capacidade
	// de se apresentar.
	// Ou seja, tudo que Pessoa possui (campos, propriedades, 
	// métodos, etc.), Aluno também irá possuir. 
	public class Aluno : Pessoa
	{
		// A classe alunos não precisa declarar as propriedades:
		// nome, sobrenome e idad enovamente pois ela herda eles
		// diretamente da classe Pessoa.

		// Propriedades contidas apenas em Aluno:
		public double Nota { get; set; }
	}
}