using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{
    internal class code_8
    {
   
        public static double CalcFator(double f)
        {
            double fatorial = 1;
            for (int i = 1; i <= f; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }

        public void Fatorial()
        {
            char cont = 's';
            while (cont == 's')
            {

                Console.WriteLine("Olá. Aqui iremos calcular o fatorial de qualquer número.\n");

                Console.WriteLine("Digite o número para o cálculo do fatorial: \n");
                double f = int.Parse(Console.ReadLine());

                if (f == 0)
                {
                    Console.WriteLine("O fatorial de 0 é 1");
                }
                else
                {
                    Console.WriteLine($"O fatorial do número {f} é {CalcFator(f)}");
                }

                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
