using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumePiramide
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, area_base, altura;
            Console.WriteLine("Volume de uma pirâmide");
            Console.WriteLine("Digite o valor da area da base em m²");
            area_base = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da pirâmide em m:" );
           
            altura = double.Parse(Console.ReadLine());
            volume = (area_base * altura) / 3;
            Console.WriteLine("O volume da pirâmide é " + Math.Round(volume,2) + "m³");
            Console.ReadKey();
        }
    }
}
