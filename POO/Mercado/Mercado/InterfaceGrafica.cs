using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    internal class InterfaceGrafica
    {

        public void CriaUsuario()
        {
            Console.Clear();
            string Nome = "";
            string Senha = "";
            int id = 0;

            Console.WriteLine("informe o nome do usuario: ");
            Nome = Console.ReadLine();

            Console.WriteLine("informe a senha do usuario: ");
            Senha = Console.ReadLine();

            id++;

            CadastroUsuario cadastroPessoa = new CadastroUsuario(Nome, Senha, id);  
            


        }

        public void IniciaInterface()
        {
            string escolha;
            do
            {
                Console.WriteLine("precione C para cadastrar um novo Usuario");
                Console.WriteLine("precione S para sair do programa");
                escolha = Console.ReadKey().KeyChar.ToString().ToLower();

                switch(escolha)
                {
                    case "c":
                        CriaUsuario();
                        break;

                    case "s":
                        break;
                }


            } while (escolha != "s");
        }
    }
}
