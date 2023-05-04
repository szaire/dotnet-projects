int opcao;
bool exibirMenu = true;

while (exibirMenu)
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
            exibirMenu = false;
            // Environment.Exit(0); // o Enviroment.Exit(0) finaliza completamente o código,
            // caso exista mais códigos além do loop while, eles não serão executados
            break;

        default:
            Console.WriteLine("Opção inválida, acesse o menu dentre os números 0 a 4.");
            break;
    }
    Console.WriteLine();
}

Console.WriteLine("mais código além do loop while");