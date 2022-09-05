using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_34750_34758_Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorA = 0, valorB = 0;
            Console.Write("Digite o valor de celsius:");
            valorA = double.Parse(Console.ReadLine());
            valorB = 9.0 / 5 * valorA + 32;
            Console.Write("O resultado deu:" + valorB.ToString());
            Console.ReadKey();
        }
    }
}
