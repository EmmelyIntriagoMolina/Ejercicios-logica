using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmmelyIntriagoTerceroA
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0;

            Console.WriteLine("Ingrese el número total de elementos para la serie: ");
            int n = Convert.ToInt16(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine("Ingrese valor: ");
                int valor = Convert.ToInt16(Console.ReadLine());

                if (valor>mayor)
                {
                    mayor = valor;
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.ReadKey();
        }
    }
}
