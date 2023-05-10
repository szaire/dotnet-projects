using Etapa1.Models;
using System.Globalization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		Pessoa p1 = new Pessoa("Samuel", "Zaire");
		// Aqui se está utilizando o método "set" das propriedades
		// "Nome" e "Idade" ao evidenciar o operador de atribuição
		p1.Idade = 21;

		Pessoa p2 = new Pessoa(nome: "Pedro", sobrenome: "Quinhas");
		p2.Nome = "Alejandro";
		p2.Idade = 22;

		Pessoa p3 = new Pessoa(sobrenome: "Dos Santos", nome: "Batavo");
		p3.Idade = 20;

		Curso cursoGraduacao = new Curso("Ciências da Computação");

		cursoGraduacao.Nome = "Ciências da Computação";
		cursoGraduacao.AdicionarAluno(p1);
		cursoGraduacao.AdicionarAluno(p2);
		cursoGraduacao.AdicionarAluno(p3);
		cursoGraduacao.ListarAlunos();

		// p1.Apresentar();

		Console.WriteLine();
		// Casting implictio de string
		int a = 10;
		string b = "20";
		string c = a + b;
		string d = b + a;
		Console.WriteLine($"{c}; {d}\n");

		Console.WriteLine();
		// Formatando valores monetários
		decimal valorMonetario = 1582.40M;
		decimal valorFracionado = 40.2398749872452345M;
		Console.WriteLine($"valor monatério = {valorMonetario:C}");         // Culture
		Console.WriteLine($"valor fracionado = {valorFracionado:F4}");      // Fraction
		Console.WriteLine($"valor fracionado = {valorFracionado:.###}");    // Fraction

		Console.WriteLine();
		// Alterando a localização do programa
        // Determinando que a cultura do programa é pt-BR
		CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
		Console.WriteLine($"valor monatério = {valorMonetario:C}");         // Culture
		Console.WriteLine($"valor fracionado = {valorFracionado:F4}");      // Fraction
		Console.WriteLine($"valor fracionado = {valorFracionado:.###}");    // Fraction

		Console.WriteLine();
		// Determinando uma cultura específica:
		Console.WriteLine($"valor monatério = {valorMonetario:C}");
		Console.WriteLine("valor fracionado (específico) = " + valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));

		Console.WriteLine();
        // Formatação Personalizada
		Console.WriteLine($"valor monatério (formatando) = {valorMonetario:C8}");
		Console.WriteLine($"valor monatério (ToString)   = {valorMonetario.ToString("C8")}");

        Console.WriteLine();
		// Representando Porcentagem
		double porcentagem = .826348;
		Console.WriteLine(porcentagem.ToString("P"));
		// Representando digitos
		int numero = 123456;
		Console.WriteLine(numero.ToString("##-##-##"));

		Console.WriteLine();
		// Formatando o DateTime
		DateTime data = DateTime.Now;
		Console.WriteLine(data.ToString("dd.MM.yyyy HH:mm"));
		// Formatando a data
		Console.WriteLine(data.ToShortDateString());
		Console.WriteLine(data.ToShortTimeString());
		// Convertendo string para DateTime
		string text = "17/04/2023 17:45";
		data = DateTime.Parse(text);
		Console.WriteLine(data);
		// Formatando com tryParse
		string dataString = "2023-13-32 18:00";

		// Esse método tentará converter a data inválida informada
		// para uma data válida. O TryParse servirá muito mais para
		// validar o valor da data gerada.
		bool isDateValid = DateTime.TryParseExact(
			dataString,
			"yyyy-MM-dd HH:mm",
			CultureInfo.InvariantCulture,
			DateTimeStyles.None,
			out DateTime newDate
		);

		if (isDateValid)
		{
			Console.WriteLine($"Conversão realizada com sucesso! Data gerada: {newDate}");
		}
		else 
		{
			Console.WriteLine($"{dataString} não é uma data válida...");
		}

		// Caso os dados de entrada não sejam datas válidas, o tryParse
		// Retornará um valor padrão
		// Caso sejam, Retornará a nova data de acordo com os argumentos informados
		Console.WriteLine(newDate);
	}
}