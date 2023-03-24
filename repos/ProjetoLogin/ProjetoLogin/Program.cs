using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o nome de usuario do seu usuario: ");
                string usuario = Console.ReadLine();

                Console.WriteLine("Digite a sua senha: ");
                string senha = "";
                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else
                    {
                        senha += tecla.KeyChar;
                    }
                }
                if (usuario == "joao" && senha == "1234")
                {
                    Console.WriteLine("Usuario Logado com sucesso !!!");
                    break;
                }
                else
                {
                    Console.WriteLine("usuario ou senha incorretos !!!");
                    Console.WriteLine("Precione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();    
                }

            }
            Console.WriteLine("precione qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
