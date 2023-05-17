using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Models
{
    // Para se declarar uma classe abstrata, basta
    // sinalizar a classe com a keyword "abstract"
    public abstract class Conta
    {
        // Declaração de um campo "protected".
        // Por que protected e não private? Pois, se fosse
        // declarado como private, seria bloqueado o acesso
        // à variável fora da classe, mesmo que fossem classes
        // filhas. Dessa forma, é utilizado o protected, para
        // que toda classe filha possa visualizar a variável
        // e, assim, acessar seu valor e alterá-lo como bem entender.
        // OBS: o protected também implica que toda classe membra
        // *do mesmo namespace* possa visualizar, também, a
        // declaração (seja campo, propriedade, método, etc.).  
		protected decimal _saldo;

        // Declaramos um método como abstrato para que assim seja
        // possível herdá-lo em classes filhas e, dessa maneira,
        // as classes filhas possam decidir como implementá-lo
        // de acordo com sua especificações.
        // (Ver classes Corrente e Crédito)
		public abstract void Creditar(decimal valor);

        // Método comum declarado apenas para exibir o saldo da conta.
        // Toda classe que herda Conta conseguirá utilizá-la.
        public void ExibirSaldo()
        {
			Console.WriteLine($"Seu saldo é de {_saldo}");
		}
	}
}