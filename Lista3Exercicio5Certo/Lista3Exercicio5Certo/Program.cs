using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio5Certo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double aumento, i, salario;
            
            
           
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite seu nome ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o valor gasto ");
                aumento = Double.Parse(Console.ReadLine());
                    

                    if (aumento <= 1000)

                    Console.WriteLine(nome + " Seu bonus é de " + aumento * 0.10);
                else { Console.WriteLine(nome + " Seu bonus é de " + aumento * 0.15); }
            
        }
            

            

            
               
                
                    
                
            
        }
    }
}
