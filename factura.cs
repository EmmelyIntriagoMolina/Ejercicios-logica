using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal total;
            Console.WriteLine("Introduzca el número de productos: ");
            int productos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad vendida: ");
            int cantidad = Convert.ToInt16(Console.ReadLine());

            
            Console.WriteLine("Introduzca el precio: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            if ( cantidad == 0)
            {
                Console.WriteLine("No se puede realizar factura");
                Console.WriteLine("**************************************");
            }
            else
            {

                total = cantidad * precio;
                Console.WriteLine("**************************************");
                Console.WriteLine("Cantidad:       "+cantidad);
                Console.WriteLine("Precio:         "+precio);
                Console.WriteLine("Total a pagar:  "+total);
                Console.WriteLine("**************************************");
            }
            
            Console.ReadKey();

        }
    }
}
