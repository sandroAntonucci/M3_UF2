/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 10/01/2024
 * Cinc pometes
 *
 */


using System;

namespace MyApplication
{

    public class Pometes
    {
        public static void Main()
        {

            const string MsgPometes = "Quantes pometes té l'arbre: ";

            int pometes = 0;

            do
            {
                Console.WriteLine(MsgPometes);
                pometes = Convert.ToInt32(Console.ReadLine());
            }while( pometes < 1 );
            

            PrintPometes(pometes);

        }

        public static void PrintPometes(int pometes)
        {
            const string MsgPometes = "{0} pometes té el pomer,\r\nde {0} una, de {0} una,\r\n{0} pometes té el pomer,\r\nde {0} una en caigué.\r\n\r\nSi mireu el vent d'on vé\r\nveureu el pomer com dansa,\r\nsi mireu el vent d'on vé\r\nveureu com dansa el pomer.";
            const string MsgPoma = "{0} pometa té el pomer,\r\nde {0} una, de {0} una,\r\n{0} pometa té el pomer,\r\nde {0} una en caigué.\r\n\r\nSi mireu el vent d'on vé\r\nveureu el pomer com dansa,\r\nsi mireu el vent d'on vé\r\nveureu com dansa el pomer.";

            if (pometes == 0)
            {
                Console.WriteLine(MsgPoma, 1);
                return;
            }
            else
            {
                Console.WriteLine(MsgPometes, pometes);
                PrintPometes(pometes - 1);
            }

        }
    }

}
