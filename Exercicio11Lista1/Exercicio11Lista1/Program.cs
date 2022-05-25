using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dol, dolhj, lucro, real,icms,lucrof;
            Console.WriteLine("Digite o valor da sua compra internacional em doláres");
            dol = double.Parse(Console.ReadLine());
            Console.WriteLine("A taxa do dolar hoje");
            dolhj = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ICMS");
            icms = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Porcentagem de Lucro da Empresa");
            lucro = double.Parse(Console.ReadLine());
            real = dol * dolhj;
            icms = icms / 100;
            lucro = lucro / 100;
            lucrof = real + (real * lucro) + (real * icms);
            Console.WriteLine("Preço em R$ " + lucrof);

            Console.ReadKey();
            
        }
    }
}
