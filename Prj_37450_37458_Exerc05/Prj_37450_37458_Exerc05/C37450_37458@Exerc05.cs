using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA = 0, valorB = 0, valorC = 0;
            Console.Write("Digite o diâmetro");
            valorA = double.Parse(Console.ReadLine());
            valorB = valorA / 2;
            valorC =  4 * Math.PI *  Math.Pow(valorB, 3) / 3;
            Console.Write("O resultado deu" + valorC.ToString());
            Console.ReadKey();



        }
    }
}
