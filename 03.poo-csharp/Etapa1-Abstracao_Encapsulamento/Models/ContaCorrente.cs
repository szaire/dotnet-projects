using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Models
{
	public class ContaCorrente
	{

		// Declaração com MODIFICADOR DE ACESSO "Private"
		// O modificador de acesso "Private" inibe (protege) o acesso
		// ao meu campo saldo por algo externo ao objeto da classe
		// "ContaCorrente" 
		private decimal _saldo;

		public ContaCorrente(int numeroConta, decimal saldoInicial)
		{
			NumeroConta = numeroConta;
			_saldo = saldoInicial;
		}

		// Declaração com MODIFICADOR DE ACESSO "Public"
		// O modificador de acesso "Public" permite que o acesso
		// à minha propriedade NumeroConta seja visível por algo
		// externo ao objeto da classe "ContaCorrente", dessa forma
		// este pode ser acessado.
		public int NumeroConta { get; set; }

		public void Sacar(decimal value)
		{
			if (value <= _saldo)
			{
				_saldo -= value;
				Console.WriteLine($"Seu saque foi de {value:C}");
				Console.WriteLine("Saque realizado com sucesso!");
			}
			else
			{
				Console.WriteLine("O valor solicitado excede o saldo em conta!");
			}
		}

		// A única maneira de acessar o campo privado _saldo é criando um
		// método público que o acesse dentro do escopo da própria classe,
		// para que assim não haja qualquer proibição de acesso pelo
		// modificador private.
		public void ExibirSaldo()
		{
			Console.WriteLine($"O seu saldo atual é {_saldo:C}");
		}
	}
}