using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Diferenças entre Campos e Propriedades:
/*
In C#, a field is a variable (that can be of any type) that is defined inside a class.
It can be used to define the characteristics of an object or a class. On the other hand,
a property is a member of the class that provides an abstraction to set (write) and get
(read) the value of a private field.
*/
// Fonte: educative.io

namespace Etapa1.Models
{
    // Modificadores de Acesso:
    // Public: Qualquer um pode acessar o membro dentro da classe.
    // Private: O private só permite acessar dentro da própria clase.
    //      --> Qual a importância disso? Para garantir o encapsulamento. Ou seja,
    //			para proteger as variáveis campo de qualquer acesso externo (estranho à
	//			classe) e, assim, poderem realizar validações nelas antes delas serem
	//			alteradas ou acessadas.
    public class Pessoa
    {
        // Construtor:
        // Método especial que pode fornecer valores iniciais à uma classe
        // Geralemnte vem no começo da declaração da classe
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Campos
        // Campos são membros de qualquer tipo que contém as
        // informações de uma classe e a eles estão associadas 
        // as propriedades, as quais são utilizadas para tratar
        // seus getters e setters
        private string _nome = "~";
        private string _sobrenome = "~";
        private int _idade;

        // Propriedades
        // Um membro de uma classe que é capaz de determinar
        // os atributos de um objeto da vida real.
        // Comparação: Seria o encapsulamento de getters e setters do JAVA

        // O que são o "get" e o "set"?
        // -> São Métodos contidos dentro das propriedades que determinam
        // o tratamento da chamada de valores ou a atribuição de valores
        public string Nome
        {
            // Body Expression -> Melhor utilizado se for para comandos de uma linha
            get => _nome.ToUpper();   
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome inválido! Escreva um nome diferente de nulo.");
                }
                _nome = value;
            }
        }

		public string Sobrenome
		{
            get => _sobrenome.ToUpper();

			set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Sobrenome inválido! Escreva um nome diferente de nulo.");
                }
                _sobrenome = value;
            }
        }

        public int Idade 
        {
            // Casual Implementation:
            get 
            {
                return _idade;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade inválida! Digite uma idade maior ou igual a zero.");
                }

                _idade = value;
            }
        }

        // Porpriedade apenas para leitura:
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        // Método
        public void Apresentar()
        {
            // Aqui se está utilizando o método "get" das propriedades
            // "Nome" e "Idade"
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
