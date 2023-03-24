using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OitavoProjeto
{

    [DataContract]
    internal class CadastroPessoa
    {
        [DataMember]
        // atributos
        private string nome;
        [DataMember]
        private string numeroDocumento;
        [DataMember]
        private DateTime dataNascimento;
        [DataMember]
        private int numCasa;
        [DataMember]
        private string nomeRua;

        // propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public int NumCasa
        {
            get { return numCasa; }
            set { numCasa = value; }
        }
        public string NomeRua
        {
            get { return nomeRua; }
            set { nomeRua = value; }
        }

        // construtor

        public CadastroPessoa(string nome, string numeroDocumento, DateTime dataNascimento, int numCasa, string nomeRua)
        {

            this.nome = nome;
            this.numeroDocumento = numeroDocumento;
            this.dataNascimento = dataNascimento;
            this.numCasa = numCasa;
            this.nomeRua = nomeRua;

        }


    }
}
