// Screen Sound

List<string> bandas = new List<string>();

void Menu ()
{
    string welcome = "\nBoas vindas ao Screen Sound!";
    Console.WriteLine(welcome);

    Console.WriteLine("\n[1] para registrar uma banda: ");
    Console.WriteLine("[2] para listas as bandas: ");
    Console.WriteLine("[3] para avaliar uma banda: ");
    Console.WriteLine("[4] para exibir a média de uma banda: ");
    Console.WriteLine("[5] para sair: ");

    Console.Write("Opção: ");
    string opcao = Console.ReadLine()!;

    if (int.TryParse(opcao, out int escolha))
    {
        switch (escolha)
        {
            case 1: RegistrarBanda();
                break;
            case 2: Console.WriteLine ("Você quer listar as bandas, beleza!");
                break;
            case 3: Console.WriteLine ("Você quer avaliar uma banda, manda a ver!");
                break;
            case 4: Console.WriteLine ("Você quer exibir a média de uma banda, se liga aí!");
                break;
            case 5: Console.WriteLine ("Você quer sair do programa, até a próxima!");
                break;
            default: Console.WriteLine("Opção inválida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Digite apenas números!");
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine ("Você quer registrar uma banda, vamos lá!");
    Console.WriteLine("Digite o nome da banda: ");
    string bandaNome = Console.ReadLine()!;
    bandas.Add(bandaNome);
    Console.WriteLine($"A banda {bandaNome} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
}

Menu();

