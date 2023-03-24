using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array de 1 dimenção

            int[] meuArray = new int[3];
            meuArray[0] = 1;
            meuArray[1] = 10;
            meuArray[2] = 100;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            int[] meuArray2 = {1, 10, 100};
            Console.WriteLine(meuArray2[0]);
            Console.WriteLine(meuArray2[1]);
            Console.WriteLine(meuArray2[2]);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            int[] meuArray3 = new int[] {1, 10, 100};
            Console.WriteLine(meuArray3[0]);
            Console.WriteLine(meuArray3[1]);
            Console.WriteLine(meuArray3[2]);

            // array de 2 dimenções

            string[,] meuArray4 = new string[2,3];
            meuArray4[0 , 0] = "1";
            meuArray4[0 , 1] = "2";
            meuArray4[0 , 2] = "3";
            meuArray4[1 , 0] = "11";
            meuArray4[1 , 1] = "12";
            meuArray4[1 , 2] = "13";


            Console.WriteLine(meuArray4[0 , 0]);
            Console.WriteLine(meuArray4[0 , 1]);
            Console.WriteLine(meuArray4[0 , 2]);
            Console.WriteLine(meuArray4[1 , 0]);
            Console.WriteLine(meuArray4[1 , 1]);
            Console.WriteLine(meuArray4[1 , 2]);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            int tamanho1 = meuArray4.GetLength(0);
            int tamanho2 = meuArray4.GetLength(1);

            Console.WriteLine(tamanho1);
            Console.WriteLine(tamanho2);


            Console.ReadKey();

        }
    }
}
