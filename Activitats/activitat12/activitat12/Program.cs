/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1.29/11/2023
 * Exercic 12.  Demanar per teclat el nombre de litres consumits aquest mes i calcular la factura d’aigua, tenint en compte les següents dades:
 *
 */


using System;

namespace MyApplication
{

    class Liters
    {
        static void Main()
        {

            const string MsgLiters = "Introdueix els llitres gastats: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int liters;

            Console.Write(MsgLiters);
            liters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Bill(liters));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static double Bill(int liters)
        {
            double price = 6;
            liters -= 50;

            if(liters > 0)
            {
                if (liters < 150)
                {
                    price += liters * 0.1;
                }

                else
                {
                    price += (149 * 0.1) + ((price-149)*0.3);
                }
            }

            return price;
        }
    }

}

