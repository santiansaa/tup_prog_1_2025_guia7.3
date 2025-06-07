using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZ_
{
    class Program
    {
        static int numg,valores,acumporgrupo,acumttgrupos,mayor=0,grupomayor;
        static void Main(string[] args)
        {

            Console.WriteLine("cuantos grupos van a ser?");
            numg = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numg; i++)
            {
                acumporgrupo = 0;

                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"ingrese los valores de 1 a 10 del grupo {i + 1}");
                    valores = Convert.ToInt32(Console.ReadLine());
                    acumporgrupo = acumporgrupo + valores;
                }
                if (acumporgrupo > mayor)
                {
                    mayor = acumporgrupo;
                    grupomayor = i;
                }
                acumttgrupos = acumttgrupos + acumporgrupo;


            }
            Console.WriteLine($"el mayor grupo es {grupomayor} con {mayor}");

        }    }   }


