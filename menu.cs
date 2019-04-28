using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumatoria = 0, factorial = 0, numero = 0;

            Console.WriteLine("Elija el procedimiento que desea realizar ");
            Console.WriteLine("1-Salir");
            Console.WriteLine("2-Sumatorio");
            Console.WriteLine("3-Factorial");

            int continuar = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese un número");
                numero = Convert.ToInt16(Console.ReadLine());

                for (int i=1;i<=numero;i++)
                {
                    sumatoria = sumatoria + i;
                    
                }
                Console.WriteLine(sumatoria);

                Console.WriteLine("Elija el procedimiento que desea realizar ");
                Console.WriteLine("1-Salir");
                Console.WriteLine("2-Sumatorio");
                Console.WriteLine("3-Factorial");

                continuar = Convert.ToInt16(Console.ReadLine());

            } while (continuar == 2);

            do
            {
                Console.WriteLine("Ingrese un número");
                numero = Convert.ToInt16(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    factorial = factorial* i;
                }
                Console.WriteLine(factorial);

                Console.WriteLine("Elija el procedimiento que desea realizar ");
                Console.WriteLine("1-Salir");
                Console.WriteLine("2-Sumatorio");
                Console.WriteLine("3-Factorial");

                continuar = Convert.ToInt16(Console.ReadLine());

            } while (continuar == 3);

        }
            

     }
        
}

