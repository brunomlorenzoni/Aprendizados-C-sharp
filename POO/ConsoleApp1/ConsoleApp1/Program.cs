using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace ConsoleApp1
{
    public class Carro
    {
        // atributos e variaveis

        private string marca;
        private string modelo;
        private int velocidade;
        private bool carroLigado;

        // propriedades

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool CarroLidago 
        {
            get { return carroLigado; }
            set { carroLigado = value; }
        }

        // metodos

        public void LigarCarro()
        {
            carroLigado = true;
            Console.WriteLine("Ligando o Carro da marca" + marca + "e do modelo" + modelo);
        }
        public void DesligaCarro()
        {
            carroLigado = true;
            Console.WriteLine("Desligando o Carro da marca" + marca + "e do modelo" + modelo);
        }

        public void AcelerarCarro(int velocidadeFinal)
        {
            if(carroLigado == true)
            {
                velocidade = velocidadeFinal;
                Console.WriteLine("A velocidade do Carro da marca" + marca + "e do modelo" + modelo + " é " + velocidade);
            }
            else
            {
                Console.WriteLine("O Carro da marca" + marca + "e do modelo" + modelo + " esta desligado ");
            }
            
        }

        public void PararCarro() 
        { 
            if(velocidade == 0)
            {

                Console.WriteLine("O Carro da marca" + marca + "e do modelo" + modelo + " ja esta parado");
            }
            else
            {
                velocidade = 0;
                Console.WriteLine("O Carro da marca" + marca + "e do modelo" + modelo + " esta parado ");
            }
            
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro hondaFit = new Carro();
            hondaFit.Marca = "Honda";
            hondaFit.Modelo = "FIT";
            hondaFit.LigarCarro();
            hondaFit.AcelerarCarro(80);
            hondaFit.PararCarro();  
            hondaFit.DesligaCarro();

            Carro fiatUNO = new Carro();
            fiatUNO.Marca = "fiat";
            fiatUNO.Modelo = "UNO";

            fiatUNO.AcelerarCarro(80);
            fiatUNO.LigarCarro();
            fiatUNO.AcelerarCarro(80);
            fiatUNO.PararCarro();
            fiatUNO.DesligaCarro();


            Console.ReadKey();
        }
    }
}
