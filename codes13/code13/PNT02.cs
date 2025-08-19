/*
using System; // Importa el espacio de nombres System para usar clases básicas como Console.
using System.Collections.Generic; // Importa clases para colecciones genéricas (no se usa en este archivo).
using System.Linq; // Importa funcionalidades de LINQ (no se usa en este archivo).
using System.Text; // Importa clases para manipulación de texto (no se usa en este archivo).
using System.Threading.Tasks; // Importa clases para programación asíncrona (no se usa en este archivo).

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT02 // Declara una clase interna llamada PNT02.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            Console.WriteLine("Indique el dia de la semana (ejemplo: lunes):"); // Solicita al usuario que indique un día de la semana.
            string dia = Console.ReadLine().ToLower(); // Lee la entrada del usuario, la convierte a minúsculas y la almacena en la variable 'dia'.

            switch (dia) // Evalúa el valor de la variable 'dia'.
            {
                case "lunes": // Si el día es lunes
                    Console.WriteLine("Debes ir al gimnasio"); // Muestra el mensaje correspondiente.
                    break;
                case "martes": // Si el día es martes
                    Console.WriteLine("Debes estudiar programacion"); // Muestra el mensaje correspondiente.
                    break;
                case "miercoles": // Si el día es miércoles
                    Console.WriteLine("Debes hacer las compras"); // Muestra el mensaje correspondiente.
                    break;
                case "jueves": // Si el día es jueves
                    Console.WriteLine("Debes limpiar la casa"); // Muestra el mensaje correspondiente.
                    break;
                case "viernes": // Si el día es viernes
                    Console.WriteLine("Debes salir a caminar"); // Muestra el mensaje correspondiente.
                    break;
                case "sabado": // Si el día es sábado
                    Console.WriteLine("Debes visitar a la familia"); // Muestra el mensaje correspondiente.
                    break;
                case "domingo": // Si el día es domingo
                    Console.WriteLine("Debes descansar"); // Muestra el mensaje correspondiente.
                    break;
                default: // Si el valor no coincide con ningún caso anterior
                    Console.WriteLine("Dia no valido"); // Informa que el día no es válido.
                    break;
            }
        }
    }
}
*/