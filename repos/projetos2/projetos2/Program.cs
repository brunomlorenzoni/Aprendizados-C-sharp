using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;

            // NEGAÇÂO

            bool resultadoNeg = !var1;
            Console.WriteLine("a negação de " + var1 + " é " + resultadoNeg);
            resultadoNeg = !var2;
            Console.WriteLine("a negação de " + var2 + " é " + resultadoNeg);


            Console.WriteLine("======================================================================================");

            // OPERADOR AND &&

            bool resultadoAnd = var1 && var1;
            Console.WriteLine("o resultado da operacao E entre " + var1 + " e " + var1 + " resulta em " + resultadoAnd);
            resultadoAnd = var1 && var2;
            Console.WriteLine("o resultado da operacao E entre " + var1 + " e " + var2 + " resulta em " + resultadoAnd);
            resultadoAnd = var2 && var2;
            Console.WriteLine("o resultado da operacao E entre " + var2 + " e " + var2 + " resulta em " + resultadoAnd);


            Console.WriteLine("======================================================================================");

            // OPERADOR OR ||

            bool resultadoOr = var1 || var1;
            Console.WriteLine("o resultado da operacao E entre " + var1 + " e " + var1 + " resulta em " + resultadoOr);
            resultadoOr = var1 || var2;
            Console.WriteLine("o resultado da operacao E entre " + var1 + " e " + var2 + " resulta em " + resultadoOr);
            resultadoOr = var2 || var2;
            Console.WriteLine("o resultado da operacao E entre " + var2 + " e " + var2 + " resulta em " + resultadoOr);

            Console.WriteLine("======================================================================================");

            // OPERADOR OR EXCLUSIVO ^

            bool resultadoXor = var1 ^ var1;
            Console.WriteLine("o resultado da operacao E entre " + var1 + " e " + var1 + " resulta em " + resultadoXor);
            resultadoXor = var1 ^ var2;
            Console.WriteLine("o resultado da operacao E entre " + var1 + " e " + var2 + " resulta em " + resultadoXor);
            resultadoXor = var2 ^ var2;
            Console.WriteLine("o resultado da operacao E entre " + var2 + " e " + var2 + " resulta em " + resultadoXor);



            Console.ReadKey();
        }
    }
}
