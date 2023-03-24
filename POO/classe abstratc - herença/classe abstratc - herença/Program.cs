using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_abstratc___herença
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario pessoa = new Funcionario("joao", 1000);
            pessoa.MostraNome();
            pessoa.MostraSalario();


        }
    }
}
