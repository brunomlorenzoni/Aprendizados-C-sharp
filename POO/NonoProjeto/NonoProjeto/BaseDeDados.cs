using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OitavoProjeto
{
    [DataContract]
    internal class BaseDeDados
    {
        // atributos
        [DataMember]
        private List<CadastroPessoa> listaDePessoas;

        private string caminhoBaseDeDados;

        // metodos

        public void AdicionaPessoa(CadastroPessoa pessoa)
        {

            listaDePessoas.Add(pessoa);
            Serializador.Serializa(caminhoBaseDeDados, this);

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

        public BaseDeDados(string caminhoBaseDeDados)
        {
            this.caminhoBaseDeDados = caminhoBaseDeDados;
            listaDePessoas = new List<CadastroPessoa>();
            BaseDeDados baseDeDadosTemp = Serializador.Desserializa(caminhoBaseDeDados);
            if(baseDeDadosTemp != null)
            {
                listaDePessoas = baseDeDadosTemp.listaDePessoas;
            }
            else
            {
                listaDePessoas = new List<CadastroPessoa>();
            }
            
        }


    }
}
