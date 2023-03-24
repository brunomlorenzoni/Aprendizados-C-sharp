using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;

namespace Serialização_e_desserialização_de_classes
{


    [DataContract]

    internal class Cachorro
    {
        [DataMember]
        public string Nome { get ; set ;}
        [DataMember]
        public string raca;
        [DataMember]
        private string cor;

        public Cachorro(string nome, string raca, string cor)
        {
            Nome = nome;
            this.raca = raca;
            this.cor = cor;
        }

        public Cachorro()
        {

        }

        public static implicit operator Cachorro(XmlReader v)
        {
            throw new NotImplementedException();
        }
    }
}
