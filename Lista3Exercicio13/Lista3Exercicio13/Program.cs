using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, peso, i, contkg = 0,j;
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite sua idade ");
                idade = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu peso ");
                peso = double.Parse(Console.ReadLine());
                idade = idade =+ idade * i;
                if(peso > 90) { contkg++; }
                
                Console.WriteLine("Pessoas com mais de 90 Kg" + contkg);
                
                Console.WriteLine("Média das idades " + idade / 7);

            }
            
                   
                


            }
            
        }
    }

