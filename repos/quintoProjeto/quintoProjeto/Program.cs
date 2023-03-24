using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quintoProjeto
{
    internal class Program
    {

        public struct dadosCadastro
        {
            public string nome;
            public DateTime dataNascimento;
            public string nomeRua;
            public int numCasa;

        };

        public enum resultado_e
        {
             Sucesso = 0,
             Sair = 1,
             Excessao = 2
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("precione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static resultado_e pegaString(ref string minhaString, string mensagem)
        {
            resultado_e retorno;

            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if(temp == "s" ||  temp == "S")
            {
                retorno = resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno = resultado_e.Sucesso; 
            }

            Console.Clear();
            return retorno; 
        }

        public static resultado_e pegaData(ref DateTime data, string mensagem)
        {
            resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = resultado_e.Sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = resultado_e.Sucesso;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCESSAO: " + e.Message);
                    MostraMensagem("");
                    retorno = resultado_e.Excessao;
                }



            } while (retorno == resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static resultado_e pegaInt(ref int numero, string mensagem)
        {
            resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = resultado_e.Sair;
                    }
                    else
                    {
                        numero = Convert.ToInt32(temp);
                        retorno = resultado_e.Sucesso;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCESSAO: " + e.Message);
                    MostraMensagem("");
                    retorno = resultado_e.Excessao;
                }



            } while (retorno == resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static void CadastraUsuario(ref List<dadosCadastro> listausuario)
        {
            dadosCadastro cadastro;

            cadastro.nome = "";
            cadastro.dataNascimento =  new DateTime();
            cadastro.nomeRua = "";
            cadastro.numCasa = 0;

            if (pegaString(ref cadastro.nome, "Digite o seu nome, ou S para sair") != resultado_e.Sucesso)
            {
                return; 
            }
            if (pegaData(ref cadastro.dataNascimento, "digite a sua data de nascimento, ou S para sair") != resultado_e.Sucesso)
            {
                return;
            }
            if (pegaString(ref cadastro.nomeRua, "Digite o nome da sua rua, ou S para sair") != resultado_e.Sucesso)
            {
                return;
            }
            if(pegaInt(ref cadastro.numCasa, "digite o numero da sua casa, ou S para sair") != resultado_e.Sucesso)
            {
                return;
            }
            listausuario.Add(cadastro);
        }



        static void Main(string[] args)
        {

            List<dadosCadastro> Listausuarios = new List<dadosCadastro> ();

            string opcao = "";

            do
            {
                Console.WriteLine("digite C para cadastrar ou digite S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if(opcao == "c")
                {
                    CadastraUsuario(ref Listausuarios);
                }
                else if(opcao == "s")
                {
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    MostraMensagem("opcao invalida");
                }

            } while (opcao != "s");





        }
    }
}
