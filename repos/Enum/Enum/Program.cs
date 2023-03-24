using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {

        enum NotasDeReal
        {
            NotaDe2 = 2,
            NototaDe5 = 5,
            NototaDe10 = 10
        };

        enum NotaDaProva
        {
            nota_1 = -1,
            Nota0 = 0,
            Nota1,
            Nota2,
            Nota3,
            Nota4,
        };

        static void Main(string[] args)
        {
            NotasDeReal minhaNota = NotasDeReal.NototaDe10;
            Console.WriteLine(minhaNota + " vale " + Convert.ToUInt32(minhaNota));

            NotaDaProva minhaNotaProva = NotaDaProva.Nota4 ;
            Console.WriteLine(minhaNotaProva + " vale " + Convert.ToUInt32(minhaNotaProva));


            Console.ReadKey();  
        }
    }
}
