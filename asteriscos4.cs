using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteriscos4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j=0, l=0;
            Console.WriteLine("Ingrece número de escalones para la pirámide: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            for (i=0; i<numero; i++)
            {
                for (j = i; j<numero; j++)
                {
                    Console.Write(" ");
                }
                for (l = 0; l != i; l++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
