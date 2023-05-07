using Etapa1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();

        // Aqui se está utilizando o método "set" das propriedades
        // "Nome" e "Idade" ao evidenciar o operador de atribuição
        p1.Nome = "Samuel Zaire";
        p1.Idade = 21;

        p1.Apresentar();
    }
}