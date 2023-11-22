using System;
using System.Collections.Generic;



Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("The Beatles", new List<int> { 10, 10, 9 });
bandasRegistradas.Add("Queen", new List<int>());
    



void ExibirMensagem()
{

    string msg = "Bem vindo ";
    Console.WriteLine(msg);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Voce escolheu uma opção errada");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registrando Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");

    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulo("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}
void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{   
    Console.Clear();
    ExibirTitulo("Avaliar Banda");
    Console.Write("Digite o nome da banda que você deseja avaliar: ");
    string banda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(banda))
    {  
        Console.Write($"Qual nota que a banda {banda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[banda].Add(nota);

    } else
    {
        Console.WriteLine($"\nA banda {banda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey()!;
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

ExibirMensagem();
ExibirOpcoesDoMenu();

