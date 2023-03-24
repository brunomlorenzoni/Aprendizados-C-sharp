using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilaEfila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> FilaNomes = new Queue<string>();

            // adicionando elementos de fila

            FilaNomes.Enqueue("bruno");
            FilaNomes.Enqueue("pietro");
            FilaNomes.Enqueue("ladir");
            FilaNomes.Enqueue("derli");

            // retirando elementos de fila

            string nomeRemovido = FilaNomes.Dequeue();
            Console.WriteLine(nomeRemovido);
            nomeRemovido = FilaNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // espiando o elemento de fila

            string nomeEspiado = FilaNomes.Peek();
            Console.WriteLine(nomeEspiado);
            nomeEspiado = FilaNomes.Peek();
            Console.WriteLine(nomeEspiado);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Stack<string> pilhaNomes = new Stack<string>();

            // adicionando elementos na pilha

            pilhaNomes.Push("jao");
            pilhaNomes.Push("pedro");
            pilhaNomes.Push("fatima");
            pilhaNomes.Push("lurdes");

            // removendo elementos na pilha

            string nomeRemovido2 = pilhaNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            nomeRemovido2 = pilhaNomes.Pop();
            Console.WriteLine(nomeRemovido2);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // espiar elementos na pilha

            string nomeEspiado2 = FilaNomes.Peek();
            Console.WriteLine(nomeEspiado2);
            nomeEspiado2 = FilaNomes.Peek();
            Console.WriteLine(nomeEspiado2);

            /*
             outro metodos uteis para pilha
            Count
            clear
            concat
            contains
            ...
             
             */


            Console.ReadKey();

        }
    }
}
