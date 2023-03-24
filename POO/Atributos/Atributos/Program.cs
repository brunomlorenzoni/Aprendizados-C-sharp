using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{

    public class Carro
    {
        // criando atributo

        public string marca;
        private double velocidade = 0;
        private bool carroLigado = false;

        // atributos
        // get é usado para retornar o conteudo do atributo
        // set é usando para alterar o conteudo do atributo

        public bool CarroLigado
        {
            get { return CarroLigado; }
            set 
            { 
                if(velocidade == 0)
                {
                    carroLigado = value;
                }
                else
                {
                    return;
                }
                
            }
        }

        public double Velocidade
        {
            get { return velocidade; }
            set 
            { 
                if(carroLigado == true)
                {
                    velocidade = value;
                }
                else
                {
                    return;
                }
                
            }
        }




        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade = VelocidadeFinal;     
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro();  

            carro.CarroLigado = true;
            carro.Velocidade = 100;
            carro.CarroLigado = false;

        }
    }
}
