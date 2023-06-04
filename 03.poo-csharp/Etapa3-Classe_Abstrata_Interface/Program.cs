using Etapa3.Models;

// Conceitos adicionais da POO:
// Classes Abstratas e Interfaces (aumento do nível de abstração)

// O que é uma classe abstrata:
// Uma classe abstrata, assim como uma classe, é um molde (planta)
// para a construção de um objeto. Porém, o que diferencia uma
// classe abstrata de uma classe convencional é que a abstrata
// não será instanciada como um objeto, ou seja, sua implementação 
// é ausente ou incompleta. É possível apenas herdar propriedades e
// métodos e é possível, também, sobrecarregar métodos que forem
// indicados como abstratos. (Ver classe Conta)

// CLASSE SELADA (Sealed)
// Tem o objetivo de impedir que outras classes façam uma herança
// dela, nenhuma classe pode derivar dela, caracterizando-a como
// a instância final de uma cadeia de heranças, por exemplo.
// OBS: A mesma teoria e funcionamento se aplica também a métodos.

// CLASSE OBJECT
// É a classe mãe, em uma cadeia de heranças, de todas as classes
// declaradas no C#. Para visualizar isso, basta clicar na declaração
// abaixo:
//{
//	Object obj = new Object();
//}

// INTERFACE
// Interface é um contrato que é estabelecida em uma classe
// que irá implementá-la (para interfaces, usa-se o termo implementar
// e não herdar). Tem semelhanças com a classe abstrata, pois pode
// declarar métodos abstratos que serão definidos posteriormente.
// E assim como classes abstratas, uma interface não pode ser 
// instanciada.
// O QUE SIGNIFICA DIZER QUE A INTERFACE É UM CONTRATO?
// Um contrato é um acordo entre duas ou mais partes que
// concordam em seguir determinadas regras ou padrões estabelecidos.
// As interfaces podem ser entendidas como contratos pois elas
// estabelecem as regras (métodos) que uma classe que as implementa
// tem de seguir para ser considerada o que a interface abstrai ser.
// (Ver interface ICalculadora e classe Calculadora). 

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		int valor = 500;
		Conta c1 = new Corrente();
		Conta c2 = new Credito();

		Console.WriteLine("Exibir valor Conta corrente:");
		c1.Creditar(valor);
		c1.ExibirSaldo();

		Console.WriteLine();

		Console.WriteLine("Exibir valor Conta Crédito:");
		c2.Creditar(valor);
		c2.ExibirSaldo();
		Console.WriteLine();
	}
}						