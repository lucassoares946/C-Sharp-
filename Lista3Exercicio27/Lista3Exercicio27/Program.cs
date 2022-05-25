using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            double numcanal = 1, pessoas, cont4 = 0, cont5 = 0, cont7 = 0, cont12 = 0;
            while (numcanal != 0) {
                Console.WriteLine("Numero do canal:");
                numcanal = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de pessoas que estão assistindo: ");
                pessoas = double.Parse(Console.ReadLine());
                if(numcanal == 4)
                {
                    cont4++;
                }

                if (numcanal == 5)
                {
                    cont5++;
                }

                if (numcanal == 7)
                {
                    cont7++;
                }

                if (numcanal == 12)
                {
                    cont12++;
                }
                if (numcanal == 0)
                {
                    Console.WriteLine("Pontos de Audiência: \n" + cont4 + "\n" + cont5  + "\n" + cont7 + "\n" + cont12 );
                    Console.ReadKey();
                }
            }
            
            
        }
        
    }
    
}
