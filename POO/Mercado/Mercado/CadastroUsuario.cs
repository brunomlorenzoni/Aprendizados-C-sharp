using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    internal class CadastroUsuario
    {
        private string nomeUsuario;
        private int id;
        private string senha;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string Senha 
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Id
        {
            get { return id;  }
            set { id = value; }

        }

        public CadastroUsuario(string nomeUsuario, string senha, int id)
        {
            this.nomeUsuario = nomeUsuario;
            this.senha = senha;
            this.id = id;      
        }


    }
}
