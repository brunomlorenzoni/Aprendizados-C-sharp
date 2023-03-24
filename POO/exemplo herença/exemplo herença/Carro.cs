using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_herença
{
    internal class Carro: Veiculo
    {
        public void Acelerar(int velocidade)
        {
            if (EstaLigado == true)
            {
                Console.WriteLine("Carro acelerando...");
                Velocidade = velocidade;
                Console.WriteLine("velocidade do carro: " + Velocidade);

            }
            else
            {
                Console.WriteLine("o carro não esta ligado");
            }
        }

        public void Bracar()
        {
            Console.WriteLine("Carro brecando...");
            Velocidade = 0;
            Console.WriteLine("velocidade do carro: " + 0);
        }

        public Carro(int numeroRodas, int numeroPortas): base(numeroRodas, numeroPortas)
        {

        }

    }
}
