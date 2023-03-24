using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {

        struct dadosCadastrais
        {
            public string nome;
            public string nomeRua;
            public int numeroCada;
            public DateTime dataNascimento; 
        }
        static void Main(string[] args)
        {

            dadosCadastrais[] meuDado = new dadosCadastrais[5];

            dadosCadastrais meuCadastro;

            meuCadastro.nome = "bruno";
            meuCadastro.nomeRua = "sao victor";
            meuCadastro.numeroCada = 121;
            meuCadastro.dataNascimento = Convert.ToDateTime("14/02/2002");


            Console.WriteLine(meuCadastro.nome);
            Console.WriteLine(meuCadastro.nomeRua);
            Console.WriteLine(meuCadastro.numeroCada);
            Console.WriteLine(meuCadastro.dataNascimento.Day + "/" + meuCadastro.dataNascimento.Month + "/" + meuCadastro.dataNascimento.Year);

            Console.ReadKey();


        }
    }
}
