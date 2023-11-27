/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici X. Enunciat de l’exercici que es resol
 *
 */


using System;

namespace MyApplication
{

    class MethodPower
    {
        static void Main()
        {

            const string MsgNum = "Introdueix la base: ";
            const string MsgExp = "Introdueix l'exponent: ";
            const string MsgResult = "El resultat de la teva potència és {0}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num, exp;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgExp);
            exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, Math.Pow(num, exp));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
