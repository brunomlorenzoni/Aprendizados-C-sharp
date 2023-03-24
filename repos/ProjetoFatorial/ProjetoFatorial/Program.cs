using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Digite S para sair ou um numero para calcular o fatorial!!");
                string opcao = Console.ReadLine();

                if (opcao == "s" || opcao == "S")
                {
                    break;
                }
                else
                {
                    int valor = Convert.ToInt32(opcao);
                    if (valor == 0)
                    {
                        Console.WriteLine("Fatorial de 0 é 1 ");
                    }
                    else if (valor < 0)
                    {
                        Console.WriteLine("Imporssivel fazer o fatorial de um numero negativo");
                    }
                    else
                    {
                        int resultado = 1;
                        Console.Write(valor + "! = ");
                        for(int i = valor; i> 0;  i--)
                        { 
                             resultado *= i;
                            if (i == 1)
                            {
                                Console.WriteLine( i + " = " + resultado);
                            }
                            else
                            {
                                Console.Write(i + "x");
                            }
                        } 

                    }
                    Console.WriteLine("precione qualque tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
                 
            }
            Console.WriteLine("pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
