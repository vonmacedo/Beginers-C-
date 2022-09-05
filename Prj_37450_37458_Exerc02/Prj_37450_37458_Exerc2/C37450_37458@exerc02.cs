using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA = 0, valorB = 0, valorC = 0;
            Console.Write("Digite a primeira aresta");
            valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda aresta");
            valorB = int.Parse(Console.ReadLine());
            valorC = valorA * valorB;
            Console.Write("O resultado deu:" + valorC.ToString());
            Console.ReadKey();



        }
    }
}
