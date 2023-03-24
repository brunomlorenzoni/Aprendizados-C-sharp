using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            
            // IF  ELSE

            if (idade > 18)
            {
                Console.WriteLine("voce é maior de idade");
            }
            else
            {
                Console.WriteLine("voce é menor de idade");
            }

            Console.WriteLine("======================================================================================");

            // IFF ELSE IFF

            Console.WriteLine("informe o seu salario: ");
            int salario = Convert.ToInt32(Console.ReadLine());

            if (salario < 1000)
            {
                Console.WriteLine("voce gana menos que 1 salario minimo");

            }else if (salario < 2000)
            {
                Console.WriteLine("voce gana menos que 2 salario minimo");
            }
            else if(salario < 3000)
            {
                Console.WriteLine("voce gana menos que 3 salario minimo");
            }
            else
            {
                Console.WriteLine("voce gana mais que 3 salario minimo");
            }

            Console.WriteLine("======================================================================================");


            Console.ReadKey();
        }
    }
}
