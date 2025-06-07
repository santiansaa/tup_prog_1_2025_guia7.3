using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rubros
{
    class Program
    {
        static int contadorv= 1,compra,producto,num,montoactual,mayorventa=0,recaudaciontt;
        static int cantidadttchoco=0, cantidadttcaramelo=0, cantidadtthelad=0, cantidadttcoca=0;
        static int contchoco=0, contcara=0, conthela=0, contcoca=0;
        static int mchoco,mcara,mhela,mcoca;
        static int acumtchoco, acumtcara, acumthela, acumtcoca;

        static double pchocolate, pcaramelo, phelado, pcocacola,sumat;
        static void Main(string[] args)
        {
            Console.WriteLine("quiere realizar una compra? (-1- para seguir -0- para finalizar)");
            compra = Convert.ToInt32(Console.ReadLine());
            while (compra != 0) 
            {
                Console.WriteLine($"¿que producto vas a comprar? -VENTA-{contadorv}");
                Console.WriteLine("-1- chocolate -$100-");
                Console.WriteLine("-2- caramelos-$50-");
                Console.WriteLine("-3- helado-$150-");
                Console.WriteLine("-4- cocacola-$200-");
                producto = Convert.ToInt32(Console.ReadLine());
                switch (producto) 
                {
                    case 1:

                        contadorv++;
                        contchoco++;
                        Console.WriteLine("¿cuantos chocolates quieres?");
                        num = Convert.ToInt32(Console.ReadLine());
                        mchoco = num * 100;
                        montoactual = mchoco;
                        cantidadttchoco = cantidadttchoco + num;
                        acumtchoco = acumtchoco + mchoco;
                            break;
                    case 2:
                        contadorv++;
                        contcara++;
                        Console.WriteLine("¿cuantos caramelos quieres?");
                        num = Convert.ToInt32(Console.ReadLine());
                        mcara = num * 50;
                        montoactual = mcara;
                        cantidadttcaramelo = cantidadttcaramelo + num;
                        acumtcara = acumtcara + mcara;
                        break;
                    case 3:
                        contadorv++;
                        conthela++;
                        Console.WriteLine("¿cuantos helados quieres?");
                        num = Convert.ToInt32(Console.ReadLine());               
                        mhela = num * 150;
                        montoactual = mhela;
                        cantidadtthelad = cantidadtthelad + num;
                        acumthela = acumthela + mhela;
                        break;
                    case 4:
                        contadorv++;
                        contcoca++;
                        Console.WriteLine("¿cuantas coca colas quieres?");
                        num = Convert.ToInt32(Console.ReadLine());
                        mcoca = num * 200;                      
                        montoactual = mcoca;
                        cantidadttcoca = cantidadttcoca + num;
                        acumtcoca = acumtcoca + mcoca;
                        break;
                    default:
                        Console.WriteLine("el producto que quiere no existe elije otro");
                        producto = Convert.ToInt32(Console.ReadLine());
                        break;                                       
                }

                if (montoactual > mayorventa) 
                {
                    mayorventa = montoactual;
                }

                Console.WriteLine("quiere seguir comprando ? ( -1- para seguir , -0- para finalizar");
                compra = Convert.ToInt32(Console.ReadLine());
            }
            
           
            
           
            
                sumat = (cantidadttchoco + cantidadttcaramelo + cantidadtthelad + cantidadttcoca);
                pchocolate=(cantidadttchoco/sumat ) *100;
                pcaramelo = (cantidadttcaramelo / sumat) * 100;
                phelado = (cantidadtthelad / sumat) * 100;
                pcocacola = (cantidadttcoca / sumat) * 100;
                recaudaciontt = (acumtcoca + acumtcara + acumthela + acumtcoca);

                 Console.WriteLine($"la cantidad de ventas fueron {contadorv}");
                
                Console.WriteLine($"el porcentaje de ventas de chocolate fue {pchocolate:F2}%");
                Console.WriteLine($"el porcentaje de ventas de caramelos fue {pcaramelo:F2}%");
                Console.WriteLine($"el porcentaje de ventas de helados fue {phelado:F2} %");
                Console.WriteLine($"el porcentaje de ventas de coca colas fue {pcocacola:F2}%");

                Console.WriteLine($"el numero de ventas con mayor monto total fue ${mayorventa}");

                Console.WriteLine($" la recaudacion total fue  ${recaudaciontt}");

           
        }
    }
}
