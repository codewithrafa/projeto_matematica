using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{
    internal class code_3
    {
        //Juros Simples
        // J = C * I * T
        // J -> Juros C -> Capital I -> taxa T -> tempo

        static double CalculoJuros(double c, double i, double t)
        {
            return c * (i/100) * t;
        }

        public void Juros()
        {
            Console.WriteLine("Informe o valor do capital (R$) investido:");
            double c = Convert.ToDouble(Console.ReadLine()); 
            
            Console.WriteLine("Informe o valor da taxa (%) aplicado:");
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a duração, em meses, do tempo aplicado:");
            double t = Convert.ToDouble(Console.ReadLine());

            double juros = CalculoJuros(c, i, t);
            Console.WriteLine($"O valor do juros é {juros}R$");
            Console.WriteLine($"Capital final: {c + juros}");
        }
    }
}