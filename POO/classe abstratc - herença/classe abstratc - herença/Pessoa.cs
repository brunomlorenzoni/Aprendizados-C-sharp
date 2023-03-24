using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_abstratc___herença
{
    // abstract faz qual que a classe só possa ser herdada
    internal abstract class Pessoa
    {
        private string nome;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void MostraNome()
        {
            Console.WriteLine("o nome da pessoa é " + nome + Nome);
        }

        public Pessoa(string pNome)
        {
            this.nome = pNome;
        }


    }
}
