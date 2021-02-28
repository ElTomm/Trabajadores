using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            string trabajador;
            int sueldo;
            int hora;
            int total;
            int op;

            do {
                Console.WriteLine("SUELDOS DE LOS TRABAJADORES");
                Console.WriteLine("Ingrese el nombre de trabajador");
                trabajador = Console.ReadLine();

                Console.WriteLine("Ingrese su sueldo por hora");
                sueldo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese las horas trabajadas");
                hora = int.Parse(Console.ReadLine());

                total = sueldo * hora;
                Console.WriteLine("Al trabajador " + trabajador + " debe pagarle de sueldo: " + total);

                Console.WriteLine("¿Desea agregar otro trabajador?");
                Console.WriteLine("SI: escriba 1, NO: escriba 2");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 2){
                    Console.WriteLine("Sueldos Totales registrados");
                }

            } while (op == 1);
            Console.ReadKey();



        }
    }
}
