using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_de_arquivos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string caminho = "teste.txt";
            
            FileStream fs = File.Create(caminho);
            fs.Close();

            StreamWriter sw = new StreamWriter(caminho);

            sw.Write("Ola mundo\r\n");
            sw.Write("Ola mundo\r\n");

            sw.WriteLine("Ola mundo");
            sw.WriteLine("Ola mundo");

            sw.Close();

            StreamReader sr = new StreamReader(caminho);

            char[] buffer = new char[128];

            sr.Read(buffer, 4, 8);

            sr.Close(); 




            

        }
    }
}
