using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25CSHarpCorreto
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, hf, dhora;
            Console.WriteLine("Calcule sua gratificação de natal \nDigite o numero de horas extras: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas que você faltou: ");
            hf = double.Parse(Console.ReadLine());
            dhora = (h - (2 / 3 * hf));
            if
                (dhora > 2400) { Console.WriteLine("Gratificação de R$500,00"); }
            else if
                (dhora > 1800 && dhora < 2400) { Console.WriteLine("Gratificação de R$400,00"); }
            else if
                (dhora > 1200 && dhora < 1800) { Console.WriteLine("Gratificação de R$300,00"); }
            else if
               (dhora > 600 && dhora < 1200) { Console.WriteLine("Gratificação de R$200,00"); }
            else if
               (dhora < 600) { Console.WriteLine("Gratificação de R$100,00"); }
            Console.ReadKey();
        }
    }
}
