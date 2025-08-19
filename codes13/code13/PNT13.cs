/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT13 // Declara una clase interna llamada PNT13.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            // Muestra el menú de profesores y solicita al usuario que ingrese el número correspondiente.
            Console.WriteLine("Digite el numero del profesor para ver sus horas de trabajo: \n1.Juan \n2.Felipe \n3.Ana \n4.Jhon \n5.Carlos \n6.Juana");
            double opcion = double.Parse(Console.ReadLine()); // Lee la opción seleccionada y la convierte a double.

            switch (opcion) // Evalúa la opción seleccionada usando switch.
            {
                case 1: // Si la opción es 1
                    Console.WriteLine("El profesor Juan trabaja 5 horas "); // Muestra las horas de trabajo de Juan.
                    break;
                case 2: // Si la opción es 2
                    Console.WriteLine("El profesor Felipe trabaja 3 horas "); // Muestra las horas de trabajo de Felipe.
                    break;
                case 3: // Si la opción es 3
                    Console.WriteLine("La profesora Ana trabaja 6 horas "); // Muestra las horas de trabajo de Ana.
                    break;
                case 4: // Si la opción es 4
                    Console.WriteLine("El profesor Jhon trabaja 4 horas "); // Muestra las horas de trabajo de Jhon.
                    break;
                case 5: // Si la opción es 5
                    Console.WriteLine("El profesor Carlos trabaja 5 horas"); // Muestra las horas de trabajo de Carlos.
                    break;
                case 6: // Si la opción es 6
                    Console.WriteLine("La profesora Juana trabaja 3 horas"); // Muestra las horas de trabajo de Juana.
                    break;
            }
        }
    }
}
*/