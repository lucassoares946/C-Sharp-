using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            double L1, L2, L3, T, area;
            Console.WriteLine("Área de um triângulo - Fórmula de Herão (sabemos os 3 lados)");
            Console.WriteLine("Digite o valor do 1° lado do triângulo");
            L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do 2° lado do triângulo");
            L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do 3° lado do triângulo");
            L3 = double.Parse(Console.ReadLine());
            T = (L1 + L2 + L3) / 2;
            area = Math.Sqrt(T*(T - L1)*(T - L2)*(T - L3));
            //Saida
            Console.WriteLine("A área do triângulo vale " + Math.Round(area,1));
            Console.ReadKey();
        }
    }
}
