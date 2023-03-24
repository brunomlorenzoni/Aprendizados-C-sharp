using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipulaçãoArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando Caminho de arquivo

            string caminho1 = "C:\\Users\\lab102a\\source\\repos\\ManipulaçãoArquivo\\ManipulaçãoArquivo\\bin\\Debug\\teste.txt";

            //Criar arquivo

                FileStream arquivo =  File.Create(caminho1);
                arquivo.Close();

            // Verificando se um arquivo existe

            bool arquivoExiste = File.Exists(caminho1);

            Console.WriteLine(arquivoExiste);

            // deletando arquivos

            File.Delete(caminho1);

            // renomeando arquivos
            
            /*
            string caminho2 = "C:\\Users\\lab102a\\source\\repos\\ManipulaçãoArquivo\\ManipulaçãoArquivo\\bin\\Debug\\test2.txt";
            FileStream arquivo2 = File.Create(caminho2);
            arquivo2.Close();
            string caminho3 = "C:\\Users\\lab102a\\source\\repos\\ManipulaçãoArquivo\\ManipulaçãoArquivo\\bin\\Debug\\test3.txt";
            File.Move(caminho2, caminho3);
            */

            // escrevendo em arquivos de texto


            string caminho4 = "C:\\Users\\lab102a\\source\\repos\\ManipulaçãoArquivo\\ManipulaçãoArquivo\\bin\\Debug\\nomes.txt";
            FileStream arquivo4 = File.Create(caminho4);
            arquivo4.Close();

            string conteudo = "Bruno é daora \r\n Pietro é burro";
            File.WriteAllText(caminho4, conteudo);

            // escrevendo um array de strings no arquivo

            string[] conteudoArray = { "guilherme", "joao", "marcos", "pedro", "maria" };
            File.WriteAllLines(caminho4, conteudoArray);
            Console.Clear();

            //Lendo o conteudo de um arquivo

            string conteudoLido = File.ReadAllText(caminho4);

            Console.WriteLine(conteudoLido);

            // lendo o conteudo de um arquivo e gravando num array de strings

            
            string[] conteudoLidoArray = File.ReadAllLines(caminho4);

            foreach (var item in conteudoLidoArray)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
