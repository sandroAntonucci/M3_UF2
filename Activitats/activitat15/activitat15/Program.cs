/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 01/12/2023
 * Activitat 15. Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 *
 */


using System;

namespace MyApplication
{

    class LeapYear
    {
        static void Main()
        {

            const string MsgYear = "Introdueix l'any: ";
            const string MsgLeapYear = "És un any de trespàs";
            const string MsgNotLeapYear = "No és un any de trespàs";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int year;

            Console.Write(MsgYear);
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsLeapYear(year) ? MsgLeapYear : MsgNotLeapYear);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0;
        }
    }

}
