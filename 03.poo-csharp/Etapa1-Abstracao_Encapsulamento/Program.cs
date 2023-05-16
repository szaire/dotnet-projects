// Paradigma "Programação Orientada a Objetos"
// Antes de tudo: 
// O que é um paradigma? Um paradigma de programação é a maneira
// pela qual determinado algoritmo é construindo para realizar
// determinada atividade. 
// Um paradigma não é igual à uma linguagem de programação, é mais
// correto de se pensar que uma linguagem de programação pode aplicar
// um ou mais pardigmas.
// Existem diversos tipos de paradigmas, dentre eles a POO, porém, o
// C# pode aplicar também os seguintes:
// - Concorrente
// - Funcional
// - Genérico
// - Imperativo
// - Reflexão

// São 4 os pilares da POO:
// - Abstração
// - Encapsulamento
// - Herança
// - Polimorfismo
// - EXTRAS: Classes Abstratas e Interfaces

// Principais conceitos da POO:
// CLASSES e OBJETOS
// - Classes: São como "plantas" ou "moldes" para a criação de
// um objeto, ou seja, a representação das propriedades e ações
// que determinado objeto tem e pode executar.
// - Objetos: É a criação de um conjunto ordenado de propriedades
// e ações de uma Classe na memória.
// - O que tudo isso significa? A Classe é a base, o molde que irá
// determinar como determinado objeto é e como se comporta. O objeto
// é a aplicação concreta dessa classe em um conjunto de dados/instruções
// que podem ser utilizados no programa ou algoritmo.

// O que é abstração?
// Abstrair algo em programação significa trazer um conceito do mundo
// real para o mundo computacional. Dessa maneira, é possível criar
// uma classe Pessoa (localizada na pasta Models) e instanciar (criar)
// um objeto dessa classe para representarmos uma pessoa e seus dados
// em código. Porém, para isso, é indispensável que seja trabalhado
// *apenas* os dados necessários dessa classe (Pessoa) para o contexto
// adequado que ela se encontra.
// Exemplo: A informação/característica de uma Pessoa sobre o tamanho
// de quanto ela veste de roupa seria muito interessante para uma loja
// de roupas, entretanto, a mesma informação seria desnecessária caso
// o contexto fosse de uma instituição escolar, por exemplo. 

// O que é encapsulamento?
// O encapsulamento é um mecanismo que caracteriza se determinado campo, 
// propriedade ou método podem ser acessados fora da classe. Dessa maneira,
// o encapsulamento garante a proteção dessas informações e permite com
// que apenas o necessário seja exposto para fora da classe e as informações
// próprias à classe sejam ocultadas. Dessa forma, não se corre o risco de
// realizar qualquer operação indesejada com determinada informação de uma
// classe.
// Exemplo: Uma pessoa irá sacar dinheiro da conta. Ela não precisa saber
// como seu saldo será alterado quando houver a retirada do dinheiro no caixa
// eletrônico, ela apenas precisa sacar (remover uma determinada quantia).

// O que é herança?
// A herança é o mecanismo pelo qual um objeto pode ser reutilizado para a
// criação de objetos do mesmo tipo, porém, com características diferentes
// ou adicionais.
// Exemplo: Se cria uma classe Aluno e Professor para identificar dois 
// individuos distintos, porém, ambos são semelhantes à classe Pessoa. Desta
// forma, é possível estabelecer que Pessoa herda tanto Aluno quanto Professor.
// (Ver classes Aluno e Professor)
// NOTAS SOBRE HERANÇA EM POO: Herança é um conceito que aumenta a abstração
// e o entendimento e coesão do código, porém, atrelado a isso, aumenta também
// a complexidade. Dessa forma, quanto mais camadas de abstração, mais complexa
// e, consequentemmente, mais custoso e lento o código pode se tornar. Deve-se
// tomar ciência que adicionar camadas de herança deve ser feito apenas se for
// de extrema necessidade. (Ver classe Diretor)

using Etapa1.Models;
using System.Globalization;

internal class Program
{
	private static void Main(string[] args)
	{
		CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

		Console.Clear();

		// Instanciando um objeto da classe pessoa;
		Pessoa p1 = new Pessoa();
		p1.Nome = "José";
		p1.Sobrenome = "Alberto";
		p1.Idade = 35;

		p1.Apresentar();

		Console.WriteLine("====================================");

		ContaCorrente cc = new ContaCorrente(123, 1000);
		cc.ExibirSaldo();
		cc.Sacar(250);
		cc.ExibirSaldo();

		Console.WriteLine("====================================");

		Aluno a1 = new Aluno();
		a1.Nome = "Mário";
		a1.Sobrenome = "Figueiredo";
		a1.Idade = 21;
		a1.Nota = 8.5;

		a1.Apresentar();

		Professor prof1 = new Professor();
		prof1.Nome = "Rogério";
		prof1.Sobrenome = "Gonçalves";
		prof1.Idade = 42;
		prof1.Salario = 2000M;

		prof1.Apresentar();
	}
}