using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcastring_e_downcasting
{
    internal class Pessoa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
        }

        public void ImprimiNome()
        {
            Console.WriteLine("o nome da pessoa é " + nome);
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
    }
}
