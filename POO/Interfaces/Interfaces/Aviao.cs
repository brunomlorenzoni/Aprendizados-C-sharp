using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aviao : IVeiculo
    {
        public void AbrirPorta()
        {
            Console.WriteLine("A porta do aviao esta aberta");
        }

        public void Desligar()
        {
            Console.WriteLine("O aviao esta Desligado");
        }

        public void FecharPorta()
        {
            Console.WriteLine("A porta do aviao esta fechada");
        }

        public void Ligar()
        {
            Console.WriteLine("O aviao esta ligado");
        }
    }
}
