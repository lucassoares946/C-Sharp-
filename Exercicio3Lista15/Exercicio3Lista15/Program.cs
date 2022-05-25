using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Lista15
{
    class Program
    {
        static void Main(string[] args)

        {
            double i, num,cont = 0;
            
            
                for(i = 0; i < 10; i++) { 
                Console.WriteLine("Digite um número");
                num = double.Parse(Console.ReadLine());
                if(num >= 30 && num <= 90) { cont++; }
                }
            Console.WriteLine("Quantidade de números entre 30 e 90: " + cont);

            Console.ReadKey();
            
            

        }
    }
}
