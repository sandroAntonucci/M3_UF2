/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 08/12/2023
 * Activitat 21. Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 *
 */


using System;

namespace MyApplication
{

    class RomanNumber
    {
        static void Main()
        {

            const string MsgRomanNum = "Introdueix un nombre romà: ";
            const string MsgDecimalNum = "El teu nombre romà en decimal és ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string romanNum;

            Console.Write(MsgRomanNum);
            romanNum = Console.ReadLine();


            Console.WriteLine(MsgDecimalNum + RomanToDecimal(romanNum));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int RomanToDecimal(string romanNum){

            

            int[] values = { 1000, 500, 100, 50, 10, 5, 1 };

            int decimalNum = 0, letter = 0;
            bool validRomanNum = true;
            string validLetters = "mdclxvi";

            romanNum = romanNum.ToLower();

            // Comprueba que el número romano sea válido
            while (validRomanNum && letter < romanNum.Length)
            {
                if (!validLetters.Contains(romanNum[letter])) {

                    validRomanNum = false;
                    return -1;
                } 
                letter++;
            }

            
            for (int i = 0; i < romanNum.Length-1; i++)
            {
                int letterValue = values[validLetters.IndexOf(romanNum[i])];
                if (letterValue < values[validLetters.IndexOf(romanNum[i+1])]) decimalNum -= letterValue;
                else decimalNum += letterValue;
            }

            decimalNum += values[validLetters.IndexOf(romanNum[romanNum.Length-1])];


            return decimalNum;
        }
    }
}
