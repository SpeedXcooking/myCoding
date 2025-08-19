/*
using System; // Importa el espacio de nombres System para usar clases básicas como Console.
using System.Collections.Generic; // Importa clases para colecciones genéricas (no se usa en este archivo).
using System.Linq; // Importa funcionalidades de LINQ (no se usa en este archivo).
using System.Text; // Importa clases para manipulación de texto (no se usa en este archivo).
using System.Threading.Tasks; // Importa clases para programación asíncrona (no se usa en este archivo).

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT04 // Declara una clase interna llamada PNT04.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            // Se pregunta el estado civil al usuario y se muestran las opciones.
            Console.WriteLine("Digite el numero asignado segun su estado civil: \n1 Soltero/a\n2.Casado/a\n3.Divorciado/a " +
                "o viudo/a");

            // Se guarda la respuesta del usuario convirtiéndola a entero.
            int esv = int.Parse(Console.ReadLine());

            // Se inicia una estructura condicional switch para evaluar la respuesta.
            switch (esv)
            {
                // Si elige la opción 1 (Soltero/a)
                case 1:
                    // Se imprime el mensaje correspondiente.
                    Console.WriteLine("Usted va a obtener un auxilio del 30%");
                    break; // Fin del caso 1.

                // Si elige la opción 2 (Casado/a)
                case 2:
                    // Se imprime el mensaje correspondiente.
                    Console.WriteLine("Usted va a obtener un auxilio del 15%");
                    break; // Fin del caso 2.

                // Si elige la opción 3 (Divorciado/a o viudo/a)
                case 3:
                    // Se imprime el mensaje correspondiente.
                    Console.WriteLine("Usted va a obtener un auxilio del 20%");
                    break; // Fin del caso 3.

                // Si no se cumple ningún caso anterior
                default:
                    // Se imprime un mensaje de error.
                    Console.WriteLine("Por favor vuelva a intentar");
                    return; // Termina la ejecución del programa.
            }
        }
    }
}
*/