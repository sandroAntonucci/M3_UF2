/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 07/12/2023
 * Activitat 19. Implementa un programa que retorni el màxim i mínim de dos valors enters introduïts per teclat.
 *
 */


using System;

namespace MyApplication
{

    class MaxAndMin
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int firstNum, secondNum;

            Console.Write(MsgNum);
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgNum);
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MinMax(firstNum, secondNum));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static string MinMax(int firstNum, int secondNum)
        {
            if(firstNum > secondNum)
            {
                return $"{firstNum} és el màxim i {secondNum} és el mínim";
            }
            else if(secondNum > firstNum)
            {
                return $"{secondNum} és el màxim i {firstNum} és el mínim";
            }
            else
            {
                return "Els dos nombres són iguals.";
            }
        }
    }
}
