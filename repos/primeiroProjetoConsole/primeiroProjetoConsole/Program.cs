using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroProjetoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("informe o seu nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("informe a sua idade: ");
            UInt16 idadeUsuario = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("informe o numero do seu documento: ");
            string documentoUsuario = Console.ReadLine();

            Console.WriteLine("digite o nome da sua rua: ");
            string ruaUsuario = Console.ReadLine();

            Console.WriteLine("informe o numero da casa: ");
            UInt32 numCasaUsuario = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("informe o seu genero, informe F para feminino e M para masculino: ");
            string genero = Console.ReadKey(true).KeyChar.ToString();


            Console.WriteLine("Ola " + nomeUsuario);
            Console.WriteLine("sua idade é de " + idadeUsuario);
            Console.WriteLine("seu numero de documento é " + documentoUsuario);
            Console.WriteLine("o endereço da sua Rua é " + ruaUsuario);
            Console.WriteLine("o numero da sua casa é " + numCasaUsuario);
            Console.WriteLine("seu genero é " + genero);
            Console.ReadKey();

        }
    }
}
