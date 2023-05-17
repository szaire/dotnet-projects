using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa3.Models
{
	public class Corrente : Conta
	{
        // Assim como para herança em classes convencionais
        // que usam o "virtual", para classes abstratas será
        // utilizado o operador "override" para que a classe
        // herdada possa implementar o método abstrato da
        // maneira que desejar.
		public override void Creditar(decimal valor)
		{
            // A implementação na conta corrente é simples,
            // apenas agrega o valor dado a saldo.
			_saldo += valor;
		}
	}
}