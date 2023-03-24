using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // NEGAÇÂO =>  ~

            int var1 = 0b11001100;
            int resultadoNegacao = ~var1;

            Console.WriteLine("o resultado da negação de " + Convert.ToString(var1, 2) + " é " + Convert.ToString(resultadoNegacao, 2));

            Console.WriteLine("=================================================================================================");

            // OPERADOR OR => |

            int var2 = 0b11001100;
            int var3 = 0b11110000;
            int resultadoOU = var2 | var3;

            Console.WriteLine("o resultado da operação 'ou' de " + Convert.ToString(var2, 2)+ " e "+ Convert.ToString(var3, 2) + " é " + Convert.ToString(resultadoOU, 2));

            Console.WriteLine("=================================================================================================");

            // OPERADOR AND => &

            int resultadoE = var2 & var3;

            Console.WriteLine("o resultado da operação 'E' de " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é " + Convert.ToString(resultadoE, 2));

            Console.WriteLine("=================================================================================================");

            // OPERADOR XOR => ^

            int resultadoROX = var2 ^ var3;

            Console.WriteLine("o resultado da operação 'ROX' de " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é " + Convert.ToString(resultadoROX, 2));

            Console.WriteLine("=================================================================================================");

            // OPERADOR < e > 

            int var4 = 10;
            int var5 = 20;

            Console.WriteLine("o valor " + var4 + " é maior que " + var5 + "? = " + (var4 > var5));
            Console.WriteLine("o valor " + var4 + " é menor que " + var5 + "? = " + (var4 < var5));

            Console.WriteLine("=================================================================================================");

            // OPERADOR < e > 

            Console.WriteLine("o valor " + var4 + " é maior ou igual que " + var5 + "? = " + (var4 >= var5));
            Console.WriteLine("o valor " + var4 + " é menor ou igual que " + var4 + "? = " + (var4 <= var4));
            Console.WriteLine("o valor " + var5 + " é maior ou igual que " + var5 + "? = " + (var5 >= var5));
            Console.WriteLine("o valor " + var5 + " é menor ou igual que " + var4 + "? = " + (var5 <= var4));

            Console.WriteLine("=================================================================================================");


            Console.ReadKey();
        }
    }
}
