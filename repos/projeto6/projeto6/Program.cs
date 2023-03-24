using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // POTENCIAÇÃO (BASE,POTENCIA)

            double potenciacao = Math.Pow(4,2);
            Console.WriteLine(potenciacao);

            // RADICIAÇÃO (BASE, 1/raiz)

            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz);
            Console.WriteLine(radiciacao);

            // MAXIMO E MINIMO DE UM NUMERO

            double max = Math.Max(4, 8);
            Console.WriteLine(max);
            double min = Math.Min(4, 8);
            Console.WriteLine(min);

            // MODULO

            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);

            // OPERAÇÕES TRIGONOMETRICAS

            /*
            seno = sin
            cosseno = cos
            tangente = tan
             */

            double angulo = 30 * (2 * Math.PI) / 360;
            double seno = Math.Sin(angulo);


            // ARREDONDANDO NUMEROS

            double numero = 3.33;
            double arredondaPraCima = Math.Ceiling(numero);
            double arredondaPraBaixo = Math.Floor(numero);

            Console.WriteLine(arredondaPraCima);
            Console.WriteLine(arredondaPraBaixo);


            // LOGARITMO

            double base10 = Math.Log10(100);
            Console.WriteLine(base10);
            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);

            Console.ReadKey();
        }
    }
}
