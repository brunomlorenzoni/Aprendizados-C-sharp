using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_uma_Classe
{

    public class ContaBancaria
    {
        private double saldo;
        private string senha;
        private string nomeDoCliente;

        public double Sacar(double valorSacado, string senhaDigitada)
        {
            if(senha == senhaDigitada)
            {
                if(saldo > valorSacado) 
                {
                    saldo -= valorSacado;
                    Console.WriteLine("valor sacado de: " + valorSacado);
                    return valorSacado;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente na conta");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return 0;
            }
        }

        public void Depositar(double valorDepositado)
        {
            Console.WriteLine("valor depositado de: " + valorDepositado);
            saldo += valorDepositado;
        }

        public void consultaSaldo(string senhaDigitada)
        {

            if(senhaDigitada == senha)
            {
                Console.WriteLine("Saldo disponivel na conta de: " + saldo);
            }
            else
            {
                Console.WriteLine("Senha incorreta");
            }
            
        }

        // classe construtora
        public ContaBancaria(string Csenha, string CnomeCliente)
        {
            saldo = 0;
            senha = Csenha;
            nomeDoCliente = CnomeCliente;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            ContaBancaria contaPedro = new ContaBancaria("12345", "bruno");

            double valorSacado = contaPedro.Sacar(10, "12345");
            contaPedro.Depositar(1000);
            contaPedro.consultaSaldo("12345");


            Console.ReadKey();
            
        }
    }
}
