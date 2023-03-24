
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        public delegate double MeuDelegate(double a, double b);

        public static double soma(double a, double b)
        {
            double resultadoSoma = a + b;
            Console.WriteLine("A soma de " + a + " mais " + b + " é " + resultadoSoma);
            return resultadoSoma;
        }

        public static double multiplicacao(double a, double b)
        {
            double resultadoMulti = a * b;
            Console.WriteLine("A soma de " + a + " e " + b + " é " + resultadoMulti);
            return resultadoMulti;
        }

        public static void executaOperacao(MeuDelegate minhasOperacoes, MeuDelegate minhasOperacoes2)
        {
            Console.WriteLine("executando o metodo passado como parametro de entrada...");
            double a = minhasOperacoes(50, 20);
            double b = minhasOperacoes2(2, 2);

            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {

            MeuDelegate operacoes;
            operacoes = soma;
            double resultadoDelegate =  operacoes(10, 20);

            Console.WriteLine("resultado do delegate é: " + resultadoDelegate);

            operacoes += multiplicacao;
            resultadoDelegate = multiplicacao(2, 2);

            Console.WriteLine("resultado do delegate é: " + resultadoDelegate);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            executaOperacao(soma, multiplicacao);

            Console.ReadKey();  

        }
    }
}
