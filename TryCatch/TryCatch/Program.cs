using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();//Agregamos a classe Pessoa
            Linha();
            Console.WriteLine("Digite seu nome: ");
            p.setNome(Console.ReadLine());//Obtemos o nome da pessoa via método setNome
            Linha();
            try
            {
                Console.WriteLine("Digite sua idade: ");
                p.setIdade(int.Parse(Console.Readline());
                Linha();
                Console.WriteLine("\nNome: " + p.getNome().ToUpper() + " - Idade: " + p.getIdade() + " anos");//exibe os dados da pessoa
                Linha();
            }
            catch (Exception erro)
            {
                Linha();
                Console.WriteLine("\n" + erro.Message + "\n");
                //Acima, exibe a mensagem de erro gerada pela exceção
                Linha();
            }
            finally
            {
                Console.WriteLine("\n\n Pressione uam tecla para finalizar....");
                Console.ReadKey();
            }

            public static void Linha() //Método Linha
            {
                for (int i = 1; i <= 60; i++) { Console.Write("="); }
            }
        }
    }
    }

