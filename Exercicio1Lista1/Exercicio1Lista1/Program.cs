using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, dias;
            Console.WriteLine("Quantas vezes o seu coração já bateu de acordo com sua idade? \nDigite sua idade: ");
            idade = double.Parse(Console.ReadLine());
            dias = idade * 365.25 * 86400;
            Console.WriteLine("Seu coração já bateu: \n" + dias);
            Console.ReadKey();











            Console.ReadKey();
            

            
           
        }
    }
}
