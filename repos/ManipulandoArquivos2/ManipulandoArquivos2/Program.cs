using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipulandoArquivos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "C:\\Users\\lab102a\\source\\repos\\ManipulandoArquivos2\\ManipulandoArquivos2\\bin\\Debug\\teste.txt";
            string caminhoArquivo2 = "C:\\Users\\lab102a\\source\\repos\\ManipulandoArquivos2\\ManipulandoArquivos2\\bin\\Debug\\teste2.txt";
            string texto1 = "\r\nTeste 1 \r\n";
            string texto2 = "Teste 2 \r\n";

            string limpa = "";
            File.WriteAllText(caminhoArquivo, limpa);


            // maneira não muito correta

            string conteudoInicial = File.ReadAllText(caminhoArquivo);
            string conteudoFinal = conteudoInicial + texto1 + texto2;

            File.WriteAllText(caminhoArquivo, conteudoFinal);


            // maneira correta


            //File.AppendAllText(caminhoArquivo2, texto1);
            //File.AppendAllText(caminhoArquivo2, texto2);

            File.AppendAllText(caminhoArquivo2, texto1  + texto2);



        }
    }
}
 