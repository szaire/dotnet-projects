// Exceções e Coleções

// O que são exceções (exceptions)? São situações ou fenômenos que ocorrem
// durante a execução de um programa que são indevidos, ou seja, inesperados.
// O Tratamento de Exceções é a técnica utilizada pela POO para ditar ao código
// de um programa qual a melhor maneira de ter que lidar com uma exceção em
// determinado momento.

using Etapa3.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		// [1] Exemplo de crash:
		//string[] linhasCrash = File.ReadAllLines("Files/arquivo_Leitura.txt");
		//Console.WriteLine("Não continua o código após uma exceção lançada...");

		// Essa chamada de método retornará uma exceção, pois o programa não conseguiu
		// achar o nome/diretório do arquivo informado. Dessa forma, o programa para pois
		// Não sabe como prosseguir com o tratamento da exceção. 

		// Try - Catch
		// Para solucionar o problema do "vazamento de execessões" do código, é necessário
		// validar as execessões e tratá-las propriamente. Para isso, se utiliza os
		// operadores try & catch, da seguinte maneira:
		try
		{
			// Tudo o que estiver dentro do escopo do "try" executará normalmente até que
			// uma exceção seja "capturada", para capturá-la, se utiliza o operador "catch"
			// que fica abaixo do "try".

			string[] linhas = File.ReadAllLines("Files/arquivo_Leitura.txt");

			foreach (string linha in linhas)
			{
				Console.WriteLine(linha);
			}
		}
		catch (Exception ex)
		{
			// O bloco dentro do "catch" será executado após uma exceção ser lançada dentro
			// do bloco "try". Dentro desse escopo, podemos utilizar o objeto "ex" do tipo
			// "Exception" como um objeto comum do C#, o qual possui diversos métodos e
			// propriedades que podem ser utilizadas, como por exemplo, a propriedade
			// Message que retorna a explicação do erro que causou a exceção.

			Console.WriteLine($"Exceção genérica capturada! {ex.Message}");
		}
		// Quando se realiza o tratamento de erros, ao invés do programa parar definitivamente,
		// ele continua para além dos blocos try-catch, executando o programa normalmente. Nisso
		// se evidencia o objetivo de um try-catch, tratar o máximo as exceções para que o
		// programa não sofra de um "crash", ou seja, que ele não feche repentinamente [1].

		Console.WriteLine("\nO programa continua a partir daqui... Para outros casos teste de Exceções...\n");

		// Exceções genéricas e específicas
		try
		{
			// Exceção de Diretório
			string[] linhas1 = File.ReadAllLines("Files/d/arquivoLeitura.txt");
			// Exceção de Nome de Arquivo
			string[] linhas2 = File.ReadAllLines("Files/arquivoLeitura_1234.txt");
			// Exceção Genérica
			string[] linhas3 = File.ReadAllLines("");
		}
		// Exceção específica para erro ao tentar achar arquivo.
		catch (FileNotFoundException fileEx)
		{
			//Acesso a propriedade "FileName" da Exceção
			Console.WriteLine($"\nErro ao tentar acessar arquivo. Arquivo com nome \"{fileEx.FileName}\" não encontrado." +
			$"\n{fileEx.Message}");
		}
		// Exceção específica para erro ao tentar acessar diretório inexistente.
		catch (DirectoryNotFoundException dirEx)
		{
			Console.WriteLine($"\nErro ao tentar acessar arquivo. Diretório não encontrado." +
			$"\n{dirEx.Message}");
		}
		// Exceção genérica que não considera qualquer especificidade.
		// PS: Quanto mais genérica for a exceção, mais abaixo da cadeia de "catch" ela
		// deve ficar, pois uma vez capturada ela inibe a execução dos outros "catch", o que
		// pode ocasionar incongruência
		catch (Exception ex)
		{
			Console.WriteLine($"Exceção genérica capturada! {ex.Message}");
		}
		// Finally: O bloco finally irá executar independentemente de ocorrer erros ou não.
		// Ele é útil em situações em que se ocorrer erros ou não alguma operação deve acontecer
		// para evitar outros problemas. 
		finally
		{
			Console.WriteLine($"\nO programa terminou sua execução.");
		}
		// Exemplo de caso de uso do finally: Conexão com Banco de Dados
		// - O Banco de Dados irá abrir uma conexão para alguém que está requisitando
		// - Irá manter essa conexão aberta durante o seu uso
		// - Irá realizar processos e gerar resultados (seja operações satisfatórias ou erros)
		// - Irá fechar a conexão com o usuário para *evitar o consumo de memória*.
		// Ou seja, o finally não irá resolver coisa alguma, mas realizar operações
		// *obrigatórias* após a execução do try-catch

		// Operador throw - O operador throw é o responsável por realizar os
		// "lançamentos" de exceções. Caso determinada parte do código criado
		// pelo programador possa gerar exceções, ele será utilizado para lançar
		// a exceção que será tratada por um try-catch em algum momento do código
		new Excecao().Metodo1();

		Console.Clear(); // ------------------Coleções-----------------------------

		Console.WriteLine("\n\n");
		// Fila (FIFO - First In, First Out)
		Queue<int> fila = new Queue<int>();

		fila.Enqueue(1);
		fila.Enqueue(3);
		fila.Enqueue(5);
		fila.Enqueue(7);
		fila.Enqueue(8);

		foreach (int item in fila)
		{
			Console.WriteLine(item);
		}

		Console.WriteLine($"Removendo o primeiro elemento da fila (FIFO): {fila.Dequeue()}") ;
		
		foreach (int item in fila)
		{
			Console.WriteLine(item);
		}

		int novoElemento = 777;
		Console.WriteLine($"Acrescentando {novoElemento} à fila");
		fila.Enqueue(novoElemento);

		foreach (int item in fila)
		{
			Console.WriteLine(item);
		}

		Console.WriteLine("\n\n");
		// Pilha (LIFO - Last In, First Out)
		Stack<int> pilha = new Stack<int>();

		pilha.Push(2);
		pilha.Push(4);
		pilha.Push(6);
		pilha.Push(8);
		foreach (int item in pilha) Console.WriteLine(item);

		Console.WriteLine($"Removendo o primeiro elemento da pilha: {pilha.Pop()}") ;
		foreach (int item in pilha) Console.WriteLine(item);

		Console.WriteLine($"Acrescentando {novoElemento} à fila");
		pilha.Push(novoElemento);
		foreach (int item in pilha) Console.WriteLine(item);


		Console.WriteLine("\n\n");
		// Dicionário
		Dictionary<int, string> clientes = new Dictionary<int, string>();
		clientes.Add(1, "Samuel");
		clientes.Add(2, "Pedro");
		clientes.Add(3, "Quinhas");
		clientes.Add(4, "Batavo");
		clientes.Add(5, "Santos");
		
		//foreach (KeyValuePair<int, string> item in clientes) -> funciona do mesmo jeito
		foreach (var item in clientes) Console.WriteLine($"ID: {item.Key} | Nome: {item.Value}");

		Console.WriteLine();
		// Adicionando um novo elemento:
		clientes.Add(6, "Fonseca");
		foreach (var item in clientes) Console.WriteLine($"ID: {item.Key} | Nome: {item.Value}");

		Console.WriteLine();
		// Removendo um elemento:
		clientes.Remove(2);
		foreach (var item in clientes) Console.WriteLine($"ID: {item.Key} | Nome: {item.Value}");

		// Alterando valores dentro do dicionário
		clientes[1] = "Zelda";

		Console.WriteLine();
		// Verificando se há valores existentes:
		int chaveAlvo = 2;
		if (!clientes.ContainsKey(chaveAlvo))
		{
			Console.WriteLine($"É possível adicionar a chave {chaveAlvo}.");
			clientes.Add(chaveAlvo, "Link");
		}
		else
		{
			Console.WriteLine("Chave já existente, sem permissão para adição.");
		}

		Console.WriteLine();
		foreach (var item in clientes) Console.WriteLine($"ID: {item.Key} | Nome: {item.Value}");

		// Notas finais:
		/*
		Tratamento de exceções devem ser utilizadas com cautela: Quando se vai acessar
		um arquivo, fazer download, acessar uma pasta, etc...
		Para operações mais simples, não há necessidade de utilizar exceções: checagens
		e lógicas booleanas.
		*/
	}
}