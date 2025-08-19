
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT12 // Declara una clase interna llamada PNT12.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            Console.WriteLine("Bienvenido a la licorera Equis"); // Muestra mensaje de bienvenida.
            Console.WriteLine("Seleccione el tipo de licor:"); // Solicita seleccionar el tipo de licor.
            Console.WriteLine("1. Ron"); // Opción 1: Ron.
            Console.WriteLine("2. Vodka"); // Opción 2: Vodka.
            Console.WriteLine("3. Whisky"); // Opción 3: Whisky.
            Console.Write("Opcion: "); // Solicita al usuario que ingrese la opción.
            int tipo = int.Parse(Console.ReadLine()); // Lee la opción seleccionada y la convierte a entero.

            string licor = ""; // Declara la variable para almacenar el nombre del licor seleccionado.
            switch (tipo) // Evalúa el tipo de licor seleccionado.
            {
                case 1: // Si la opción es 1
                    licor = "Ron"; // Asigna "Ron" a la variable licor.
                    break;
                case 2: // Si la opción es 2
                    licor = "Vodka"; // Asigna "Vodka" a la variable licor.
                    break;
                case 3: // Si la opción es 3
                    licor = "Whisky"; // Asigna "Whisky" a la variable licor.
                    break;
                default: // Si la opción no es válida
                    Console.WriteLine("Opcion no valida"); // Muestra mensaje de error.
                    return; // Termina la ejecución del programa.
            }

            Console.WriteLine("Seleccione el tamano:"); // Solicita seleccionar el tamaño del licor.
            Console.WriteLine("1. Pequeno"); // Opción 1: Pequeño.
            Console.WriteLine("2. Mediano"); // Opción 2: Mediano.
            Console.WriteLine("3. Grande"); // Opción 3: Grande.
            Console.Write("Opcion: "); // Solicita al usuario que ingrese la opción.
            int tamano = int.Parse(Console.ReadLine()); // Lee la opción de tamaño y la convierte a entero.

            double precio = 0; // Declara la variable para almacenar el precio.
            switch (licor) // Evalúa el tipo de licor seleccionado.
            {
                case "Ron": // Si el licor es Ron
                    switch (tamano) // Evalúa el tamaño seleccionado.
                    {
                        case 1: precio = 15000; break; // Pequeño: 15.000
                        case 2: precio = 25000; break; // Mediano: 25.000
                        case 3: precio = 35000; break; // Grande: 35.000
                        default: Console.WriteLine("Tamano no valido"); return; // Si el tamaño no es válido.
                    }
                    break;
                case "Vodka": // Si el licor es Vodka
                    switch (tamano) // Evalúa el tamaño seleccionado.
                    {
                        case 1: precio = 18000; break; // Pequeño: 18.000
                        case 2: precio = 28000; break; // Mediano: 28.000
                        case 3: precio = 38000; break; // Grande: 38.000
                        default: Console.WriteLine("Tamano no valido"); return; // Si el tamaño no es válido.
                    }
                    break;
                case "Whisky": // Si el licor es Whisky
                    switch (tamano) // Evalúa el tamaño seleccionado.
                    {
                        case 1: precio = 25000; break; // Pequeño: 25.000
                        case 2: precio = 40000; break; // Mediano: 40.000
                        case 3: precio = 60000; break; // Grande: 60.000
                        default: Console.WriteLine("Tamano no valido"); return; // Si el tamaño no es válido.
                    }
                    break;
            }

            Console.WriteLine($"Usted selecciono: {licor}, Tamano: {tamano}, Precio: ${precio}"); // Muestra el resumen de la selección y el precio.
        }
    }
}

