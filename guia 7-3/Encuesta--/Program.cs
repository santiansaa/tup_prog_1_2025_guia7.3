using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Encuesta__
{
    class Program
    {
        static int num,num1, cont0, cont1, cont2, contencuestas;
        static double opi0, opi1, opi2;
        static void Main(string[] args)
        {
            cont0 = 0;
            cont1 = 0;
            cont2 = 0;
            contencuestas = 0;

            Console.WriteLine("quieres realizar la encuesta? ( 1 para seguir o - 1 si no quieres)");
            num = Convert.ToInt32(Console.ReadLine());
            
            while (num != -1)
            {
                Console.WriteLine("INICIAMOS ENCUESTA");
                Console.WriteLine("que opinion tuvo sobre la encuesta?");
                Console.WriteLine("positiva marque ( 0 )");
                Console.WriteLine("negativa marque ( 1 )");
                Console.WriteLine("indecisa marque ( 2 )");
                num1 = Convert.ToInt32(Console.ReadLine());
                switch (num1)
                {
                    case 0:
                        cont0++;
                        contencuestas++;
                        break;
                    case 1:
                        cont1++;
                        contencuestas++;
                        break;
                    case 2:
                        cont2++;
                        contencuestas++;
                        break;
                    default:
                        Console.WriteLine("ingrese un numero valido");
                        break;
                                                
                }
                Console.WriteLine("quiere realizar otra encuesta ( 1 para seguir o -1 para finalizar)");
                num = Convert.ToInt32(Console.ReadLine());


            }
            if (contencuestas == 0)
            {
                Console.WriteLine("no se realizaron encuestas");
            }
            else 
            {
                Console.WriteLine($"la cantidad de encuestados fueron {contencuestas}");
                opi0 = ((double)cont0 /contencuestas)*100;
                opi1 = ((double)cont1 / contencuestas)* 100;
                opi2 = ((double)cont2 / contencuestas)* 100;
                Console.WriteLine("porcentaje de opiniones");
                Console.WriteLine($"el porcentaje de positivos fue {opi0}%");
                Console.WriteLine($"el porcentaje de negativos fue {opi1}%");
                Console.WriteLine($"el porcentaje de indecisos fue {opi2}%");

                Console.WriteLine($"la cantidad de positivos {cont0}");
                Console.WriteLine($"la cantidad de negativos {cont1}");
                Console.WriteLine($"la cantidad de indecisos {cont2}");


            }


        }

    }
}
