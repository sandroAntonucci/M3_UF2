/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 27/11/2023
 * Activitat 6. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 
 *
 */


using System;

namespace MyApplication
{

    class MethodAbsolute
    {
        static void Main()
        { 

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgResult = "El valor absolut de {0} és {1}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, num, Math.Abs(num));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();

        }
    }
}
