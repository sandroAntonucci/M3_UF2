/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 27/11/2023
 * Activitat 5. Demanar un nombre per teclat i indicar per pantalla si aquest nombre és positiu i menor que 100.
 *
 */


using System;

namespace MyApplication
{

    public class Activitat5
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgTrue = "El teu nombre és positiu i menor que 100.";
            const string MsgFalse  = "El teu nombre no és positiu o no és menor que 100.";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Positive(num) ? MsgTrue : MsgFalse);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static bool Positive(int num)
        {
            return num > 0 && num < 100;
        }
    }

}
