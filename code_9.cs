using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{
    internal class code_9
    {
    
        public static double Porcen(double n, double p)
        {
            return (n * p) / 100;

        }
        public void Porcentagem()
        {
            char cont = 's';
            while (cont == 's')
            {

                Console.WriteLine("Digite um número para o cálculo da porcentagem:\n");
                double n = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a porcentagem que deseja calcular do número: {n}\n");
                double p = double.Parse(Console.ReadLine());

                Console.WriteLine($"{p}% de {n} é {Porcen(n, p)}\n");

                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();

            }
        }
    }
}
