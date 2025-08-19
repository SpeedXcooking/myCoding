/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT10 // Declara una clase interna llamada PNT10.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            double med, pul, met, cem, pie = 0; // Declara variables para la medida original y las conversiones.

            // Solicita al usuario que ingrese el valor a convertir.
            Console.WriteLine("Digite el numero a convertir");
            med = double.Parse(Console.ReadLine()); // Lee el valor ingresado y lo convierte a double.

            // Solicita al usuario que elija la unidad de destino.
            Console.WriteLine("Digite a que deceas hacer: \n1.Pulgadas \n2.Metros \n3.Centimetros \n4.Pies\n ");
            int opcion = int.Parse(Console.ReadLine()); // Lee la opción seleccionada y la convierte a entero.

            // Evalúa la opción seleccionada usando switch.
            switch (opcion)
            {
                case 1: // Si la opción es 1 (Pulgadas)
                    pul = med / 25.4; // Convierte la medida a pulgadas.
                    Console.WriteLine("En pulgadas en valor es " + pul); // Muestra el resultado en pulgadas.
                    break;
                case 2: // Si la opción es 2 (Metros)
                    met = med / 1000; // Convierte la medida a metros.
                    Console.WriteLine("En metros el valor es " + met); // Muestra el resultado en metros.
                    break;
                case 3: // Si la opción es 3 (Centímetros)
                    cem = med / 10; // Convierte la medida a centímetros.
                    Console.WriteLine("En centimetros el valor es " + cem); // Muestra el resultado en centímetros.
                    break;
                case 4: // Si la opción es 4 (Pies)
                    pie = med / 304.8; // Convierte la medida a pies.
                    Console.WriteLine("En pies el valor es " + pie); // Muestra el resultado en pies.
                    break;
                default: // Si la opción no es válida
                    Console.WriteLine("incorecto"); // Muestra mensaje de error.
                    return; // Termina la ejecución del programa.
            }
        }

    }
}

*/