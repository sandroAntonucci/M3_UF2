/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 07/12/2023
 * Activitat 18. Implementa un mètode que rebiun nombre enter (minuts) i retorni la seva conversió a segons.
 *
 */


using System;

namespace MyApplication
{

    class MinToSec
    {
        static void Main()
        {

            const string MsgMins = "Introdueix els minuts: ";
            const string MsgSecs = "{0} minuts son {1} segons";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int mins;

            Console.Write(MsgMins);
            mins = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgSecs, mins, ToSecs(mins));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int ToSecs(int mins)
        {
            return mins * 60;
        }
    }

}
