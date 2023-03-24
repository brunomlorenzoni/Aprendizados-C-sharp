using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for
            for(int i=1; i<=10 ; i++ )
            {
                Console.WriteLine(i);
            }

            // while
            int j = 0;
            while(j<100)
            {
                Console.WriteLine("Bom dia");
                j += 10;
            }


            // do while
            int k = 0;

            do
            {
                Console.WriteLine("Boa noite");
                k += 100;
            } while (k<1000);

            //for

            string[] nomes = { "guilherme", "joao", "bruno", "pietro", "maria" };

            foreach(string nome in  nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
