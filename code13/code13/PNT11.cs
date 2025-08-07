/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace code13
{
    internal class PNT11
    {
        static void Main(string[] args)
        {
            double ef, bon, td, tc = 0;
            Console.WriteLine("cuantos elementos esta comprando");
            int com = int.Parse(Console.ReadLine());
            Console.WriteLine("cuanto cuesta en promedio cada producto");
            int pag = int.Parse(Console.ReadLine());
            Console.WriteLine("elija la forma de pago: \n1.efectivo \n2.bono \n3.tarjeta debito \n4.tarjeta de credit\n");
            double opcion = double.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ef = com * pag;
                    Console.WriteLine("su total a pagar es " + ef);
                    break;
                case 2:
                    bon = com * pag;
                    Console.WriteLine("su total a pagar es " + bon);
                    break;
                case 3:
                    td = com * pag;
                    Console.WriteLine("su total a pagar es " + td);
                    break;
                case 4:
                    tc = com * pag;
                    Console.WriteLine("su total a pagar es " + tc);
                    break;
                default:
                    Console.WriteLine("incorecto");
                    return;
            }

        }
    }
}
*/