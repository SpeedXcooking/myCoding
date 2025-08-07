/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code13
{
    internal class PNT07
    {
        static void Main(string[] args)
        {
            //se presenta la empresa y se pregunta el producto querido
            Console.WriteLine("!Bienvenido a nuestra empresa !!MERKATODO!!\nCual de los siguientes productos desea comprar:\n1.Gomitas($4000)\n2.Frutos secos($2500)"+
                "\n3.Refresco($1500)\n4.Chocolatina($1000)\n5.Barra de granola($1200)\n6.Chicles($400)\n" +
                "7.Papitas($2200)\n8.Galletas($1500)\n9.Crispetas($1200)\n10.Confites($200)");
            //se guarda la respuesta
            int comida = int.Parse(Console.ReadLine());
            //se pregunta el # de productos deseados
            Console.WriteLine("Cuantos deseas");
            //se guarda la respuesta
            int prd = int.Parse(Console.ReadLine());
            //se incia una condicion
            switch (comida)
            {
                //lo que pasa si el usuario elige el caso 1
                case 1:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 4000;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 2
                case 2:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 2500;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 3
                case 3:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 1500;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 4
                case 4:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 1000;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 5
                case 5:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 1200;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 6
                case 6:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 400;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 7
                case 7:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 2200;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 8
                case 8:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 1500;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 9
                case 9:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 1200;
                    //se cierra el caso
                    break;

                //lo que pasa si el usuario elige el caso 10
                case 10:
                    //se multiplica el producto por el # de cuantos desea
                    prd *= 200;
                    //se cierra el caso
                    break;
                //si no se cumple ningun caso anterior
                default:
                    //se imprime un mensaje de tipo falla
                    Console.WriteLine("por favor vuelva a intentar");
                    //se cierra el caso
                return;
            }
            //se imprime en pantalla el valor a pagar
            Console.WriteLine($"El total a pagar es {prd}");
        }
    }
}
*/