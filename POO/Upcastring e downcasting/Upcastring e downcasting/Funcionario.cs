using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcastring_e_downcasting
{
    internal class Funcionario : Pessoa
    {

        private int salario;

        public void ImprimiSalario()
        {
            Console.WriteLine("salario do funcionario é de: " + salario);
        }

        public Funcionario(int salario, string nome): base(nome)
        {
            this.salario = salario;

        }

    }
}
