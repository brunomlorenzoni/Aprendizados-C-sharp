using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListaDeNomes = new List<string>();

            // adiciona elementos
            ListaDeNomes.Add("bruno");
            ListaDeNomes.Add("ladir");
            ListaDeNomes.Add("pietro");
            ListaDeNomes.Add("derli");       

            // remomer elementos

            ListaDeNomes.Remove("bruno");


            // removendo elementos em posicoes especificas 

            ListaDeNomes.RemoveAt(0);

            foreach (var nomes in ListaDeNomes)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");    

            List<string> ListaDeNomes2 = new List<string>();

            ListaDeNomes2.Add("bruno");
            ListaDeNomes2.Add("ladir");
            ListaDeNomes2.Add("pietro");
            ListaDeNomes2.Add("derli");

            // remover uma faixa de elementos

            ListaDeNomes2.RemoveRange(2, 2);

            foreach (var nomes in ListaDeNomes2)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // pegando o numero de elementos


            Console.WriteLine("a lista de nomes 2 possui: " + ListaDeNomes2.Count+ " elementos");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // concatenando listas

            List<string> listaNomesConcatenada = ListaDeNomes.Concat(ListaDeNomes2).ToList();

            foreach (var nomes in listaNomesConcatenada)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
             
            // verificando valores dos elementos da lista 

            bool contemNome = listaNomesConcatenada.Contains("bruno ");

            Console.WriteLine(contemNome);


            // descobrindo indice do elemento

            int indice = listaNomesConcatenada.IndexOf("ladir");

            Console.WriteLine(indice);

            // operador where

            List<string> listaWhere = listaNomesConcatenada.Where(x => x.StartsWith("l")).ToList();

            foreach (var nomes in listaWhere)
            {
                Console.WriteLine(nomes);
            }


            Console.ReadKey();

        }
    }
}
