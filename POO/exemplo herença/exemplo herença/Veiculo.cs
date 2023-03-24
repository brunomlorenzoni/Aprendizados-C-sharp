using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_herença
{
    internal class Veiculo
    {
        private int numeroDeRodas;
        private int numeroDePortas;
        private int velocidade;
        private bool estaLigado;


        public int NumeroDeRodas
        {
            get { return numeroDeRodas; }
        }

        public int NumeroDePortas
        {
            get { return numeroDePortas;}

        }

        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; } 
        }

        public bool EstaLigado
        {
            get { return estaLigado; }

        }

        public void Ligar()
        {
            Console.WriteLine("ligando o veiculo"); 
        }

        public void Desligar()
        {
            Console.WriteLine("desligando o veiculo");
        }

        public Veiculo(int numeroDeRodas, int numeroDePortas, int velocidade, bool estaLigado)
        {
            this.numeroDeRodas = numeroDeRodas;
            this.numeroDePortas = numeroDePortas;
            this.velocidade = velocidade;
            this.estaLigado = estaLigado;
        }
    }
}
