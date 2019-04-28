using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador1 = 1, contador2 = 2, contador3 = 3;
            Console.WriteLine("Ingrece un número: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.WriteLine(contador1+"   "+contador2+"   "+contador3+"   ");
                contador1 = contador1 + 1;
                contador2 = contador2 + 2;
                contador3 = contador3 + 3;

            } while (contador1<=numero || (contador2<=numero && contador3<=numero));

            Console.ReadKey();
        }
    }
}
