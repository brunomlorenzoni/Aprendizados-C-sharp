using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Carro : IVeiculo
    {
        public void AbrirPorta()
        {
            Console.WriteLine("A porta do carro esta aberta");
        }

        public void Desligar()
        {
            Console.WriteLine("O carro esta Desligado");
        }

        public void FecharPorta()
        {
            Console.WriteLine("A porta do carro esta fechada");
        }

        public void Ligar()
        {
            Console.WriteLine("O carro esta ligado");
        }
    }
}
