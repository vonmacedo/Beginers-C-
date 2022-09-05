using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_37450_37458_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA = 0, valorB = 0, valorR = 0;
            Console.Write("Digite a base");
            valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura");
            valorB = int.Parse(Console.ReadLine());
            valorR = valorA * valorB;
            Console.Write("O resultado deu:" + valorR.ToString());
            Console.ReadKey();
        }
    }
}
