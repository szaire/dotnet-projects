using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Models
{
	public class Credito : Conta
	{
        // Campo exclusivo (privado/private) à classe Credito, 
        // não pode ser Acessado por qualquer outra classe 
        // irmã ou externa.
		private decimal _taxa = 0.02M;

		public override void Creditar(decimal valor)
		{
            // A implementação na conta crédito é um
            // pouco mais complexa, onde ocorre uma
            // diminuição de valor quando se entra
            // dinheiro em conta.
			_saldo += valor - (valor * _taxa);
		}
	}
}