using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prom_varios.num.mientras
{
    class Program
    {
        static int num;
        static int contador = 0;
        static int acumulador = 0;
        static double promedio;
        static void Main(string[] args)
        {
            Console.WriteLine($"ingrese un numero en el rango de 1 a 100");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0) 
            {
                contador++;
                acumulador = acumulador + num;

                Console.WriteLine("ingrese un numero en el rango de 1 a 100 o presione 0 para finalizar");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (contador == 0)
            {
                Console.WriteLine("no se ingresaron numeros");
            }
            else 
            {
                promedio = (acumulador / contador);
                Console.WriteLine($"la cantidad de numeros ingresados fueron {contador} y el promedio de los numeros {promedio:F2}");
            }
        }
    }
}
