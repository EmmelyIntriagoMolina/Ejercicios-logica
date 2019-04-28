using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el número de asteriscos por lado: ");
            int n = Convert.ToInt16(Console.ReadLine());

            int a, b;

            for(a=0; a <n; a++)
            {

                for (b = 0; b < n; b++)
                {
                    if (a==0||b==0||a==n-1||b==n-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
