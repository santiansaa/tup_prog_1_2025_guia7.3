using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_y_mayor_centinela
{
    class Program
    {
        static int num,cont;
        static double mayor = 0, menor = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero en el rango de 1 a 100");
            num = Convert.ToInt32(Console.ReadLine());
            cont = 1;
            mayor = num;
            menor = num;

            while (num != 0) 
            {
                cont++;
                if (num > mayor) 
                {
                    mayor = num;
                }
                if (num < menor) 
                {
                    menor = num;
                }
                Console.WriteLine("ingrese un numero de 1 a 100 o 0 para finalizar");
                num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"la cantidad de numeros ingresados fueron {cont}");
            Console.WriteLine($"el mayor numero ingreasdo fue {mayor}");
            Console.WriteLine($"el menor numero ingresado fue {menor}");
            Console.ReadKey();
        }

    }
}
