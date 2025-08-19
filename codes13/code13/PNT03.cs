/*
using System; // Importa el espacio de nombres System para usar clases básicas como Console.
using System.Collections.Generic; // Importa clases para colecciones genéricas (no se usa en este archivo).
using System.Linq; // Importa funcionalidades de LINQ (no se usa en este archivo).
using System.Text; // Importa clases para manipulación de texto (no se usa en este archivo).
using System.Threading.Tasks; // Importa clases para programación asíncrona (no se usa en este archivo).

public static void Main(string[] args) // Método principal, punto de entrada del programa.
{
    // Muestra el menú de postres disponibles para ordenar.
    Console.WriteLine("Buenas tardes, elija su postre de preferecia para ordenar: \n1.pastel de fresa \n2.pastel de vainilla \n3.pastel de chocolate \n4.pastel de helado \n5.pastel de macadamia \n6.pastel de tres leches");

    // Lee la opción seleccionada por el usuario y la convierte a tipo double.
    double opcion = double.Parse(Console.ReadLine());

    // Evalúa la opción seleccionada usando una estructura switch.
    switch (opcion)
    {
        case 1: // Si la opción es 1
            Console.WriteLine("su pastel es de fresa "); // Informa que el pastel es de fresa.
            break;
        case 2: // Si la opción es 2
            Console.WriteLine("su pastel es de vainilla "); // Informa que el pastel es de vainilla.
            break;
        case 3: // Si la opción es 3
            Console.WriteLine("su pastel es de chocolate "); // Informa que el pastel es de chocolate.
            break;
        case 4: // Si la opción es 4
            Console.WriteLine("su pastel es de helado "); // Informa que el pastel es de helado.
            break;
        case 5: // Si la opción es 5
            Console.WriteLine("su pastel es de macadamia"); // Informa que el pastel es de macadamia.
            break;
        case 6: // Si la opción es 6
            Console.WriteLine("su pastel es de tres leches "); // Informa que el pastel es de tres leches.
            break;
    }
}
*/