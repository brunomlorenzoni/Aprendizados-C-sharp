using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("precione A para alugar um filme, ou S para sair da locadora");
            char opcao = Console.ReadKey(true).KeyChar;

            if(opcao == 'A' || opcao == 'a')
            {
                Console.WriteLine("precione 1 para alugar top gun");
                Console.WriteLine("precione 2 para alugar a bela e a fera");
                Console.WriteLine("precione 3 para alugar o homem aranha");

                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

                switch (opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("voce alugou top gun"); 
                        break;
                    case 2:
                        Console.WriteLine("voce alugou a bela e a fera");
                        break;
                    case 3:
                        Console.WriteLine("voce alugou o Homem aranha");
                        break;
                    default:
                        Console.WriteLine("opcao desconhecida");
                        break;
                }

                Console.WriteLine("precione uma tecla para finalizar o programa");

            }
            else if(opcao == 'S' || opcao == 's')
            {
                Console.WriteLine("Muito Obrigado, volte sempre!!!");
            }
            else
            {
                Console.WriteLine("comando não conhecido");
            }

            Console.ReadKey();
        }
    }
}
