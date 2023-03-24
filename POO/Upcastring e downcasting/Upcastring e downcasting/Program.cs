using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcastring_e_downcasting
{
    internal class Program
    {

        // Upcastring = conversao de um objeto da classe filha para um objeto da classe mae


        // Upcastring = conversao de um objeto da classe mae para um objeto da classe filha


        static void Main(string[] args)
        {

            // Upcastring:
            Funcionario funcionario = new Funcionario(10000, "joao");
            Pessoa minhaPessoa = funcionario;
            minhaPessoa.ImprimiNome();


            // Upcastring:
            // nao vai funcionar porque n esta sendo passado o salario para o funcionario
            /*
            Pessoa pessoa = new Pessoa("bruno");
            Funcionario meuFuncionario = (funcionario)pessoa;
            */

            Funcionario meuFuncionario = new Funcionario(1000, "manoel");
            Pessoa pessoa = meuFuncionario;
            Funcionario meuOutroFuncionario = (Funcionario)pessoa;

            meuOutroFuncionario.ImprimiSalario();





            Console.ReadKey();  





        }
    }
}
