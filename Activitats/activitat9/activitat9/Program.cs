/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 27/11/2023
 * Activitat 9. mplementa un mètode per a utilitzar en un programa principal, o invocat per un altre mètode, que permeti validar si un nombre és més petit que un valor (introduït per teclat) o és dins d’un rang (està dins de dos valors introduïts per teclat). Els missatges que es mostraran han de poder ser parametritzables.
 *
 */


using System;

namespace MyApplication
{

    class MethodValidate 
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgMax = "Introdueix un màxim: ";
            const string MsgMin = "Introdueix un mínim: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num, minValue, maxValue, testNum = 5;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgMax);
            maxValue = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgMin);
            minValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Validate(num, testNum) ? $"El número és més petit que {num}" : $"El número és més gran que {num}");
            Console.WriteLine(Validate(minValue, maxValue, testNum) ? $"El número està entre {minValue} i {maxValue}" : $"El número no està entre {minValue} i {maxValue}");


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static bool Validate(int num, int testNum)
        {

            return testNum < num;

        }

        public static bool Validate(int minValue, int maxValue, int testNum)
        {

            return testNum > minValue && testNum <  maxValue;

        }
    }
}
