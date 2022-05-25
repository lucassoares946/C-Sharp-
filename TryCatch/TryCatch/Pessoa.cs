using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Pessoa
    {
        //variáveis privadas para nome e idade da pessoa
        private string nome;
        private int idade;
        // Método que permite definir o nome da pessoa
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        // Método que permite definir a idade da pessoa
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        // Método que permite obter o nome da pessoa
        public string getNome()
        {
            return this.nome;
        }

        // Método que permite obter a idade da pessoa
        public int getIdade()
        {
            return this.idade;
        }
    }

}

