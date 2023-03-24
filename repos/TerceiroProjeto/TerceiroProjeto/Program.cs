using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            do{

                Console.WriteLine("precione C para cadastrar um usuario ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if(opcao == "c")
                {

                    Console.WriteLine("Digite o seu nome completo");
                    string nome = Console.ReadLine();

                    Console.WriteLine("precione M para masculino e F para feminino");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("informe a sua data de nascimento no formato dd/mm/aaaa");
                    DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da sua rua");
                    string rua = Console.ReadLine();
                    Console.WriteLine("Digite o numero da casa");
                    int numeroCasa = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                }
                else if (opcao == "s")
                {
                    Console.WriteLine("encerrando o programa");
                    break;
                }
                else
                {
                    Console.WriteLine("opcao desconhecida ");
                }

            }while (opcao == "s");
            Console.WriteLine("precione qualquer tecla para sair");
            Console.ReadKey();
        }
        
    }
}
