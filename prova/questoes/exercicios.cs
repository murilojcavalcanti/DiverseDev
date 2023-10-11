using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prova.questoes
{
    public class exercicios
    {

        //Questão1
        internal void exercicio01()
        {
            Console.WriteLine("Escreva um programa que faça a leitura de 5 valores Inteiros do usuário. Em seguida, " +
                "o programa deve exibir no console a informação de quantos dos valores digitados são pares, quantos dos " +
                "valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos.Cada uma das " +
                "informações deve ser escrita em uma linha diferente.");
            int quantidadeNumeros = 0;
            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadeNegativos = 0;
            int quantidadePositivos = 0;
            try
            {
                for (; quantidadeNumeros < 5; quantidadeNumeros++)
                {
                    Console.WriteLine($"Digite o {quantidadeNumeros + 1}º valor");
                    bool isnumeric = int.TryParse(Console.ReadLine(), out int numero);
                    if (!isnumeric)
                    {
                        Console.WriteLine("Digite apenas numeros inteiros");
                        break;
                    }
                    else
                    {

                        if (numero % 2 == 0)
                        {
                            quantidadePares++;
                        }
                        else
                        {
                            quantidadeImpares++;
                        }

                        if (numero > 0)
                        {
                            quantidadePositivos++;
                        }
                        else
                        {
                            quantidadeNegativos++;
                        }
                    }
                }

                    if (quantidadeNumeros == 5)
                    {
                        Console.WriteLine($"Números positivos: {quantidadePositivos}" +
                            $"\nNúmeros negativos: {quantidadeNegativos}" +
                            $"\nNúmeros pares: {quantidadePares}" +
                            $"\nNúmeros impares: {quantidadeImpares}");
                    }
            }
            catch (Exception ex)
            {
                throw new Exception($"Mensagem de erro:{ex.Message}");
            }
        }

        //Questão2
        internal void exercicio02()
        {
            Console.WriteLine("Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois " +
                "números inteiros, N1 por N2, que devem ser lidos do teclado.É importante observar que a máquina que irá " +
                "executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração.Ou seja, " +
                "você não poderá usar os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.");
            int n1 = 0;
            int n2 = 0;
            int multiplicacao = 0;
            int divisao = 0;
            int sinal = 1;
            bool isnumericN1 = true;
            bool isnumericN2 = true;
            try
            {
                Console.WriteLine("Digite o primeiro valor");
                isnumericN1 = int.TryParse(Console.ReadLine(), out n1);
                if (!isnumericN1)
                {
                    Console.WriteLine("Entrada invalida");
                }
                else
                {
                    Console.WriteLine("Digite o segundo valor");
                    isnumericN2 = int.TryParse(Console.ReadLine(), out n2);
                }


                if (isnumericN1 && isnumericN2)
                {

                    if (n1 < 0)
                    {
                        n1 = -n1;
                        sinal = -sinal;
                    }

                    if (n2 < 0)
                    {
                        n2 = -n2;
                        sinal = -sinal;
                    }

                    for (int i = 0; i < n1; i++)
                    {
                        multiplicacao += n2;
                    }

                    while (n1 >= n2)
                    {
                        n1 -= n2;
                        divisao++;
                    }

                    if (sinal < 0)
                    {
                        multiplicacao = -multiplicacao;
                    }

                    Console.WriteLine($"Multiplicação: {multiplicacao}");
                    Console.WriteLine($"Divisão Inteira: {divisao}");

                }
                else
                {
                    Console.WriteLine("Entrada de dados inválida!");

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Mensagem de erro: {ex.Message}");
            }
        }

        //Questão3
        internal void exercicio03()
        {
            Console.WriteLine("Escreva um programa que recebe como entrada uma frase do usuário. Como" +
                " saída o programa deve exibir no console as seguintes informações: quantas palavras são" +
                " maiúsculas, quantas palavras são minúsculas, quantas palavras iniciam com letra maiúscula," +
                " quantas palavras iniciam com letra minúscula e a quantidade de palavras.");
            int maiuscula = 0;
            int minuscula = 0;
            int inicioMaiuscula = 0;
            int inicioMinuscula = 0;
            bool isMaiuscula = true;
            bool isMinuscula = true;

            try
            {

                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();
                if (string.IsNullOrEmpty(frase))
                {
                    Console.WriteLine("Frase não pode ser vazia");
                }
                else
                {
                    frase.Replace(",", "");
                    string[] palavras = frase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var palavra in palavras)
                    {
                        if (palavra.Length > 0)
                        {
                            char primeiraLetra = palavra[0];
                            if (char.IsUpper(primeiraLetra))
                            {
                                foreach (char c in palavra)
                                {
                                    isMaiuscula = char.IsUpper(c);
                                }
                                if (isMaiuscula)
                                {
                                    maiuscula++;
                                }
                                else
                                {
                                    if (!isMaiuscula)
                                    {
                                        inicioMaiuscula++;
                                    }
                                }

                            }
                            else
                            {

                                foreach (char c in palavra)
                                {
                                    isMinuscula = char.IsLower(c);
                                }

                                if (isMinuscula)
                                {
                                    minuscula++;
                                }
                                else
                                {
                                    inicioMinuscula++;
                                }




                            }
                        }
                    }
                    int totalPalavras = palavras.Length;
                    Console.WriteLine($"Total palavras:{totalPalavras}");
                    Console.WriteLine($"Total palavras Maiusculas:{maiuscula}");
                    Console.WriteLine($"Total palavra minusculas:{minuscula}");
                    Console.WriteLine($"Total palavra com inicio minusculas:{inicioMinuscula}");
                    Console.WriteLine($"Total palavra com inicio maiusculas:{inicioMaiuscula}");

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Mensagem de erro: {ex.Message}");
            }

        }

        
    }
}
