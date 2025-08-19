/*
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT05 // Declara una clase interna llamada PNT05.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            // Solicita al usuario que ingrese la nota del estudiante.
            Console.WriteLine("Ingrese la nota del estudiante (0 a 10):");
            int nota = int.Parse(Console.ReadLine()); // Lee la nota y la convierte a entero.

            // Evalúa la nota usando una estructura switch agrupando los casos.
            switch (nota)
            {
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente"); // Si la nota es 9 o 10.
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Buena"); // Si la nota es 7 u 8.
                    break;
                case 6:
                case 5:
                    Console.WriteLine("Regular"); // Si la nota es 5 o 6.
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Mala"); // Si la nota es de 0 a 4.
                    break;
                default:
                    Console.WriteLine("Nota fuera de rango"); // Si la nota no está entre 0 y 10.
                    break;
            }
        }
    }
}
*/