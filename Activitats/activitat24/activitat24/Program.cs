/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 09/01/2024
 * Exercici 24. Implementa un programa que demani dos valors per teclat i calculi el seu producte, seguint el mètode rus (multiplicació per duplicació). S’ha d’implementar:
        mètode iteratiu
        mètode recursiu
 *
 */


using System;

namespace MyApplication
{

    public class Product
    {
        public static void Main()
        {

            const string MsgFirstNum = "Introdueix el primer nombre enter: ";
            const string MsgSecondNum = "Introdueix el segon nombre enter: ";

            int firstNum, secondNum;

            Console.WriteLine(MsgFirstNum);
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgSecondNum);
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(RecursiveRussianMultiplication(firstNum, secondNum));


        }

        public static int IterativeRussianMultiplication(int firstNum, int secondNum)
        {
            int result = 0;

            while(firstNum >= 1)
            {
                
                if(firstNum % 2 == 1)
                {
                    result += secondNum;
                }

                firstNum /= 2;
                secondNum *= 2;
            }

            return result;
        }

        public static int RecursiveRussianMultiplication(int firstNum, int secondNum)
        {

            if(firstNum == 1)
            {
                return secondNum;
            }
            else if (firstNum % 2 == 1)
            {
                return secondNum + RecursiveRussianMultiplication(firstNum / 2, secondNum * 2);
            }
            else
            {
                return RecursiveRussianMultiplication(firstNum / 2, secondNum * 2);
            }
            
        }
    }

}

