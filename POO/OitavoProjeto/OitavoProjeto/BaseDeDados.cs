using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OitavoProjeto
{
    internal class BaseDeDados
    {
        // atributos
        private List<CadastroPessoa> listaDePessoas;

        // metodos

        public void AdicionaPessoa(CadastroPessoa pessoa)
        {

            listaDePessoas.Add(pessoa);

        }

        public List<CadastroPessoa> PesquisaPessoaPorDoc(string numeroDocumento)
        {
            List<CadastroPessoa> listaDePessoaTemporaria = listaDePessoas.Where(x => x.NumeroDocumento == numeroDocumento).ToList();

            if(listaDePessoaTemporaria.Count > 0)
            {
                return listaDePessoaTemporaria;
            }   
            else
            {
                return null;
            }

        }

        public List<CadastroPessoa> ExcluiPessoaPorDoc(string numeroDocumento)
        {
            List<CadastroPessoa> listaDePessoaTemporaria = listaDePessoas.Where(x => x.NumeroDocumento == numeroDocumento).ToList();


            if (listaDePessoaTemporaria.Count > 0)
            {
                foreach (CadastroPessoa pessoa in listaDePessoaTemporaria)
                {
                    listaDePessoas.Remove(pessoa);
                }
                return listaDePessoaTemporaria;
            }
            else { return null; }

        }

        // construtor

        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }


    }
}
