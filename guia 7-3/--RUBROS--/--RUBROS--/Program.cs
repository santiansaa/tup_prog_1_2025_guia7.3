using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __RUBROS__
{
    class Program
    {
        static int cont1, cont2, cont3, cont4, cont5, mayorventa;
        static double rcaudaciontt=0, contventas;
        static int venta,producto,cantidad,I=1,dale,r1,r2,r3,r4,r5;
        static int recaud,nombrem;
        static void Main(string[] args)
        {
            Console.WriteLine("QUIERES REALIZAR UNA COMPRA? ( SI -(1)- O NO -(0)-) ");
            venta = Convert.ToInt32(Console.ReadLine());
            
            //iteramos todas las ventas
            while ( venta != 0) 
            {
                contventas++;
                recaud = 0;
                //iteramos cada venta
                Console.WriteLine($"VENTA {I++}");
                    Console.WriteLine("-ELIJA EL PRODRUCTO QUE VA A COMPRAR-");
                    Console.WriteLine("-MOUSE (1) $1000-");
                    Console.WriteLine("-TECLADO (2) $1500-");
                    Console.WriteLine("-MONITOR (3) $3000-");
                    Console.WriteLine("-AURICULARES (4) $2000-");
                    Console.WriteLine("-MICROFONOS (5) $1800-");
                producto = Convert.ToInt32(Console.ReadLine());
                    switch (producto) 
                    {
                        case 1:
                            cont1++;
                            Console.WriteLine($"--CUANTOS QUIERES?--");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                        r1 = (cantidad * 1000);
                        recaud = r1;
                        rcaudaciontt = rcaudaciontt + r1;
                            break;
                        case 2:
                            cont2++;
                            Console.WriteLine($"--CUANTOS QUIERES?--");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                        r2 = (cantidad * 1500);
                        recaud = r2;
                        rcaudaciontt = rcaudaciontt + r2;
                        break;
                        case 3:
                            cont3++;
                            Console.WriteLine($"--CUANTOS QUIERES?--");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                        r3 = (cantidad * 3000);
                        recaud = r3;
                        rcaudaciontt = rcaudaciontt + r3;
                        break;
                        case 4:
                            cont4++;
                            Console.WriteLine($"--CUANTOS QUIERES?--");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                        r4 = (cantidad * 2000);
                        recaud = r4;
                        rcaudaciontt = rcaudaciontt + r4;
                        break;
                        case 5:
                            cont5++;
                            Console.WriteLine($"--CUANTOS QUIERES?--");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                        r5 = (cantidad * 1800);
                        recaud = r5;
                        rcaudaciontt = rcaudaciontt + r5;
                        break;
                        default:
                            Console.WriteLine("ingrese un numero valido");
                            producto = Convert.ToInt32(Console.ReadLine());
                            break;


                    }
                if (contventas == 1) 
                {
                    mayorventa = recaud;
                    nombrem=(int)contventas;
                }
                if ( recaud>mayorventa) 
                {
                    mayorventa = recaud;
                    nombrem =(int)contventas;
                }              
                    Console.WriteLine("QUIERE SEGUIR CON LA SIGUIENTE VENTA? ( SI -(1)- O NO -(0)-)");
                venta = Convert.ToInt32(Console.ReadLine());



            }
            
            double porc1, porc2, porc3, porc4, porc5;
            porc1 = (cont1 / contventas) * 100;
            porc2 = (cont2 / contventas) * 100;
            porc3 = (cont3 / contventas) * 100;
            porc4 = (cont4 / contventas) * 100;
            porc5 = (cont5 / contventas) * 100;
            Console.WriteLine($"LA CANTIDAD DE VENTAS FUERON {contventas}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"--EL PORCENTAJE DE VENTAS DE MOUSE ES DE {porc1:f2}%");
            Console.WriteLine($"--EL PORCENTAJE DE VENTAS DE TECLADO ES DE {porc2:f2}%");
            Console.WriteLine($"--EL PORCENTAJE DE VENTAS DE MONITOR ES DE {porc3:f2}%");
            Console.WriteLine($"--EL PORCENTAJE DE VENTAS DE AURICULARES ES DE {porc4:f2}%");
            Console.WriteLine($"--EL PORCENTAJE DE VENTAS DE MICROFONOS ES DE {porc5:f2}%");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"LA VENTA CON MAYOR MONTOTAL ES LA VENTA {nombrem} CON EL MONTO {mayorventa}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"LA RECAUDACION TOTAL ES DE ${rcaudaciontt}");
            Console.ReadKey();
        }
    }
}
