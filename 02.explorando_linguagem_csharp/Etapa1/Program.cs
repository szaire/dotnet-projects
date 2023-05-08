using Etapa1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Samuel", "Zaire");
        // Aqui se está utilizando o método "set" das propriedades
        // "Nome" e "Idade" ao evidenciar o operador de atribuição
        p1.Idade = 21;

        Pessoa p2 = new Pessoa(nome: "Pedro", sobrenome: "Quinhas");
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
    }
}