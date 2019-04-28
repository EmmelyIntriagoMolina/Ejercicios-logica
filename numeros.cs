using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador1 = 1, contador2=100 ;
            do
            {
                Console.WriteLine(contador1 + "   " + contador2);
                contador1 = contador1 + 1;
                contador2 = contador2 - 1;

            } while (contador1 <= 100 && contador2 >= 1);      

            
            Console.ReadKey();
        }
    }
}
