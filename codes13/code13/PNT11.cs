/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT11 // Declara una clase interna llamada PNT11.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            double ef, bon, td, tc = 0; // Declara variables para los totales según el método de pago.

            Console.WriteLine("cuantos elementos esta comprando"); // Solicita al usuario la cantidad de productos.
            int com = int.Parse(Console.ReadLine()); // Lee la cantidad de productos y la convierte a entero.

            Console.WriteLine("cuanto cuesta en promedio cada producto"); // Solicita el precio promedio de cada producto.
            int pag = int.Parse(Console.ReadLine()); // Lee el precio promedio y lo convierte a entero.

            Console.WriteLine("elija la forma de pago: \n1.efectivo \n2.bono \n3.tarjeta debito \n4.tarjeta de credit\n"); // Solicita el método de pago.
            double opcion = double.Parse(Console.ReadLine()); // Lee la opción seleccionada y la convierte a double.

            switch (opcion) // Evalúa el método de pago seleccionado.
            {
                case 1: // Si la opción es 1 (efectivo)
                    ef = com * pag; // Calcula el total a pagar en efectivo.
                    Console.WriteLine("su total a pagar es " + ef); // Muestra el total a pagar.
                    break;
                case 2: // Si la opción es 2 (bono)
                    bon = com * pag; // Calcula el total a pagar con bono.
                    Console.WriteLine("su total a pagar es " + bon); // Muestra el total a pagar.
                    break;
                case 3: // Si la opción es 3 (tarjeta débito)
                    td = com * pag; // Calcula el total a pagar con tarjeta débito.
                    Console.WriteLine("su total a pagar es " + td); // Muestra el total a pagar.
                    break;
                case 4: // Si la opción es 4 (tarjeta de crédito)
                    tc = com * pag; // Calcula el total a pagar con tarjeta de crédito.
                    Console.WriteLine("su total a pagar es " + tc); // Muestra el total a pagar.
                    break;
                default: // Si la opción no es válida
                    Console.WriteLine("incorecto"); // Muestra mensaje de error.
                    return; // Termina la ejecución del programa.
            }

        }
    }
}

*/