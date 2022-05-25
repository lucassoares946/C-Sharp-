using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, i, idade1 = 0, cont = 0;

            for (i = 0; i < 1000; i++) 
            {
                Console.WriteLine("Digite sua idade: ");
                idade = double.Parse(Console.ReadLine());
                idade1 += idade;
                
               
                if (idade == 0){ Console.WriteLine("Média dos numeros digitados: " + (idade1 / cont));}
                if (idade > 0) { cont++; }
            }
        }
        
    }
}
