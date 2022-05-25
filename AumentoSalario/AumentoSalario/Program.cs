using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, salario_reajustado;
            Console.WriteLine("Reajuste de Salários na Empresa...");
            Console.WriteLine("Digite o salário do funcionário, em R$:");
            salario = double.Parse(Console.ReadLine());
            if (salario < 2500) { reajuste = 0.12 * salario; }
            else { reajuste = 0.05 * salario; }
            salario_reajustado = salario + reajuste;
            Console.WriteLine("Salário Anterior = R$ " + Math.Round salario, 2);
            Console.WriteLine("Reajuste Salarial = R$ " + Math.Round reajuste, 2));
            Console.WriteLine("Salário Reajustado = R$ " + Math.Round salario_reajustado, 2));
            Console.ReadKey();
        }
    }
}
