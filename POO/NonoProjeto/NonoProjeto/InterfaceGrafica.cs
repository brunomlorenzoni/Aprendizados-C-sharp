using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OitavoProjeto
{
    
    internal class InterfaceGrafica
    {
        public enum resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excessao = 2
        }

        public void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("precione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public resultado_e pegaString(ref string minhaString, string mensagem)
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

        public resultado_e pegaData(ref DateTime data, string mensagem)
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

        // atributo

        BaseDeDados baseDeDados;

        // contrutor

        public InterfaceGrafica(BaseDeDados baseDeDados)
        {

            this.baseDeDados = baseDeDados; 

        }

        // metodos

        public void ImprimiDadosNaTela(CadastroPessoa pessoa)
        {
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Numero do documento: " + pessoa.NumeroDocumento);
            Console.WriteLine("Data de Nascimento: " + pessoa.DataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Numero da Casa: " + pessoa.NumCasa);
            Console.WriteLine("Nome da Rua: " + pessoa.NomeRua);
        }

        public void ImprimiDadosNaTela(List<CadastroPessoa> ListaDePessoas)
        {
            foreach(CadastroPessoa pessoa in ListaDePessoas)
            {
                ImprimiDadosNaTela(pessoa);
            }
        }

        public resultado_e CadastraUsuario()
        {
            Console.Clear();
            string Nome = "";
            string NumeroDocumento = "";
            DateTime DataNascimento = new DateTime();
            string NomeRua = "";
            int NumCasa = 0;

            if(pegaString(ref Nome, "Digite o seu nome completo, ou digite S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaString(ref NumeroDocumento, "Digite o numero do seu documento, ou digite S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaData(ref DataNascimento, "Digite a sua data de nascimento, ou digite S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaString(ref NomeRua, "Digite o nome da sua rua, ou digite S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }
            if (pegaInt(ref NumCasa, "Digite o numero da sua casa, ou digite S para sair") == resultado_e.Sair)
            {
                return resultado_e.Sair;
            }

            CadastroPessoa cadastroUsuario = new CadastroPessoa(Nome, NumeroDocumento, DataNascimento, NumCasa, NomeRua);
            baseDeDados.AdicionaPessoa(cadastroUsuario);
            Console.Clear();
            Console.WriteLine("adicionando usuario: ");
            ImprimiDadosNaTela(cadastroUsuario);
            MostraMensagem("");
            return resultado_e.Sucesso;
                
        }

        public void BuscaUsuario()
        {
            Console.Clear();

            Console.WriteLine("Digite o numero de documento para buscar o usuario ou digite S para sair ");
            string temp = Console.ReadLine();   
            if(temp.ToLower() == "s")
            {
                return;
            }
            else
            {
                List<CadastroPessoa> listaDePessoaTemp = baseDeDados.PesquisaPessoaPorDoc(temp);
                Console.Clear();
                if(listaDePessoaTemp != null)
                {
                    Console.WriteLine("usuario com documento " + temp + " encontrados");
                    ImprimiDadosNaTela(listaDePessoaTemp);
                }
                else
                {
                    Console.WriteLine("nenhum usuario encontrado");
                }
                MostraMensagem("");
            }
        }

        public void RemoveUsuario()
        {
            Console.Clear();

            Console.WriteLine("Digite o numero de documento para remover o usuario ou digite S para sair ");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s")
            {
                return;
            }
            else
            {
                List<CadastroPessoa> listaDePessoaTemp = baseDeDados.ExcluiPessoaPorDoc(temp);
                Console.Clear();
                if (listaDePessoaTemp != null)
                {
                    Console.WriteLine("usuario com documento " + temp + " removido");
                    ImprimiDadosNaTela(listaDePessoaTemp);
                }
                else
                {
                    Console.WriteLine("nenhum usuario encontrado");
                }
                MostraMensagem("");
            }
        }

        public void Sair()
        {
            Console.Clear();
            MostraMensagem("encerrando o programa");
        }

        public void OpcaoDesconhecida()
        {
            Console.Clear();
            MostraMensagem("opção desconhecida");
        }

        public void IniciaInterface()
        {
            string temp;
            do
            {
                Console.WriteLine("Digite C para Cadastrar um ususario");
                Console.WriteLine("Digite B para Buscar um ususario");
                Console.WriteLine("Digite E para Excluir um ususario");
                Console.WriteLine("Digite S para Sair do programa");
                temp = Console.ReadKey().KeyChar.ToString().ToLower();     

                switch(temp)
                {
                    case "c":
                        CadastraUsuario();
                        break;
                    case "b":
                        BuscaUsuario();
                        break;
                    case "e":
                        RemoveUsuario();
                        break;
                    case "s":
                        Sair();
                        break;
                    default:
                        OpcaoDesconhecida();
                        break;
                }



            } while (temp != "s");
        }

    }
}
