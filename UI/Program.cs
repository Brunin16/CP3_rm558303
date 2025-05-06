using Controller;

AlunoController ac = new AlunoController();
FuncionarioController fc = new FuncionarioController();
ProdutosController pc = new ProdutosController();

while (true)
{
    Console.WriteLine("Digite seu RM e senha\n");
    Console.Write("RM: ");
    int rm = int.Parse(Console.ReadLine());

    Console.Write("Senha: ");
    string senha = Console.ReadLine();

    if (ac.ValidarAluno(rm, senha))
    {
        Console.WriteLine("Login bem-sucedido!");
        ac.ValidarSegurancaSenha(senha);

        bool continuar = true;
        while (continuar) 
        {
            Console.WriteLine("\nSeja bem-vindo, Fulano");
            Console.WriteLine("1 - Listar funcionários");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    fc.listarFuncionarios();
                    break;
                case 2:
                    pc.listarProdutos();
                    break;
                case 3:
                    Console.WriteLine("Saindo para tela de login...\n");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Senha ou RM incorretos.\n");
    }
}
