/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. dd/mm/yyyy
 * Exercici X. Enunciat de l’exercici que es resol
 *
 */


using System;

namespace MyApplication
{
    public class Binary
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(RecursiveBinary(num, ""));


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static string RecursiveBinary(int num, string currentNum)
        {
            
            if (num == 1) return "1" + currentNum;

            else
            {
                if (num % 2 == 1)
                {
                    currentNum = "1" + currentNum;
                } 
                else
                {
                    currentNum = "0" + currentNum;
                }
                Console.WriteLine(currentNum);
                return RecursiveBinary(num / 2, currentNum);
            }

        }
    }
}

