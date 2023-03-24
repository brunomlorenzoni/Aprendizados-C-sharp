using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificador_estatico_e_this
{   

    //

    public class Pessoa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public static void ImprimiNome(Pessoa pNome)
        {
            Console.WriteLine("o nome é: " + pNome.nome);
        }

        public Pessoa(string nomeInformado)
        {
            nome = nomeInformado;
        }

    }

    public class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculadoraArea(double RaioInformado)
        {
            return PI * Math.Pow(RaioInformado, 2);
        }
    }


    // palavra this é usado para se se referir aquilo que pertence a nossa classe
    public class MInhaPessoa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public  void ImprimiNome( )
        {
            Console.WriteLine("o nome é: " + nome);
        }

        public MInhaPessoa(string nome)
        {
            this.nome = nome;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // o que não é static pracisa ser instanciado
            Pessoa pessoa1 = new Pessoa("joao");
            Pessoa.ImprimiNome(pessoa1);


            // o que é static não precisa ser isntaciado
            Console.WriteLine("o valor de PI é: "+ Calculadora.PI);
            Console.WriteLine("a area é: " + Calculadora.CalculadoraArea(5));

        }
    }
}
