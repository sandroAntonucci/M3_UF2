/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 29/11/2023
 * Exercici 10. Implementa un programa que generi una llista de 10 valors aleatoris entre el 0 i el 200, demani un valor per teclat i informi per pantalla si aquest valor indicat es troba a la llista.
 */


using System;

namespace MyApplication
{

    class RandomList
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int numGuessed, j = 0;

            bool numInList = false;

            Random random = new Random();
            int[] nums = new int[10];


            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(201);
            }

            Console.WriteLine(MsgNum);
            numGuessed = Convert.ToInt32(Console.ReadLine());



            while(numInList == false && j < nums.Length)
            {
                if (nums[j] == numGuessed) numInList = true;
                j++;
            };

            Console.WriteLine(numInList ? "El nombre es troba a la llista" : "El nombre no es troba a la llista");

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }
}
