/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 10/01/2024
 * Exercici 31. En l’estudi on estàs fent les pràctiques, volen llençar un nou videojoc. Les tasques que t’han assignat són crear les rutines següents que s’afegiran al programa que està implementant tot l’equip:
        Demanar a l’usuari el nom del personatge amb el que vol jugar. La rutina ha de validar que el nom no superi els 10 caràcters.
        Demanar a l’usuari que introdueixi un nombre dins del rang [1,500].
        Generar un valor aleatori (posició del mapa) entre el 1 i el 100.
 *
 */


using System;

namespace MyApplication
{

    public class ExtraFeatures
    {
        public static void Main()
        {
            const int MinRandom = 1, MaxRandom = 100;

            const string MsgNum = "Introdueix un nombre entre 1 i 500: ";
            const string MsgName = "Introdueix el nombre del personatge: ";
            const string MsgRandom =  "El número generat aleatoriament entre 1 i 100 és {0}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num, randomNum;

            string name;

            // Primera funcionalitat
            do{
                Console.Write(MsgName);
                name = Console.ReadLine();
            }while(!CheckValidName(name));

            // Segona funcionalitat
            do
            {
                Console.Write(MsgNum);
                num = Convert.ToInt32(Console.ReadLine());
            }while(!CheckValidNumber(num));

            // Tercera funcionalitat
            randomNum = GenerateRandom(MinRandom, MaxRandom);
            Console.WriteLine(MsgRandom, randomNum);
            

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static bool CheckValidName(string name)
        {
            return !(name.Length > 10);
        }

        public static bool CheckValidNumber(int num)
        {
            const int minNum = 1, maxNum = 500;
            return num >= minNum && num <= maxNum;
        }

        public static int GenerateRandom(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max+1);
        }
    }

}
