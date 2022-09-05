using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA = 0, valorB = 0, valorC = 0, valorD = 0;
            Console.Write("Digite a base");
            valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura");
            valorB = int.Parse(Console.ReadLine());
            valorC = valorA * valorB;
            valorD = valorC / 2;
            Console.Write("O resultado é:" + valorD.ToString());
            Console.ReadKey();


        }
    }
}
