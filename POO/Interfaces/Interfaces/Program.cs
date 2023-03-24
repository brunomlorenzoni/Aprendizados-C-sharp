using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta();
            meuCarro.Ligar();
            meuCarro.Desligar();


            Aviao meuAviao = new Aviao();
            meuAviao.AbrirPorta();
            meuAviao.FecharPorta();
            meuAviao.Ligar();
            meuAviao.Desligar();


        }
    }
}
