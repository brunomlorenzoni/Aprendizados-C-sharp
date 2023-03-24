using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("precione C para continue");
                Console.WriteLine("precione B para break");

                string tecla = Console.ReadKey(true).KeyChar.ToString();
                if (tecla == "c")
                {
                    continue;
                }
                else if(tecla == "b")
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida!!");  
                }

                Console.WriteLine("precione qualquer tecla para Continuar!!");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("precione qualquer tecla para Continuar!!");
            Console.ReadKey();

        }
       
    }
}
