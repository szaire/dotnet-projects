using Etapa4.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		// Tuplas
		// É um conjunto de dados capaz de armazenar mais de um
		// tipo de dado diferente (int, string, decimal, double, etc.)
		// em uma estrutura leve
		(int Id, string Nome, string Sobrenome, short Idade, decimal Altura) tupla = (1, "Samuel", "Zaire", 21, 1.86M);

		// Outras maneiras de representar tuplas:
		// Desvantagens em relação à declaração anterior: Não é possível nomear os tipos
		ValueTuple<int, string, string, short, decimal> tupla2 = (1, "Samuel", "Zaire", 21, 1.86M); // ValueTuple é uma referência de Tupla
		var tupla3 = Tuple.Create(1, "Samuel", "Zaire", 21, 1.86M); // o tipo "var" é usado para fazer declarações implícitas de tipos de objetos 

		Console.WriteLine($"Id: {tupla.Id}");
		Console.WriteLine($"Nome: {tupla.Nome}");
		Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
		Console.WriteLine($"Idade: {tupla.Idade}");
		Console.WriteLine($"Altura: {tupla.Altura}");

		Console.WriteLine("\n");
		// Testando a classe FileValidation
		FileValidation fv = new FileValidation();
		var (success, fileLines, lineQuantity) = fv.ReadFile("Files/arquivoTexto.txt");

		// Descarte de informações
		// Utilização do operador "_" (underline) para descartar qualquer informação que
		// no momento não seja necessária no retorno de uma tupla. Exemplo: descarte da
		// variável "LineQuantity"
		var (success2, fileLines2, _) = fv.ReadFile("Files/arquivoTexto.txt");

		if (success)
		{
			Console.WriteLine("Arquivo lido com sucesso!");
			Console.WriteLine("Conteúdo:");
			foreach (var line in fileLines)
			{
				Console.WriteLine(line);
			}
			Console.WriteLine($"Quantidade de linhas: {lineQuantity}");
		}
		else
		{
			Console.WriteLine("Não foi possível ler o arquivo informado. Tente novamente...");
		}

		Console.WriteLine();
		// -x- Desconstrutor -x-
		Pessoa p1 = new Pessoa("Marcos", "Josefus");

		// Antes de desconstruir:
		Console.WriteLine($"Nome Classe Pessoa: {p1.Nome}");
		Console.WriteLine($"Sobrenome Classe Pessoa: {p1.Sobrenome}");
		
		// Desconstrução:
		(string nomeForaDaClasse, string sobrenomeForaDaClasse) = p1;

		// Após a desconstrução:
		Console.WriteLine("----------------------");
		Console.WriteLine($"Nome Classe Pessoa: {p1.Nome}");
		Console.WriteLine($"Sobrenome Classe Pessoa: {p1.Sobrenome}");
		
		Console.WriteLine($"Nome Fora da Classe Pessoa: {nomeForaDaClasse}");
		Console.WriteLine($"Sobrenome Fora da Classe Pessoa: {sobrenomeForaDaClasse}");

		// OBS: Um construtor não destrói uma classe, apenas atribui o valor
		// dos seus campos às variáveis de saída.

		Console.WriteLine("\n=================================\n");
		// If ternário - Um alternativo do if para reduzir a verbosidade do código
		// Exemplo: 
		int numero = 15;
		// Sintaxe:                                   condição lógica   true    false
		Console.WriteLine($"O número {numero} é: " + (numero % 2 == 0 ? "par" : "ímpar" + " (IF TERNÁRIO)"));

		// Pode ser entendido como:
		if (numero % 2 == 0)
		{
			Console.WriteLine($"O número {numero} é: par (IF COMUM)");
		}
		else
		{
			Console.WriteLine($"O número {numero} é: ímpar (IF COMUM)");
		}
	}
}