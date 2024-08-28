// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Scrren Sound";

void ExibirMensagemDeBoasVindas()
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
    Console.WriteLine("\nDigite [1] registrar uma banda");
    Console.WriteLine("Digite [2] mostrar todas banda");
    Console.WriteLine("Digite [3] avaliar banda banda");
    Console.WriteLine("Digite [4] média de avaliações de banda");
    Console.WriteLine("Digite [-1] sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica) {
        case 1: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();