// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Scrren Sound";

void ExibirLogo()
{
    Console.WriteLine(@"
╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
┃╰━━┳━━┳━┳━━┳━━┳━╮╱┃╰━━┳━━┳╮╭┳━╮╭━╯┃
╰━━╮┃╭━┫╭┫┃━┫┃━┫╭╮╮╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
┃╰━╯┃╰━┫┃┃┃━┫┃━┫┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
╰━━━┻━━┻╯╰━━┻━━┻╯╰╯╰━━━┻━━┻━━┻╯╰┻━━╯
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite [1] registrar uma banda");
    Console.WriteLine("Digite [2] mostrar todas banda");
    Console.WriteLine("Digite [3] avaliar banda banda");
    Console.WriteLine("Digite [4] média de avaliações de banda");
    Console.WriteLine("Digite [-1] sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica) {
        case 1: RegistrarBanda();
            break;
        case 2: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Fim");
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda desejada: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();