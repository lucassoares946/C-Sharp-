using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio31
{
    class Program { 
    
        static void Main(string[] args)
        {
            double acao, cont = 0, cont2 = 0, lucro,preco,l = 1,j = 2,k = 3,d = 4;
            
            Console.WriteLine("Digite o valor a ser investido ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite qual ação deseja comprar L J K D ");
            acao = Console.Read();
            

            
            if(acao == 1) {
                
                Console.WriteLine("Seu lucro foi de : " + preco * 0.10);
            }

            if (acao == 2)
            {
                
                Console.WriteLine("Seu lucro foi de : " + preco * 0.20);
            }

            if (acao == 3)
            {
               
                Console.WriteLine("Seu lucro foi de : " + preco * 0.5);
            }

            if (acao == 4)
            {
                
                Console.WriteLine("Seu lucro foi de : " + preco * 0.2);
            }
            if (preco >= 1000) {
                cont++;
            }

            if (preco <=200)
            {
                cont2++;
            
            Console.WriteLine("Lucro mais de 1000" + cont);
            Console.WriteLine("Lucro menos de 200" + cont2);
            if(acao == 'f')
            {

            }
            Console.ReadKey();

        }
       
    }
}
}
