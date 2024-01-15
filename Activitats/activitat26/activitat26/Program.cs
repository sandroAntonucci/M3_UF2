/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 15/01/2024
 * Activitat 26. Implementa un mètode que retorni l’arrel digital d’un nombre natural. L’arrel digital és un nombre de només un dígit decimal que s’obté de la suma successiva dels dígits del nombre inicial. Per exemple, l’arrel digital de 83756 és 2 (8+3+7+5+6=29, 2+9=11, 1+1=2).
 *
 */


using System;

namespace MyApplication
{

    public class DigitalRoot
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateDigitalRoot(num));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int CalculateDigitalRoot(int num)
        {
            int sumDigits = 0;

            if(num < 10)
            {
                return num;
            }

            while(num > 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }

            return CalculateDigitalRoot(sumDigits);
        }
    }

}

