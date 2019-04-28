using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario = 0, horasExtras = 0, salarioHorasExtras = 0, salarioTotal = 0;
            

            Console.WriteLine("¿Desea calcular salario salario? ");
            Console.WriteLine("1-Sí");
            Console.WriteLine("2-No");

            int continuar = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Introduzca número de horas de trabajo: ");
                int horas = Convert.ToInt16(Console.ReadLine());

                if (horas <= 35)
                {
                    salario = horas * 15;
                    Console.WriteLine("**************************************");
                    Console.WriteLine("El salario total es: " + salario);
                    Console.WriteLine("**************************************");
                }
                else
                {
                    horasExtras = horas - 35;
                    salarioHorasExtras = horasExtras * 22;
                    salario = 35 * 15;
                    salarioTotal = salario + salarioHorasExtras;
                    Console.WriteLine("**************************************");
                    Console.WriteLine("El salario total es: " + salarioTotal);
                    Console.WriteLine("**************************************");
                    

                }
                Console.WriteLine("¿Desea calcular salario salario? ");
                Console.WriteLine("1-Sí");
                Console.WriteLine("2-No");

                continuar = Convert.ToInt16(Console.ReadLine());

                Console.ReadKey();

            } while (continuar == 1);
        }
    }
}
