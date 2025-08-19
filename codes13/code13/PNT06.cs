
/*using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace code13 
{
    internal class PNT06 // Declara una clase interna llamada PNT06.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            Console.WriteLine("Bienvenido a la tienda de camisetas"); // Muestra mensaje de bienvenida.
            Console.WriteLine("Seleccione el tipo de camiseta:"); // Solicita seleccionar el tipo de camiseta.
            Console.WriteLine("1. Camiseta basica"); // Opción 1: Camiseta básica.
            Console.WriteLine("2. Camiseta estampada"); // Opción 2: Camiseta estampada.
            Console.WriteLine("3. Camiseta deportiva"); // Opción 3: Camiseta deportiva.
            Console.Write("Opcion: "); // Solicita al usuario que ingrese la opción.
            int tipo = int.Parse(Console.ReadLine()); // Lee la opción seleccionada y la convierte a entero.

            double precioUnitario = 0; // Declara la variable para el precio unitario de la camiseta.
            string nombre = ""; // Declara la variable para el nombre de la camiseta.

            switch (tipo) // Evalúa el tipo de camiseta seleccionado.
            {
                case 1: // Si la opción es 1
                    precioUnitario = 12000; // Asigna el precio de la camiseta básica.
                    nombre = "Camiseta basica"; // Asigna el nombre correspondiente.
                    break;
                case 2: // Si la opción es 2
                    precioUnitario = 18000; // Asigna el precio de la camiseta estampada.
                    nombre = "Camiseta estampada"; // Asigna el nombre correspondiente.
                    break;
                case 3: // Si la opción es 3
                    precioUnitario = 25000; // Asigna el precio de la camiseta deportiva.
                    nombre = "Camiseta deportiva"; // Asigna el nombre correspondiente.
                    break;
                default: // Si la opción no es válida
                    Console.WriteLine("Opcion no valida"); // Muestra mensaje de error.
                    return; // Termina la ejecución del programa.
            }

            Console.Write("Ingrese la cantidad (maximo 10): "); // Solicita la cantidad de camisetas.
            int cantidad = int.Parse(Console.ReadLine()); // Lee la cantidad ingresada y la convierte a entero.

            if (cantidad < 1 || cantidad > 10) // Verifica que la cantidad esté en el rango permitido.
            {
                Console.WriteLine("Cantidad no valida. Debe ser entre 1 y 10."); // Muestra mensaje de error si la cantidad no es válida.
                return; // Termina la ejecución del programa.
            }
            double total = precioUnitario * cantidad; // Calcula el precio total multiplicando el precio unitario por la cantidad.
            Console.WriteLine($"Usted selecciono {cantidad} {nombre}(s). Precio final: ${total}"); // Muestra el resumen de la compra y el precio final.
        }
    }
}
*/

