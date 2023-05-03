int opcao;

while (true)
{
    Console.WriteLine("Menu de operações de usuário");
    Console.WriteLine("1 - Cadastrar usuário");
    Console.WriteLine("2 - Buscar usuário");
    Console.WriteLine("3 - Deletar usuário");
    Console.WriteLine("4 - encerrar");

    Console.Write("Digite uma das opções disponíveis acima: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Usuário cadastrado");
            break;

        case 2:
            Console.WriteLine("Usuário encontrado!");
            break;

        case 3:
            Console.WriteLine("Usuário deletado!");
            break;

        case 4:
            Console.WriteLine("Programa encerrado.");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida, acesse o menu dentre os números 0 a 4.");
            break;
    }
    Console.WriteLine();
}