/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 05/12/2023
 * Activitat 16. Implementa un programa que demani a l’usuari quants valors vol introduir, de manera que el programa generi una llista a partir de valors introduïts per teclat i retorni el producte de tots els elements d’aquesta. Els valors que l’usuari pot introduir són entre (15, 100) i l’usuari disposa de 5 intents en total.
 *
 */


using System;

namespace MyApplication
{

    class Product
    {
        static void Main()
        {

            const int MinRange = 15;
            const int MaxRange = 100;

            const string MsgNum = "Introdueix un nombre enter entre 15 i 100: ";
            const string MsgNotValid = "Aquest valor no és vàlid.";
            const string MsgOutOfTries = "T'has quedat sense intents.";
            const string MsgValues = "Quants valors vols introduir: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int values, errors = 5, num = 16;

            bool valid = false;

            Console.WriteLine(MsgValues);
            values = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[values];

            for (int i = 0; i < nums.Length; i++)
            {

                while (errors > 0 && valid == false)
                {

                    Console.WriteLine(MsgNum);
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < MinRange || num > MaxRange)
                    {
                        Console.WriteLine(MsgNotValid);
                        errors--;
                        valid = false;
                    }
                    else
                    {
                        nums[i] = num;
                        valid = true;
                    }

                }

            }

            foreach (int i in nums) Console.WriteLine();

            Console.WriteLine(MsgEnd);
            Console.WriteLine(MsgEnd);
            Console.ReadKey();

            Console.WriteLine(MsgEnd);
            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }
}
