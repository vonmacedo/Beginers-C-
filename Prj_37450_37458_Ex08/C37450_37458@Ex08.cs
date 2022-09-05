using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorA = 0, valorB = 0, valorC = 0;
            Console.Write("Digite a milha:");
            valorA = double.Parse(Console.ReadLine());
            valorB = valorA * 1852;
            valorC = valorA / 1000;
            Console.Write("O resultado deu:"+ valorC.ToString());
            Console.ReadKey();


        }
    }
}
