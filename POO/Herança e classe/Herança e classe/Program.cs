using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasseFilha obj = new ClasseFilha();
            Console.WriteLine(obj.AtributoMae);
            Console.WriteLine(obj.PropriedadeMae); 

            Console.ReadKey();
        }
    }
}
