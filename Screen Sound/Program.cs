
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
██╗░░██╗██████╗░  ░██████╗░█████╗░███████╗████████╗░██╗░░░░░░░██╗░█████╗░██████╗░███████╗
██║░░██║██╔══██╗  ██╔════╝██╔══██╗██╔════╝╚══██╔══╝░██║░░██╗░░██║██╔══██╗██╔══██╗██╔════╝
███████║██████╦╝  ╚█████╗░██║░░██║█████╗░░░░░██║░░░░╚██╗████╗██╔╝███████║██████╔╝█████╗░░
██╔══██║██╔══██╗  ░╚═══██╗██║░░██║██╔══╝░░░░░██║░░░░░████╔═████║░██╔══██║██╔══██╗██╔══╝░░
██║░░██║██████╦╝  ██████╔╝╚█████╔╝██║░░░░░░░░██║░░░░░╚██╔╝░╚██╔╝░██║░░██║██║░░██║███████╗
╚═╝░░╚═╝╚═════╝░  ╚═════╝░░╚════╝░╚═╝░░░░░░░░╚═╝░░░░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝");    
}
ExibirLogo();

string boasVindas = "\nBem vindo(a) ao Screen Sound";
Console.WriteLine(boasVindas);

void ExibirOpcoesDoMenu()
{
    
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar uma banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");

    int.TryParse(Console.ReadLine(), out int entrada_opcao);

    switch (entrada_opcao)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            ExibirListaDasBandas();
            break;

        case 3:
            AvaliarUmaBanda();
            break;

        case 4:
            MediaDasBandas();
            break;

        case 0:
            Console.WriteLine("Bye Bye");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");

    string entradaNomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(entradaNomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {entradaNomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();

}

void ExibirListaDasBandas()
{
    Console.Clear();
    
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"a banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nPressione qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }

}

void MediaDasBandas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloDaOpcao("Média da banda");
    Console.WriteLine("Digite o nome para saber a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda{nomeDaBanda} é {notasDaBanda.Average()}");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"a banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nPressione qualquer tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '-');
    Console.WriteLine("|" + asteriscos + "|");
    Console.WriteLine("|"+ titulo + "|");
    Console.WriteLine("|" + asteriscos + "|" + "\n");

}

ExibirOpcoesDoMenu();