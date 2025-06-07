using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_menor_para
{
    class Program
    {
        static int num,mayor= 0,menor= 100000000;
        
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"ingrese el numero {i + 1}");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > mayor) 
                {
                    mayor = num;
                }
                if (num < menor) 
                {
                    menor = num;

                }

            }
            Console.WriteLine($"el mayor numero ingresado fue {mayor}");
            Console.WriteLine($"el  menor numero ingresado fue  {menor}");
            Console.ReadKey();
        }
    }
}
