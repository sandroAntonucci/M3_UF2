/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 29/11/2023
 * Exercici 11. Implementa un programa que demani un valor per teclat i retorni el seu factorial. 
 *
 */


using System;

namespace MyApplication
{

    class Factorial
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El factorial de {num} és {ReturnFactorial(num)}");

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int ReturnFactorial(int num)
        {
            int result = 1;

            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
