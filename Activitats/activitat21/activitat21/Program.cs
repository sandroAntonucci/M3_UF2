/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 08/12/2023
 * Activitat 21. Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 *
 */


using System;

namespace MyApplication
{

    class RomanNumber
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre romà: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
