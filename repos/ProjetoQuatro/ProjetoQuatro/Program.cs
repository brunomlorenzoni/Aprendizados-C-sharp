using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuatro
{
    internal class Program
    {
        struct dadosCadastrais_struct
        {
            public string nome;
            public string nomeRua;
            public int numCasa;
            public string numDocumento;
        };


        static void Main(string[] args)
        {

            List<dadosCadastrais_struct> listaDeCadastros = new List<dadosCadastrais_struct> ();

            string opcao;

            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuario ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if(opcao == "c")
                {
                    dadosCadastrais_struct dadosCadastrais;

                    Console.WriteLine("informe o seu nome");
                    dadosCadastrais.nome = Console.ReadLine();
                    Console.WriteLine("informe o nome da rua");
                    dadosCadastrais.nomeRua = Console.ReadLine();
                    Console.WriteLine("informe o numero da casa");
                    dadosCadastrais.numCasa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("indorme o numero do documento");
                    dadosCadastrais.numDocumento = Console.ReadLine(); 

                    listaDeCadastros.Add(dadosCadastrais);

                    Console.Clear();

                }
                else if(opcao == "s")
                {
                    Console.WriteLine("encerrando o programa");
                    
                }
                else
                {
                    Console.WriteLine("opcao desconhecida");
                }


            } while (opcao != "s");
            Console.WriteLine("precione para sair");
            Console.ReadKey();

        }
    }
}
