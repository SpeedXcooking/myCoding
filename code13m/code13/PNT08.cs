/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13
{
    internal class PNT08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nUbicaciones disponibles:\n 1. General ($50.000)\n 2. Platino ($120.000)\n 3. Dorado ($90.000)\n"+
                " 4. VIP ($200.000)\n 5. Palco Estandar ($300.000)\n 6. Palco Platino ($500.000)\n");
            Console.Write("\nSeleccione el tipo de boleta (1-6): ");
            int opcion = int.Parse(Console.ReadLine());
            int precio = 0;
            Console.WriteLine("Ingrese la cantidad de boletas: ");
            int cantidad = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    precio = 50000 * cantidad;
                    Console.WriteLine("ubicacion: General, precio por boleta: 50 000, precio total: " + precio);
                    break;
                case 2:
                    precio = 70000 * cantidad;
                    precio *= cantidad;
                    Console.WriteLine("ubicacion: Platino, precio por boleta: 70 000, precio total: " + precio);
                    break;
                case 3:

                    precio = 90000 * cantidad;
                    Console.WriteLine("ubicacion: Dorado, precio por boleta: 90 000, precio total: " + precio);
                    break;
                case 4:
                    precio = 200000 * cantidad;
                    Console.WriteLine("ubicacion: VIP, precio por boleta: 200 000, precio total: " + precio);
                    break;
                case 5:
                    precio = 300000 * cantidad;
                    Console.WriteLine("ubicacion: Palco Estandar, precio por boleta: 300 000, precio total: " + precio);
                    break;
                case 6:
                    precio = 500000 * cantidad;
                    Console.WriteLine("ubicacion: Palco Platino, precio por boleta: 500 000, precio total: "  + precio);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    return;
            }
        }
    }
*/