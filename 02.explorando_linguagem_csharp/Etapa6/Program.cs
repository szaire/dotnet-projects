using Etapa6.Models;
using Newtonsoft.Json;

internal class Program
{
	private static void Main(string[] args)
	{
		// Valores nulos
		// Os valores nuloes (nullable types, ou null) são valores na programação
		// que representam a ausência de determinado dado, como por exemplo:

		// O operador que evidencia que determinada variável pode receber um tipo
		// nulo é "?", o qual deve ser verificado para evitar o lançamento de
		// exceções.
		bool? desejaReceberEmail = null;

		// Quando se trabalho com tipos nulos, é necessário verificar se a variável
		// possui um valor nulo guardada em si.
		if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
		{
			Console.WriteLine("O usuário deseja receber e-mails!");
		}
		else
		{
			Console.WriteLine("O usuário não deseja receber e-mails!");
		}

		Console.Clear();
		// Tratamento de valores nulos em JSON:
		string jsonContent = File.ReadAllText("Files/material_escritorio.json");
		List<Produto> listaProdutos = JsonConvert.DeserializeObject<List<Produto>>(jsonContent);

		foreach (var p in listaProdutos)
		{
			Console.WriteLine(
				$"ID {p.Id}\n " +
				$"\tNome: {p.Nome}\n" +
				$"\tPreço: {p.Preco}\n" +
				$"\tQuantidade: {p.Quantidade}\n" +
				$"\tData de Venda: {p.DataVenda}\n" +
				$"\t{(p.Desconto.HasValue ? $"Desconto de: {p.Desconto}%" : "")}"
				);
			// Na parte de Desconto eu utilizo um operador ternário que me evidenciará que o desconto
			// pode ter um valor nulo. Caso o valor dele diferente de nulo, eu concateno com uma string
			// literal que descreverá esse valor de desconto. Caso contraŕio, eu concateno com uma string
			// vazia, sem qualquer informação.
		}

		Console.WriteLine();
		// Tipos Anônimos
		// (Não podem ter seus valores alterados)
		// Tipos anônimos são variáveis que inferem o seu tipo no momento que são declaradas. Exemplo:
		var objeto = new { Nome = "Samuel", Sobrenome = "Zaire", Idade = 21 };
		Console.WriteLine($"Nome: {objeto.Nome}");
		Console.WriteLine($"Sobrenome: {objeto.Sobrenome}");
		Console.WriteLine($"Idade: {objeto.Idade} anos\n");
		// As propriedades de um tipo anônimo não podem ser alteradas, apenas acessadas, ou seja, os
		// tipos anônimos possuem apenas o método "GET"

		var listaAnom = listaProdutos.Select(e => new { e.Nome, e.Preco });

		Console.WriteLine("Print Lista Anônima:");
		foreach (var p in listaAnom)
		{
			Console.WriteLine($"Nome: {p.Nome}, Preço: {p.Preco}");
		}

		Console.WriteLine();
		// Tipos Dinâmicos
		// (São semelhantes a objetos literais em JavaScript)
		// Assim como os tipos anônimos, os tipos dinâmicos também irão inferir o seu tipo no momento da
		// declaração, entretanto, diferentemente dos anônimos, os dinâmicos podem ser alterados para qualquer
		// outro tipo. Exemplo:

		dynamic dinamico1 = true;
		Console.WriteLine($"Valor do tipo diâmico 1: {dinamico1}");

		dinamico1 = "Pedro Quinhas";
		Console.WriteLine($"Valor do tipo diâmico 1: {dinamico1}");

		dinamico1 = 1234.349;
		Console.WriteLine($"Valor do tipo diâmico 1: {dinamico1}");

		// É necessário estar atento ao usar o tipo dinâmico pois este pode representar qualquer outro tipo de
		// variável, portanto, com desatenção podem vir a ocorrerem exceções imprevistas.

		Console.WriteLine();
		// Classes Genéricas
		// São classes que abstraem qualquer tipo na criação de um objeto
		// Exemplo: List<>

		// Declarando o Array Genérico:
		ArrayGenerico<int> arr = new ArrayGenerico<int>();
		arr.Adicionar(10);
		arr.Adicionar(11);
		arr.Adicionar(55);
		arr.Adicionar(14);

		for (int i = 0; i < arr.Tamanho; i++)
		{
			Console.Write(arr[i] + " ");
		}

		Console.WriteLine();
		// Declarando um arr genérico de object, a classe mais abstrata do C#:
		ArrayGenerico<object> arrObj = new ArrayGenerico<object>();
		arrObj.Adicionar("string");
		arrObj.Adicionar('A');
		arrObj.Adicionar(10);
		arrObj.Adicionar(30.65M);
		arrObj.Adicionar(.44444.ToString("F3"));

		for (int i = 0; i < arrObj.Tamanho; i++)
		{
			Console.Write(arrObj[i] + " ");
		}

		Console.WriteLine("\n");
		// Métodos de Extensão
		// É possível declarar métodos que extendem, ou seja, ampliam o comportamento de
		// determinados objetos ou tipos no c#. Como por exemplo, a declaração de um
		// método de verficação de números pares ou ímpares:
		int numero = 24;
									  		   // O próprio valor do número está sendo usado
									  		   // para verificar se a varíavel é par ou ímpar
		Console.WriteLine($"O número {numero} é {(numero.ehPar() ? "par" : "ímpar")}");
	}
}