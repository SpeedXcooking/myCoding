/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13 // Define el espacio de nombres llamado code13.
{
    internal class PNT14 // Declara una clase interna llamada PNT14.
    {
        static void Main(string[] args) // Método principal, punto de entrada del programa.
        {
            // Se pregunta el género mediante número.
            Console.WriteLine("Ingrse su genero segun el numero asignado\n1.Hombre\n2.Mujer\n3.otro");
            // Se guarda la respuesta del usuario.
            int genero = int.Parse(Console.ReadLine());
            // Se inicia el condicional switch para evaluar el género.
            switch (genero)
            {
                // Lo que pasa si se elige el #1 (Hombre)
                case 1:
                    // Se imprime el género.
                    Console.WriteLine("Su genero es hombre");
                    // Se cierra el caso.
                    break;
                // Lo que pasa si se elige el #2 (Mujer)
                case 2:
                    // Se imprime el género.
                    Console.WriteLine("Su genero es mujer");
                    // Se cierra el caso.
                    break;
                // Lo que pasa si se elige el #3 (Otro)
                case 3:
                    // Se pregunta el género personalizado.
                    Console.WriteLine("ingrese su genero");
                    // Se guarda la respuesta.
                    string gen = (Console.ReadLine());
                    // Se imprime el género ingresado.
                    Console.WriteLine("Su genero es " + gen);
                    // Se cierra el caso.
                    break;
                // Si no se cumple ninguna de las anteriores.
                default:
                    // Se imprime un mensaje de error.
                    Console.WriteLine("Por favor vuelva a intentar");
                    // Se cierra el sino.
                    return;
            }
            // Se imprime un mensaje final.
            Console.WriteLine("\nsiga con el cuestionario de la secretaria");

        }
    }
}
*/