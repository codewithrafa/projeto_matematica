using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{
    internal class code_5
    {
        //ÁREA DO TRIÂNGULO
        public double b;
        public double h;

        public double CalculoTri()
        {
            return (b * h) / 2;
        }
        public void AreaTri()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Digite a base do triângulo:");
                double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("------------------------------");

                Console.WriteLine("Digite a altura do triângulo:");
                double.TryParse(Console.ReadLine(), out h);
                Console.WriteLine("------------------------------");

                Console.Clear();
                Console.WriteLine($"A área do triângulo é: {CalculoTri()}");

                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }

        }
    }
}
