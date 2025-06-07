using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prom_20_numeros
{
    class Program
    {
        static int num, acum, cont;
        static double prom;

        static void Main(string[] args)
        {

            acum = 0;
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine($"ingrese el numero {i + 1}");
                num = Convert.ToInt32(Console.ReadLine());
                acum = acum + num;
            }
            prom = acum / 20;
            Console.WriteLine($"el promedio de los 20 numeros es {prom}");

        }
    }
}
