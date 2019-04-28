using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, multiplicacion=0;
            Console.WriteLine("Ingrese valor para calcular la tabla de multiplicar: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            for(i=0; i<=15; i++)
            {
                multiplicacion = numero * i;
                Console.WriteLine(numero+"x"+i+"="+multiplicacion);
            }
            Console.ReadKey();
        }
    }
}
