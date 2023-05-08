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
            Console.WriteLine($"Lista de alunos matriculados no curso de {Nome}:");
			foreach (Pessoa aluno in Alunos)
			{
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}