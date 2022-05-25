using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            double distancia, xA, yA, xB, yB;
            Console.WriteLine("Calcule a distância entre dois pontos");
            Console.WriteLine("Digite o 1° valor");
            xA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor");
            yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3° valor");
            xB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4° valor");
            yB = double.Parse(Console.ReadLine());
            //Processamento
            distancia = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            //Saida
            Console.WriteLine("\n\nA distância entre os pontos A e B, vale " + Math.Round(distancia,1));
            Console.ReadKey();



        }
    }
}
