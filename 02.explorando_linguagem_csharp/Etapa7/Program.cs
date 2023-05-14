using Etapa7.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		// Como a alocação de memória funciona?
		// 1. ENTENDO AS MEMÓRIAS STACK E HEAP -----------------------------------
		// ao executar o seguinte código...
		int a = 10;
		int b = 5;
		Pessoa p = new Pessoa("", "");
		// Nós iremos organizar a memória da seguinte maneira: [1]

		// A Memória Stack irá se organizar como uma pilha e à medida
		// que as variáveis forem sendo declaradas, ela será preenchida.
		// Como "a" e "b" são variáveis primitivas simples do tipo
		// inteiro, não há a necessidade de alocá-las na memória Heap,
		// a qual é reservada para tipos complexos (Objetos, Interfaces,
		// Estruturas, etc.). "p" é uma variável da classe Pessoa que possui
		// diversos dados, como Nome, Sobrenome, Idade e Altura. Dessa forma
		// para organizar sua estrutura adequadamente, p é representado como
		// uma referência (uma ligação/ponteiro) para o verdadeiro objeto Pessoa 
		// que será armazenado na memória Heap, a qual armazenará as propriedades 
		// desse objeto.

		// 2. LIMPEZA DE MEMÓRIA DO C# -------------------------------------------
		// O C# possui uma forma inteligente de limpar a memória Stack. Quando o
		// programa finaliza sua execução, não há mais a necessidade de manter as
		// variáveis declaradas na PARTE 1. Portanto, o C# irá retirá-las da memória
		// após a execução do programa. Para a memória Heap, é um pouco mais complexo.

		// Quando se trata da memória Heap, o C# irá usar um mecanismo chamado de
		// "Garbage Collector" (Coletor de Lixo) que será acionado sempre que
		// houver dados remanescentes que estavam ligados à referência
		// de um objeto na memória Heap. Dessa forma, o GC checará se a referência delas
		// ainda existe, caso não exista, eliminará essas variáveis da memória.

		// Todo esse processo ocorre por trás do algoritmo sem qualquer necessidade do
		// programador se preocupar com isso.

		// 3. TIPOS DE VALOR E REFERÊNCIA
		// Tipo de Valor: Também conhecidos como "Tipos Primitivos" são valores
		// mais simples armazenados na memória Stack por meio de variáveis que
		// possuam identificadores/nomes distintos para o mesmo escopo de
		// declaração.
		// Tipo de Referência: Também serão armazenados na memória principal, porém,
		// terão um grau maior de complexidade se comparados com o "Tipo de Valor"
		// tradicional, pois, são referências para objetos alocados na memória
		// Heap.
		// OBSERVAÇÃO:
		//		- A memória Stack é estática pois, uma vez que determinada variável
		//		  é organizada na pilha, sua posição permanece no mesmo local da
		//		  memória até o fim da execução do código.
		//		- A memória Heap é dinâmica pois uma vez que determinado objeto é
		//		  declarado, não importa a posição e organização de seus métodos,
		//		  campos, propriedades, etc., pois esses sempre estarão ligados
		// 		  à variável de referência que está declarada na memória Stack.

		// 4. ATRIBUIÇÕES DE TIPO
		// Toda variável que é declarada com um tipo complexo é uma referência para
		// esse tipo. O que isso quer dizer? Significa que todo objeto possui uma
		// referência que aponta para ele na memória Stack. Entretanto, por ser uma
		// referência, é possível que exista mais de uma referência para o mesmo objeto.
		// Exemplo:
		// Instanciando um objeto de referência "p1"
		Pessoa p1 = new Pessoa("Pedro", "Quinhas");

		// Declarando uma referência "p2" a um objeto não-existente do tipo "Pessoa"
		Pessoa p2;

		p2 = p1;
		// Aqui houve a cópia do objeto pessoa da referência p1 para outra referência?
		// Não, basicamente, o que ocorre aqui é a atribuição de que a referência
		// p2 agora aponta para o mesmo objeto na memória Heap que p1 aponta.

		// Dessa forma:
		Console.WriteLine($"Nome: {p1.Nome}, Sobrenome: {p1.Sobrenome}");
		Console.WriteLine($"Nome: {p2.Nome}, Sobrenome: {p2.Sobrenome}");

		// Se p2 aponta para o mesmo objeto que p1 aponta, logo se alterarmos as
		// propriedades da referência p2...
		p2.Nome = "Batavo";
		Console.WriteLine($"Nome: {p1.Nome}, Sobrenome: {p1.Sobrenome}");
		Console.WriteLine($"Nome: {p2.Nome}, Sobrenome: {p2.Sobrenome}");
		// ...Também alteramos as propriedades da referência p1.

		// Desse modo, entende-se que o objeto Pessoa instanciado na linha 67 existe
		// na memória Heap e obteve como referência uma variável p1 do tipo Pessoa
		// Porém, possuiu também uma nova referência a partir da atribuição da linha
		// 72, a qual dclarou que a variável p2 do tipo Pessoa também aponta para
		// o mesmo objeto que p1 aponta.
		// Se evidenciarmos os valores de p1 e p2, obteremos:
		Console.WriteLine(p1); // Endereço de memória para o objeto pessoa instanciado
		Console.WriteLine(p2); // o mesmo endereço de memória para o objeto Pessoa instanciado

		// 5. ATRIBUIÇÕES DE VALOR
		// Atribuições de valor são muito mais simples que atribuições de tipo pois
		// trabalham apenas com variáveis primitivas, ou seja, que possuem valores
		// armazenados na memória Stack, os quais não não referenciados de qualquer
		// maneira. Dessa forma, a seguinte atribuição ocorrerá da seguinte maneira...

		int A = 10;
		int B = A;
		Console.WriteLine("Valor de A: " + A);
		Console.WriteLine("Valor de B: " + B);
		
		// Valor de B é igual ao de A pois, no momento da atribuição, é feita uma cópia
		// do valor numérico inteiro guardado em A para a variável B. Dessa forma...

		int A1 = 10;
		int B1 = A;
		B1 = 60;
		Console.WriteLine("Valor de A: " + A1);
		Console.WriteLine("Valor de B: " + B1);

		// O valor de B difere de A e A continua sendo o mesmo valor (10), pois não há
		// atribuição de referência apontando para determinado valor na memória, e sim
		// uma cópia de valor de uma variável à outra.

	}
}