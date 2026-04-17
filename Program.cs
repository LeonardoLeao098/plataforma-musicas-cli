// Screen Sound

Dictionary<string, List<double>> bandas = new Dictionary<string, List<double>>();

void Menu ()
{
    ExibirTitulo("Boas vindas ao Screem Sound!");
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
            case 2: MostrarBandas();
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

void ExibirTitulo(string titulo)
{
    int letrasQuantidade = titulo.Length;
    string igualdades = string.Empty.PadLeft(letrasQuantidade, '=');
    Console.WriteLine(igualdades);
    Console.WriteLine(titulo);
    Console.WriteLine(igualdades + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registrar nova banda, manda a ver!");
    Console.WriteLine("\nDigite o nome da banda: ");
    string bandaNome = Console.ReadLine()!;
    bandas.Add(bandaNome, new List<double>());
    Console.WriteLine($"A banda {bandaNome} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    Menu();
}

void MostrarBandas()
{
    if (bandas.Count == 0)
    {
        Console.Clear();
        Console.WriteLine("Não temos bandas registradas no momento!");
        Thread.Sleep(4000);
        Console.Clear();
        Menu();
    }
    else
    {
    Console.Clear();
    ExibirTitulo("Essas são as bandas que temos no momento!");
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"{banda}");
    }

    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu!");
    Console.ReadKey();
    Console.Clear();
    Menu();
    }
}

Menu();

