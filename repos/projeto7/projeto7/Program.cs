using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime data = new DateTime(2002, 02, 14);
            DateTime datahora = new DateTime(2006, 04, 14, 14, 12, 45);

            //data.Year = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("dia da semana " + datahora.DayOfWeek);

            Console.WriteLine(data.ToString());
            Console.WriteLine(datahora.ToString());

            // pegando a data e horario atual

            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual.ToString());

            // converter string em dateTime

            DateTime dataConvertida = Convert.ToDateTime("22/11/2023 14:12:59");
            Console.WriteLine(dataConvertida.ToString());

            // formatando a data e hora impressa

            Console.WriteLine(dataConvertida.ToString("yyyy/MMMM/dddd"));
            Console.WriteLine(dataConvertida.ToString("HH:mm:ss"));

            // operacoes usando datetime

            DateTime dataHora2 = new DateTime(2023, 09, 27, 14, 05, 20);

            dataHora2 = dataHora2.AddDays(4);
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));
            dataHora2 = dataHora2.AddYears(4);
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));
            dataHora2 = dataHora2.AddMonths(4);
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));
            Console.WriteLine(dataHora2.ToString("HH:mm:ss"));
            dataHora2 = dataHora2.Add(new TimeSpan(1, 55, 30));
            Console.WriteLine(dataHora2.ToString("HH:mm:ss"));
            Console.ReadKey();
        }
    }
}
