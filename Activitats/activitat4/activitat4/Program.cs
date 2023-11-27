/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 27/11/2023
 * Activitat 4. Implementa un mètode que rebi un text i el retorni a majúscules o a minúscules (segons el cas).
 *
 */


using System;

namespace MyApplication
{

    public class Activitat4
    {
        static void Main()
        {

            const string MsgText = "Introdueix una frase: ";
            const string MsgUpperLower = "El vols en majúscules (1) o en minúscules (0): ";
            const string MsgResult = "El teu text és {0}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string text;

            bool upper;

            Console.Write(MsgText);
            text = Console.ReadLine();

            Console.Write(MsgUpperLower);
            upper = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(MsgResult, UpperLower(text,upper));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static string UpperLower(string text, bool upper)
        {
            return upper ? text.ToUpper() : text.ToLower();
        }
    }

}
