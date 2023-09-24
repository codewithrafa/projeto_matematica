using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{
    internal class code_4
    {
        //NÚMEROS PRIMOS

        public static bool numPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void Primos()
        {
            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numPrimo(numero))
            {
                Console.WriteLine("O número é primo.");
            }
            else
            {
                Console.WriteLine("O número não é primo.");
            }
        }
    }
}
