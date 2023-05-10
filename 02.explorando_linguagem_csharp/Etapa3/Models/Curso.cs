using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Models
{
	public class Curso
	{
		public Curso(string nome)
		{
			Nome = nome;
			Alunos = new List<Pessoa>();
		}

		public string Nome { get; set; }
		public List<Pessoa> Alunos { get; set; }

		// Métodos:
		// Métodos são funções (ações) que uma classe pode exercer.
		// Nesse caso, a classe em questão pode adicionar novos alunos.

		// Essa é a forma de como se declarar um método:
		// Somente a partir do tipo de retorno que se considera a assinatura do método
		//	   Retorna: void (ou seja, não retorna)
		//     	 	Identificação: Nome do método (Deve ser imperativo)
		//                  	   Parâmetro: O que a função recebe de informação
		public void AdicionarAluno(Pessoa aluno)
		{
			Alunos.Add(aluno);
		}

		public int QuantidadeMatricula()
		{
			return Alunos.Count;
		}

		public bool RemoverAluno(Pessoa aluno)
		{
			return Alunos.Remove(aluno);
		}

		public void ListarAlunos()
		{
			Console.WriteLine("Debugando a lista Alunos com concatenação e interpolação:");
			for (int i = 0; i < Alunos.Count; i++)
			{
				// Concatenação de String:
				// Juntar várias strings por meio do operador de concatenação (+)
				// para se ter uma string maior "juntada" (concatenada)
				string textConcatenacao = "Concatenação: Nº " + (i+1) + " - " + Alunos[i].NomeCompleto;
				Console.WriteLine(textConcatenacao);

                // Interpolação de String:
                // Uma maneria mais fácil e coesa de representar uma string.
				// Não ocorre concatenação, mas, uma inserção de texto dentro de uma string.
                string textInterpolacao = $"Interpolaçõa: Nº {i+1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(textInterpolacao);
			}

            Console.WriteLine($"\nLista de alunos matriculados no curso de {Nome}:");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
		}
	}
}