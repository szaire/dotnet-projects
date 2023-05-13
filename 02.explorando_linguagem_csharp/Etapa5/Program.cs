// Serialização e Deserialização:
// Serializar -> converter objetos em um fluxo de bytes para armazenamento ou transmissão
// Explicação:
// Um objeto que for criado no seu programa, será entendido e interpretado apenas pelo
// seu programa. Porém, há ocasiões em que será necessário tornar esse objeto entendível
// para outros locais que não sejam apenas o programa em si. Para que isos seja posśivel,
// deve ocorrer um processo chamado de "serialização", ou seja, transformar esse objeto
// em um arquivo, armazená-lo num banco de dados ou, até mesmo, que ele seja lido na
// memória do computador.

// Exemplo de aplicação de serialização prática;
// Algoritmo de Compactação de Arquivos baseado na Árvore de Ruffman, onde um objeto é
// criado e escrito (bit a bit, ou seja, em 0 e 1) em um arquivo (conjunto) de bytes que
// serão interpretados por outros programas/algoritmos.

// Ferramentas para Serialização:
// Principal ferramenta: Arquivos com extensão .JSON.
// Por quê?
// Pois esse tipo de arquivo é capaz de armazenar qualquer tipos de dados de maneira
// organizada e que seja facilmente interpretado por qualquer linguagem de programação,
// possibilitando, assim, a integração entre as plataformas

using Etapa5.Models;
using Newtonsoft.Json;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		// serializando uma coleção de dados em JSON
		List<Produto> listaProdutos = new List<Produto>();

		Produto p1 = new Produto(1, "Manteiga de Amendoim", 25.00M, DateTime.Now);
		Produto p2 = new Produto(2, "Molho de Tomate", 17.00M, DateTime.Now);
		Produto p3 = new Produto(3, "Abacaxi", 6.00M, DateTime.Now);
		Produto p4 = new Produto(4, "Yorgut Natural", 9.00M, DateTime.Now);

		// A formatação do DateTime muda conforme a ferramenta que está sendo utilizada
		// Para o C# é de uma maneira
		// Para o JSON é de outra
		Console.WriteLine(DateTime.Now + "\n");

		listaProdutos.Add(p1);
		listaProdutos.Add(p2);
		listaProdutos.Add(p3);
		listaProdutos.Add(p4);

		string serial_lista = JsonConvert.SerializeObject(listaProdutos, Formatting.Indented);
		Console.WriteLine(serial_lista);

		File.WriteAllText($"Files/lista_produtos.json", serial_lista);

		//deserializando uma coleção de dados em JSON
		Console.WriteLine("==================================================");

		// pegando o texto do arquivo JSON
		string fileText = File.ReadAllText("Files/json_teste.json");

		// desirializando o texto e guardando ele em uma Lista
		List<ProdutoTI> listaProdutosTI = JsonConvert.DeserializeObject<List<ProdutoTI>>(fileText);

		foreach (var item in listaProdutosTI)
		{
			Console.WriteLine($"ID: {item.Id}, Nome: {item.Name}, Preço: {item.Price}, Data de Venda: {item.SaleDate.ToString("dd/MM/yyyy HH:mm")}");
		}
	}
}