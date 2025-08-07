/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13
{
    internal class PNT10
    {
        static void Main(string[] args)
        {
            double med, pul, met, cem, pie = 0;


            Console.WriteLine("Digite el numero a convertir");
            med = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a que deceas hacer: \n1.Pulgadas \n2.Metros \n3.Centimetros \n4.Pies\n ");
            int opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {

                case 1:
                    pul = med / 25.4;
                    Console.WriteLine("En pulgadas en valor es " + pul);
                    break;
                case 2:
                    met = med / 1000;
                    Console.WriteLine("En metros el valor es " + met);
                    break;
                case 3:
                    cem = med / 10;
                    Console.WriteLine("En centimetros el valor es " + cem);
                    break;
                case 4:
                    pie = med / 304.8;
                    Console.WriteLine("En pies el valor es " + pie);
                    break;
                default:
                    Console.WriteLine("incorecto");
                return;
            }


        }

    }







    }
    

*/