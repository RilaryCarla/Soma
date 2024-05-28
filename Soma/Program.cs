using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação que deseja fazer [S-subtração, A-adição, D-divisão, M-multiplicação]");
            string op = Console.ReadLine();

            ope(n1, n2, op);

            Console.ReadKey();

        }
        static void ope(double n1, double n2, string op)
        {
            switch (op)
            {
                case "S":
                    double resultado = n1 - n2;
                    Console.WriteLine("o resltado será "+resultado);
                break;

                case "A":
                    resultado = n1 + n2;
                    Console.WriteLine("o resultado será "+resultado);
                break;

                case "D":
                    resultado = n1 / n2;
                    Console.WriteLine("o resultado será "+resultado);
                break;

                case "M":
                    resultado = n1 * n2;
                    Console.WriteLine("o resultado será " + resultado);
                break;
                default: Console.WriteLine("Resultado inválido");
                break;
            }
        }
    }
}
