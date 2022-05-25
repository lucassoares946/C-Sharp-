using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a = 15, b = 15;
            Console.WriteLine("Digite um nº inteiro:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro nº inteiro:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b) { Console.WriteLine("IAIÁ:"); }
            else { Console.WriteLine("IOIÔ:"); }
            Console.ReadKey();
        }
    }
}
