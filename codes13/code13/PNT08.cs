/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT08 // Declara una clase interna llamada PNT08.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            // Muestra las ubicaciones disponibles y sus precios.
            Console.WriteLine("\nUbicaciones disponibles:\n 1. General ($50.000)\n 2. Platino ($120.000)\n 3. Dorado ($90.000)\n" +
                " 4. VIP ($200.000)\n 5. Palco Estandar ($300.000)\n 6. Palco Platino ($500.000)\n");
            // Solicita al usuario que seleccione el tipo de boleta.
            Console.Write("\nSeleccione el tipo de boleta (1-6): ");
            int opcion = int.Parse(Console.ReadLine()); // Lee la opción seleccionada y la convierte a entero.
            int precio = 0; // Inicializa la variable para el precio total.
            // Solicita la cantidad de boletas.
            Console.WriteLine("Ingrese la cantidad de boletas: ");
            int cantidad = int.Parse(Console.ReadLine()); // Lee la cantidad de boletas y la convierte a entero.

            // Evalúa la opción seleccionada usando switch.
            switch (opcion)
            {
                case 1: // Si la opción es 1 (General)
                    precio = 50000 * cantidad; // Calcula el precio total para General.
                    Console.WriteLine("ubicacion: General, precio por boleta: 50 000, precio total: " + precio); // Muestra el resumen.
                    break;
                case 2: // Si la opción es 2 (Platino)
                    precio = 70000 * cantidad; // Calcula el precio total para Platino (nota: el precio mostrado en el menú es 120.000, pero aquí se usa 70.000).
                    precio *= cantidad; // Multiplica nuevamente por la cantidad (esto es un error, el precio se multiplica dos veces).
                    Console.WriteLine("ubicacion: Platino, precio por boleta: 70 000, precio total: " + precio); // Muestra el resumen.
                    break;
                case 3: // Si la opción es 3 (Dorado)
                    precio = 90000 * cantidad; // Calcula el precio total para Dorado.
                    Console.WriteLine("ubicacion: Dorado, precio por boleta: 90 000, precio total: " + precio); // Muestra el resumen.
                    break;
                case 4: // Si la opción es 4 (VIP)
                    precio = 200000 * cantidad; // Calcula el precio total para VIP.
                    Console.WriteLine("ubicacion: VIP, precio por boleta: 200 000, precio total: " + precio); // Muestra el resumen.
                    break;
                case 5: // Si la opción es 5 (Palco Estandar)
                    precio = 300000 * cantidad; // Calcula el precio total para Palco Estandar.
                    Console.WriteLine("ubicacion: Palco Estandar, precio por boleta: 300 000, precio total: " + precio); // Muestra el resumen.
                    break;
                case 6: // Si la opción es 6 (Palco Platino)
                    precio = 500000 * cantidad; // Calcula el precio total para Palco Platino.
                    Console.WriteLine("ubicacion: Palco Platino, precio por boleta: 500 000, precio total: " + precio); // Muestra el resumen.
                    break;
                default: // Si la opción no es válida
                    Console.WriteLine("Opcion no valida"); // Muestra mensaje de error.
                    return; // Termina la ejecución del programa.
            }
        }
    }
}
*/