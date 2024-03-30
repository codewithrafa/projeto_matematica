using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{

    internal class text
    {
        /* CÓDIGO DE EXECUÇÃO DO PROJETO MATEMÁTICA */
        // Criado por Rafael Carvalho em 23/09/2023

        static void Main()
        {
            bool continuar = true;
            while (continuar)
            {
                int escolha;
                Console.WriteLine("Escolha uma área da matemática:\n 1 - Operacoes simples\n 2 - " +
                    "Teorema de pitagoras\n 3 - Cálculo de Juros\n " +
                    "4 - Números primos\n 5 - Área do Triângulo \n 6 - Trigonometria");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            code executar = new code();
                            executar.OperacoesSimples();
                            break;
                        case 2:
                            code_2 executar2 = new code_2();
                            executar2.Teorema();
                            break;
                        case 3:
                            code_3 executar3 = new code_3();
                            executar3.Juros();
                            break;
                        case 4:
                            code_4 executar4 = new code_4();
                            executar4.Primos();
                            break;
                        case 5:
                            code_5 executar5 = new code_5();
                            executar5.AreaTri();
                            break;
                        case 6:
                            code_6 executar6 = new code_6();
                            executar6.Trigonometria();
                            break;
                        default:
                            Console.WriteLine("Opção inválida.Por favor, insira um número válido.");
                            break;
                    }
                    Console.WriteLine("Deseja selecionar outra área da matemática? (s/n)");
                    string resposta = Console.ReadLine().ToLower();
                    continuar = (resposta == "s");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, insira um número válido.");
                }
            }
        }
    }
}