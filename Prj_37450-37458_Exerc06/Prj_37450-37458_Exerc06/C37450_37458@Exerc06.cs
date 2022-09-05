using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA = 0, valorB = 0, valorC = 0, valorD = 0, valorE = 0, valorF = 0;
            Console.Write("Digite o primeiro valor");
            valorA = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo valor");
            valorB = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor");
            valorC = double.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor");
            valorD = double.Parse(Console.ReadLine());
            valorE = valorA + valorB + valorC + valorD;
            valorF = valorE / 4;
            Console.Write("O resultado deu" + valorF.ToString());
            Console.ReadKey();
        }

    }
}
