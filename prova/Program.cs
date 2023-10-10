using prova.questoes;
exercicios exercicios = new exercicios();
int opcao=0;
do
{
    try
    {
        ExibirMenu();
        Console.Write("Digite a opção escolhida: ");
        bool isnumeric = int.TryParse(Console.ReadLine(), out opcao);
        if (!isnumeric)
        {
            Console.WriteLine("Entrada de dado invalida! Digite um numero!");
        }
        else
        {
            menu(opcao);
        }
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Mensagem de erro: {ex.Message}");
    }
} while (opcao != 0);




void ExibirMenu()
{
    Console.WriteLine("===== Menu de Exercicios =====");
    Console.WriteLine("\nDigite 1 para o Exercicio 1: ");
    Console.WriteLine("Digite 2 para o Exercicio 2: ");
    Console.WriteLine("Digite 3 para o Exercicio 3: ");
    Console.WriteLine("Digite 4 para o Exercicio 4: ");
    Console.WriteLine("Digite 0 para sair: ");
}

void menu(int opcao)
{

    switch (opcao)
    {
        case 1:
            exercicios.exercicio01();
            Console.WriteLine("Aperte uma tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case 2:
            exercicios.exercicio02();
            Console.WriteLine("Aperte uma tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case 3:
            exercicios.exercicio03();
            Console.WriteLine("Aperte uma tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case 4:
            exercicios.exercicio04();
            Console.WriteLine("Aperte uma tecla para voltar ao menu");
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("Digite uma opção valida");
            break;
    }
}