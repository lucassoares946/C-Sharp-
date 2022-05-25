using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, mediagrupo = 0, mediam = 0, mediah = 0, idade,sexo;
            for(i=0; i < 7; i++) 
            {
                Console.WriteLine("Digite sua idade: ");
                idade = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu sexo 1 Homem 2 Mulher");
                sexo = double.Parse(Console.ReadLine());
                mediagrupo += idade;
                if (sexo == 2) { mediam =+ idade; }
                if(sexo == 1) { mediah =+ idade; }
                
            }
            Console.WriteLine("A idade média do grupo: " + mediagrupo / 7);
            Console.WriteLine("A idade média das mulheres do grupo: " + mediam / 7);
            Console.WriteLine("A idade média dos homens do grupo: " + mediah / 7);
            Console.ReadKey();
        }
    }
}
