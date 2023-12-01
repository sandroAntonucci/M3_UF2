/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 01/12/2023
 * Activitat 14.    Implementa un algorisme que donat un nombre introduït per teclat:
                    calculi quants digits té i ho mostri per pantalla
                    sumi els dígits amb valor parell (si n’hi han) i mostri el resultat per pantalla
                    sumi els dígits senars (si n’hi han)  i mostri el resultat per pantalla	
 *
 */


using System;

namespace MyApplication
{

    class CountDigits
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dígits: " + Digits(num));
            Console.WriteLine("Suma de dígits parells: " + SumEvenDigits(num));
            Console.WriteLine("Suma de dígits senars: "+ SumOddDigits(num));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int Digits(int num)
        {
            int digits = 0;

            while(num > 0)
            {
                num /= 10;
                digits++;
            }

            return digits;
        }

        public static int SumEvenDigits(int num)
        {
            int sum = 0;

            while(num > 0)
            {
                if(num%2 == 0) sum += num % 10;

                num /= 10;
            }

            return sum;
        }

        public static int SumOddDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                if (num % 2 == 1) sum += num % 10;

                num /= 10;
            }

            return sum;
        }
    }

}
