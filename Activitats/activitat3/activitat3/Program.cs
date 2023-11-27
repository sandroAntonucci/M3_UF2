/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 27/11/2023
 * Activitat 3. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat.
 *
 */


using System;
using System.Reflection.Metadata.Ecma335;

namespace MyApplication
{

    public class ReturnAbsolute
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgResult = "El valor absolut de {0} és {1}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, num, Absolute(num));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int Absolute(int num)
        {
            return num < 0 ? -num : num;
        }
    }

}
