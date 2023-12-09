/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 07/12/2023
 * Activitat 20. Implementa un programa que donat un nombre decimal introduït per teclat retorni la part entera i la part decimal d’aquest.
 *
 */


using System;

namespace MyApplication
{

    public static class DecimalAndInteger
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre: ";
            const string MsgResult = "La part entera és {0} i la part decimal és {1}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            double num, dec = 0;
            int integ = 0;

            Console.Write(MsgNum);
            num = Convert.ToSingle(Console.ReadLine());

            DivideDecAndInt(ref dec, ref integ, num);

            Console.WriteLine(MsgResult, integ, dec);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static void DivideDecAndInt(ref double dec, ref int integ, double num)
        {
            integ = Convert.ToInt32(num / 1);
            dec = num - integ;
            dec = Math.Round(dec, 4);

            Console.WriteLine(dec);

            while(dec % 10 != 0)
            {
                dec *= 10;
            }

            dec /= 10;
        }
    }

}
