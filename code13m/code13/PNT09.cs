/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13
{
    internal class PNT09
    {
        static void Main(string[] args)
        {
            string nm;
            int ident, edad, vh = 0;
            double coems;
            Console.WriteLine("Ingrese su nombre");
            nm = (Console.ReadLine());
            Console.WriteLine("ingrse su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su cedula");
            ident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el tamaño de su vehiculo:\n1(moto)\n2(carros) \n3(camion) \n ");
            vh =  Convert.ToInt32(Console.ReadLine());
            switch (vh)
            {
                case 1:
                    coems = 6000;
                    Console.WriteLine("Tu vehiculo es moto y pagas " + coems);
                    break;

                case 2:
                    coems = 15000;
                    Console.WriteLine("Tu vehiculo es un carro y pagas " + coems);

                    break;

                case 3:
                    coems = 16000;
                    Console.WriteLine("Tu vehiculo es un camion y pagas " + coems);

                    break;
                default:
                    Console.WriteLine("incorrecto");
                return;
            }
        }
    }
}
*/