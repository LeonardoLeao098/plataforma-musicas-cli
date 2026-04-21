// Screen Sound
using System.Linq;
using System.Reflection.Metadata;

Dictionary<string, List<double>> bandas = new Dictionary<string, List<double>>();

void Menu ()
{
    int escolha = 0;
    do
    {
        Console.Clear();
        ExibirTitulo("Boas vindas ao Screem Sound!");
        Console.WriteLine("\n[1] para registrar uma banda: ");
        Console.WriteLine("[2] para listas as bandas: ");
        Console.WriteLine("[3] para avaliar uma banda: ");
        Console.WriteLine("[4] para exibir a média de uma banda: ");
        Console.WriteLine("[5] para sair: ");

        Console.Write("Opção: ");
        string opcao = Console.ReadLine()!;

        if (int.TryParse(opcao, out escolha))
        {
            switch (escolha)
            {
                case 1: RegistrarBanda();
                    break;
                case 2: MostrarBandas();
                    break;
                case 3: AvaliarBanda();
                    break;
                case 4: ExibirMedia();
                    break;
                case 5: Console.WriteLine ("Você quer sair do programa, até a próxima!");
                    break;
                default: Console.WriteLine("Opção inválida, tente de novo!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Digite apenas números!");
        }
    }
    while (escolha != 5);
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

    if(!bandas.ContainsKey(bandaNome))
    {
        bandas.Add(bandaNome, new List<double>());
        Console.WriteLine($"A banda {bandaNome} foi registrada com sucesso!");
    }
    else
    {
        Console.WriteLine("Essa banda já foi registrada!");
    }
    Thread.Sleep(2000);
}

void MostrarBandas()
{
    if (bandas.Count == 0)
    {
        Console.Clear();
        Console.WriteLine("Não temos bandas registradas no momento!");
    }
    else
    {
    Console.Clear();
    ExibirTitulo("Essas são as bandas que temos no momento!");
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"{banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    }
}

void AvaliarBanda()
{
    // identifica banda a ser avaliada

    Console.Clear();
    ExibirTitulo("Avaliação de banda!");
    Console.Write("Boa! Digite a banda que você quer avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    // verifica se a banda existe > atribuir nota

    if (bandas.ContainsKey(nomeDaBanda))
    {
        double nota;
        bool valido = false;

        do
        {
            Console.Write("Banda encontrada! Digite a nota que deseja dar: ");
            string entrada = Console.ReadLine()!;
            valido = double.TryParse(entrada, out nota);

            if(!valido)
            {
                Console.WriteLine("Valor inválido, tente novamente.");
            }
            
        } while(!valido);

        bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"Nota adicionada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(3000);
    } 
    else  // caso não exista, retorna ao menu
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
    }

    
}

void ExibirMedia()
{
    // identifica banda a ser avaliada

    Console.Clear();
    ExibirTitulo("Visualização das médias!");
    Console.Write("Digite a banda que você quer ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    // verifica se a banda existe > procura as notas

    if (bandas.ContainsKey(nomeDaBanda))
    {
        List<double> notas = bandas[nomeDaBanda];

        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"A média da banda {nomeDaBanda} é {media}");
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} ainda não tem avaliações!");
        }

    }
    else // caso não exista, retorna ao menu
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
    }
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
}

Menu();

