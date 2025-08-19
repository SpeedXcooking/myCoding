/*
using System; // Importa el espacio de nombres System para usar clases básicas como Console.
using System.Collections.Generic; // Importa clases para colecciones genéricas (no se usa en este archivo).
using System.Linq; // Importa funcionalidades de LINQ (no se usa en este archivo).
using System.Text; // Importa clases para manipulación de texto (no se usa en este archivo).
using System.Threading.Tasks; // Importa clases para programación asíncrona (no se usa en este archivo).

namespace code13 // Define un espacio de nombres llamado code13.
{
    internal class PNT12 // Declara una clase interna llamada PNT12.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            Console.WriteLine("Calculadora simple"); // Muestra el título de la calculadora.

            Console.Write("Ingrese el primer numero: "); // Solicita el primer número al usuario.
            double num1 = double.Parse(Console.ReadLine()); // Lee y convierte el primer número a double.

            Console.Write("Ingrese el segundo numero: "); // Solicita el segundo número al usuario.
            double num2 = double.Parse(Console.ReadLine()); // Lee y convierte el segundo número a double.

            Console.WriteLine("Seleccione la operacion:"); // Muestra el menú de operaciones.
            Console.WriteLine("1. Sumar"); // Opción de suma.
            Console.WriteLine("2. Restar"); // Opción de resta.
            Console.WriteLine("3. Multiplicar"); // Opción de multiplicación.
            Console.WriteLine("4. Dividir"); // Opción de división.
            Console.Write("Opcion: "); // Solicita la opción al usuario.
            int opcion = int.Parse(Console.ReadLine()); // Lee y convierte la opción seleccionada a entero.

            double resultado = 0; // Declara la variable para almacenar el resultado.
            bool operacionValida = true; // Bandera para verificar si la operación es válida.

            switch (opcion) // Evalúa la opción seleccionada.
            {
                case 1: // Si la opción es 1 (sumar)
                    resultado = num1 + num2; // Suma los números.
                    break;
                case 2: // Si la opción es 2 (restar)
                    resultado = num1 - num2; // Resta los números.
                    break;
                case 3: // Si la opción es 3 (multiplicar)
                    resultado = num1 * num2; // Multiplica los números.
                    break;
                case 4: // Si la opción es 4 (dividir)
                    if (num2 != 0) // Verifica que el divisor no sea cero.
                    {
                        resultado = num1 / num2; // Divide los números.
                    }
                    else // Si el divisor es cero
                    {
                        Console.WriteLine("No se puede dividir por cero."); // Muestra mensaje de error.
                        operacionValida = false; // Marca la operación como no válida.
                    }
                    break;
                default: // Si la opción no es válida
                    Console.WriteLine("Opcion no valida."); // Muestra mensaje de error.
                    operacionValida = false; // Marca la operación como no válida.
                    break;
            }

            if (operacionValida) // Si la operación fue válida
            {
                Console.WriteLine($"El resultado es: {resultado}"); // Muestra el resultado.
            }
        }
    }
}
*/