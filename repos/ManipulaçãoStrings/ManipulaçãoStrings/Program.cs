using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaçãoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // indexação

            string nome = "guilherme";
            char letra = nome[4];
            Console.WriteLine(letra);


            // concatenar strings

            string sobrenome = " silva";
            string nomeCompleto = nome + sobrenome;
            Console.WriteLine(nomeCompleto);

            string nomeCompleto2 = String.Concat(nome, sobrenome);
            Console.WriteLine(nomeCompleto2);

            // substituição de strings

            string endereco = "rua das rodas verdes";
            endereco = endereco.Replace("verdes", "vermelhas");
            Console.WriteLine(endereco);

            // remover um texto da string

            string endereco2 = "rua das rodas verdes";
            endereco2 = endereco2.Replace("verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "rua das rodas verdes";
            endereco3 = endereco3.Remove(0, 4);
            Console.WriteLine(endereco3);

            // transformação de strings de maiuscula pra minuscula e vice-versa

            string nome2 = "Joao da silva";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();
            Console.WriteLine(nome2);

            // Contem 

            string nome3 = "Joao da silva";
            bool contem = nome3.Contains("Joao");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcos");
            Console.WriteLine(contem);
            

            // localização de textos

            string nome4 = "Joao da silva";
            int indice = nome4.IndexOf("da");
            Console.WriteLine(indice);

            // divisao de string

            string nome5 = "Joao da silva";
            string[] divisores = {"da "};

            string[] resuladoDivisao = nome5.Split(divisores, StringSplitOptions.None);
            foreach (var nomes in resuladoDivisao)
            {
                Console.WriteLine(nomes);
            }

            // numeros caractes de um string

            string nome6 = "Joao da silva";
            int numeroCaracteres = nome6.Length;
            Console.WriteLine(numeroCaracteres);

            // pegar uma parte do texto da string

            string nome7 = "Joao da silva";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);


            // formatação composta 

            string nome8 = "joao {0} {1} ";
            Console.WriteLine(nome8, "da", "silva"); 


            Console.ReadKey();

        }
    }
}
