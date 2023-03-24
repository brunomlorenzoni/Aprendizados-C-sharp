using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excessao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numero?");
            


            try // tentar
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int resultado = 10 / i;
            }
            catch (DivideByZeroException e) // pegar
            {
                Console.WriteLine("problema de " + e.Message);
            }
            catch (Exception e)  // exessao generica, trata qualquer erro 
            { 
            
            }
            finally // opicioanl == finalmente
            {
                Console.WriteLine("pressione para finalizar");
                Console.ReadKey();
            }


            
        }
    }
}
