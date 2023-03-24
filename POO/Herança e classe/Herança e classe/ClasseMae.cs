using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_classe
{
    internal class ClasseMae
    {
        public string AtributoMae = "atributo da mae";
        
        public string PropriedadeMae
        {
            get;
            set;
        }

        public void MetodoDaClasseMAE()
        {
            Console.WriteLine("metodo da classe mae");
        }
        public ClasseMae()
        {
            PropriedadeMae = "propriedade da mae";  
        }
    }
}
