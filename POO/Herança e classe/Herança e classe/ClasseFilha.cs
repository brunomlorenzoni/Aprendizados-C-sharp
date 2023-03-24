using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_classe
{
    internal class ClasseFilha : ClasseMae
    {
        public string AtributoFilha = "atributo da filha";

        public string PropriedadeFilha
        {
            get;
            set;
        }
        public void MetodoDaClasseFilha()
        {

            
            Console.WriteLine("metodo da classe filha");
            
        }

        public ClasseFilha()
        {
            PropriedadeFilha = "propriedade da filha";
        }

    }
}
