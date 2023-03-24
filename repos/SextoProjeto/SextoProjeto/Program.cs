using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SextoProjeto
{
    internal class Program
    {
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagNacimento;
        static string tagNomeRua;
        static string tagNumCasa;
        static string tagNumDocumento;
        static string caminhoArquivo;

        public struct dadosCadastro
        {
            public string nome;
            public DateTime dataNascimento;
            public string nomeRua;
            public int numCasa;
            public string numDocumento;

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
            if (temp == "s" || temp == "S")
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
                    Console.WriteLine("precione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
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
                    Console.WriteLine("precione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    retorno = resultado_e.Excessao;
                }



            } while (retorno == resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }
        public static void buscaUsuarioPeloDoc(List<dadosCadastro> listaUsuarios)
        {

            Console.WriteLine("informe o numero do documento para buscar o usuario, ou digite S para sair");
                
            string temp = Console.ReadLine();

            if(temp == "s" || temp == "S")
            {
                return;
            }
            else
            {
                List<dadosCadastro> listaUsuarioTemporaria = listaUsuarios.Where(x => x.numDocumento == temp).ToList();
                if(listaUsuarioTemporaria.Count > 0)
                {
                    foreach (dadosCadastro usuario in listaUsuarioTemporaria)
                    {
                        Console.WriteLine(tagNome + usuario.nome);
                        Console.WriteLine(tagNacimento + usuario.dataNascimento.ToString("dd/MM/yyyy"));
                        Console.WriteLine(tagNumDocumento + usuario.numDocumento);
                        Console.WriteLine(tagNomeRua + usuario.nomeRua);
                        Console.WriteLine(tagNumCasa + usuario.numCasa);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum usuario possui o documento: " + temp);
                }
                MostraMensagem("");
            }
        }

        public static void deletaUsuarioPeloDoc(ref List<dadosCadastro> listaUsuarios)
        {

            Console.WriteLine("informe o numero do documento para deletar o usuario, ou digite S para sair");
            string temp = Console.ReadLine();
            bool alguemExcluido = false;


            if (temp == "s" || temp == "S")
            {
                return;
            }
            else
            {
                
                List<dadosCadastro> listaUsuarioTemporaria = listaUsuarios.Where(x => x.numDocumento == temp).ToList();
                if (listaUsuarioTemporaria.Count > 0)
                {
                    foreach (dadosCadastro usuario in listaUsuarioTemporaria)
                    {
                        listaUsuarioTemporaria.Remove(usuario); 
                        alguemExcluido = true;
                    }
                    if(alguemExcluido == true)
                    {
                        gravaDados(caminhoArquivo, listaUsuarios);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum usuario possui o documento: " + temp);
                }
                MostraMensagem("");
            }
        }

        public static resultado_e CadastraUsuario(ref List<dadosCadastro> listausuario)
        {
            dadosCadastro cadastro;

            cadastro.nome = "";
            cadastro.dataNascimento = new DateTime();
            cadastro.nomeRua = "";
            cadastro.numCasa = 0;
            cadastro.numDocumento = "";

            if (pegaString(ref cadastro.nome, "Digite o seu nome, ou S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaData(ref cadastro.dataNascimento, "digite a sua data de nascimento, ou S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if(pegaString(ref cadastro.numDocumento, "digite o numero do seu documento, ou S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaString(ref cadastro.nomeRua, "Digite o nome da sua rua, ou S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaInt(ref cadastro.numCasa, "digite o numero da sua casa, ou S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }

            listausuario.Add(cadastro);
            gravaDados(caminhoArquivo, listausuario);
            return resultado_e.Sucesso;
        }

        public static void gravaDados(string caminho, List<dadosCadastro> Listausuarios)
        {
            try
            {
                string conteudoArquivo = "";

                foreach (dadosCadastro cadastro in Listausuarios)
                {
                    conteudoArquivo += delimitadorInicio + "\r\n";
                    conteudoArquivo += tagNome + cadastro.nome + "\r\n";
                    conteudoArquivo += tagNacimento + cadastro.dataNascimento.ToString("dd/MM/yyyy") + "\r\n";
                    conteudoArquivo += tagNumDocumento + cadastro.numDocumento + "\r\n";
                    conteudoArquivo += tagNomeRua + cadastro.nomeRua + "\r\n";
                    conteudoArquivo += tagNumCasa + cadastro.numCasa + "\r\n";
                    conteudoArquivo += delimitadorFim + "\r\n";
                }

                File.WriteAllText(caminho, conteudoArquivo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCESSAO: " + ex.Message);
            }
        }

        public static void carregaDados(string caminho, ref List<dadosCadastro> listaUsuarios)
        {
            try
            {
                if(File.Exists(caminho))
                {
                     string[] conteudoArquivo = File.ReadAllLines(caminho);

                    dadosCadastro dadosCadastro;

                    dadosCadastro.nome = "";
                    dadosCadastro.dataNascimento = new DateTime();
                    dadosCadastro.numDocumento = "";
                    dadosCadastro.nomeRua = "";
                    dadosCadastro.numCasa = 0;
                    

                    foreach (string linha in conteudoArquivo)
                    {
                        if (linha.Contains(delimitadorInicio))
                        {
                            continue;
                        }
                        if (linha.Contains(delimitadorFim))
                        {
                            listaUsuarios.Add(dadosCadastro);
                        }
                        if (linha.Contains(tagNome))
                        {
                            dadosCadastro.nome = linha.Replace(tagNome, "");
                        }
                        if (linha.Contains(tagNacimento))
                        {
                            dadosCadastro.dataNascimento = Convert.ToDateTime(linha.Replace(tagNacimento, ""));
                        }
                        if (linha.Contains(tagNumDocumento))
                        {
                            dadosCadastro.numDocumento = linha.Replace(tagNumDocumento, "");
                        }
                        if (linha.Contains(tagNomeRua))
                        {
                            dadosCadastro.nomeRua = linha.Replace(tagNomeRua, "");
                        }
                        if (linha.Contains(tagNumCasa))
                        {
                            dadosCadastro.numCasa = Convert.ToInt32(linha.Replace(tagNomeRua, ""));
                        }
                    }

                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("EXCESSAO: " + ex.Message);
            }

        }

       



        static void Main(string[] args)
        {

            List<dadosCadastro> Listausuarios = new List<dadosCadastro>();

            string opcao = "";

            delimitadorInicio = "##### INICIO #####";
            tagNome = "NOME: ";
            tagNacimento = "DATA_DE_NASCIMENTO: ";
            tagNomeRua = "NOME_DA_RUA: ";
            tagNumCasa = "NUMERO_DA_CASA: ";
            tagNumDocumento = "NUMERO_DO_DOCUMENTO: ";
            delimitadorFim = "##### FIM #####";
            caminhoArquivo = "baseDeDados.txt";




            carregaDados(caminhoArquivo, ref Listausuarios);

            do
            {
                Console.WriteLine("precione C para cadastrar");
                Console.WriteLine("precione B para buscar");
                Console.WriteLine("precione E para Excluir");
                Console.WriteLine("precione S para Sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (opcao == "c")
                {
                    CadastraUsuario(ref Listausuarios);
                }else if(opcao == "b")
                {
                    buscaUsuarioPeloDoc(Listausuarios);
                }
                else if(opcao == "e")
                {
                    deletaUsuarioPeloDoc(ref Listausuarios);
                }
                else if (opcao == "s")
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
