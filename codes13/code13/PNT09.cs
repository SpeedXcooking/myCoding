/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT09 // Declara una clase interna llamada PNT09.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            string nm; // Declara una variable para el nombre.
            int ident, edad, vh = 0; // Declara variables para la cédula, edad y tipo de vehículo.
            double coems; // Declara una variable para el costo a pagar.

            Console.WriteLine("Ingrese su nombre"); // Solicita al usuario su nombre.
            nm = (Console.ReadLine()); // Lee el nombre ingresado.

            Console.WriteLine("ingrse su edad"); // Solicita la edad.
            edad = int.Parse(Console.ReadLine()); // Lee la edad y la convierte a entero.

            Console.WriteLine("ingrese su cedula"); // Solicita la cédula.
            ident = Convert.ToInt32(Console.ReadLine()); // Lee la cédula y la convierte a entero.

            Console.WriteLine("ingrese el tamaño de su vehiculo:\n1(moto)\n2(carros) \n3(camion) \n "); // Solicita el tipo de vehículo.
            vh = Convert.ToInt32(Console.ReadLine()); // Lee la opción seleccionada y la convierte a entero.

            switch (vh) // Evalúa el tipo de vehículo seleccionado.
            {
                case 1: // Si la opción es 1 (moto)
                    coems = 6000; // Asigna el valor a pagar para moto.
                    Console.WriteLine("Tu vehiculo es moto y pagas " + coems); // Muestra el mensaje correspondiente.
                    break;

                case 2: // Si la opción es 2 (carro)
                    coems = 15000; // Asigna el valor a pagar para carro.
                    Console.WriteLine("Tu vehiculo es un carro y pagas " + coems); // Muestra el mensaje correspondiente.
                    break;

                case 3: // Si la opción es 3 (camión)
                    coems = 16000; // Asigna el valor a pagar para camión.
                    Console.WriteLine("Tu vehiculo es un camion y pagas " + coems); // Muestra el mensaje correspondiente.
                    break;

                default: // Si la opción no es válida
                    Console.WriteLine("incorrecto"); // Muestra mensaje de error.
                    return; // Termina la ejecución del programa.
            }
        }
    }
}

*/