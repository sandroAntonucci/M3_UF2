/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 27/11/2023
 * Activitat 8. Implementa un mètode que retorni 10 nombres al·leatoris entre 0 i 256.
 *
 */


using System;

namespace MyApplication
{

    class MethodRandom
    {
        static void Main()
        {
            const string MsgResult = "Nombre: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            Random random = new Random();

            for(int i = 0; i < 10; i++) 
            {
                int num = random.Next(0, 255 + 1);
                Console.WriteLine(MsgResult + num);
            }
                      
            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
