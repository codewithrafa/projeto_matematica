using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_matematica
{
    internal class code
    {
        //OPERAÇÔES SIMPLES
        //SOMA, SUBTRAÇÃO, MULTIPLICAÇÃO, DIVISÃO, POTÊNCIA E RAÍZ QUADRADA
        public double n1;
        public double n2;
        public double Somar()
        {
            return n1 + n2;
        }
        public double Subtracao()
        {
            return n1 - n2;
        }
        public double Mult()
        {
            return n1 * n2;
        }
        public double Div()
        {
            return n1 / n2;
        }
        public double Potencia()
        {
            return Math.Pow(n1, n2);
        }
        public double Raiz()
        {
            return Math.Sqrt(Math.Pow(n1,n2));
        }

        public void OperacoesSimples()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Digite o segundo número: ");
            double.TryParse(Console.ReadLine(), out n2);
            Console.WriteLine("------------------------------");

            Console.WriteLine($"A soma dos números (n1,n2) é: {Somar()}"); 
            Console.WriteLine($"A subtração dos números (n1,n2) é: {Subtracao()}"); 
            Console.WriteLine($"A multiplicação dos números (n1,n2) é: {Mult()}");
            Console.WriteLine($"A potência dos números (n1,n2) é: {Potencia()}"); 
            Console.WriteLine($"A raíz quadrada da potência (n1,n2) é: {Raiz()}");
        }

        internal void Teorema()
        {
            throw new NotImplementedException();
        }
    }
}
