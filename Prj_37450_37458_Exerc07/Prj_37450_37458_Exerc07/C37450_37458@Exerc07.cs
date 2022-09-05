using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA = 0, valorB = 0, valorC = 0, valorD = 0;
            Console.Write("Digite o 1° valor:");
            valorA = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2° valor:");
            valorB = double.Parse(Console.ReadLine());
            valorC = valorA * valorB;
            valorD = Math.Sqrt(valorC);
            Console.Write("O resultado é" + valorD.ToString());
            Console.ReadKey();

        }
    }
}
