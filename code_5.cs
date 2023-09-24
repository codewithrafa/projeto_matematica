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
            Console.WriteLine("Digite a base do triângulo:");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Digite a altura do triângulo:");
            double.TryParse(Console.ReadLine(), out h);
            Console.WriteLine("------------------------------");

            Console.WriteLine($"A área do triângulo é: {CalculoTri()}");

        }
    }
}
