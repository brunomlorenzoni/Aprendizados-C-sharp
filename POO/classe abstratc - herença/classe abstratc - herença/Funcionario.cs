using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_abstratc___herença
{
    internal class Funcionario : Pessoa
    {

        private int salario;

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void MostraSalario()
        {
            Console.WriteLine("salario de: " + salario + Salario);
        }

        public Funcionario(string pNome, int salario): base(pNome)
        {
            this.salario = salario;

        }

    }
}
