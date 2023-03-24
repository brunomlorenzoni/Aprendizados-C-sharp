using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {

        public static double Soma(double a, double b)
        {
            double resultadoSoma = a + b;
            return resultadoSoma;
        }
        static void Main(string[] args)
        {

            double resultado = Soma(10, 20);
            Console.WriteLine(resultado);
            Console.ReadKey();  

        }
    }
}
