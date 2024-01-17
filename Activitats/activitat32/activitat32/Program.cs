/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 16/01/2024
 * Activitat 32
 *
 */


using System;

namespace MyApplication
{

    public class SuperFour
    {
        public static void Main()
        {

            const int MinAvatar = 1, MaxAvatar = 4, MinCharsInName = 2, MaxCharsInName = 25, MinEvil = 1000, MaxEvil = 50000;

            const string MsgAvatar = "Escull un avatar, introdueix un nombre del 1 al 4 (inclosos): ";
            const string MsgName = "Introdueix el nom de l'avatar (entre 2 i 25 caràcters i sense caràcters especials): ";
            const string MsgEvil = "Introdueix la maldat de l'avatar (entre 1000 i 50000): ";
            const string MsgWholeMagicDust = "El nom té dos vocals! Es reparteix la maldat com a pols màgic per als super 4.";
            const string MsgPartialMagicDust = "El nom no té dues vocals! Es reparteix a cada super un 5% de la maldat.";
            const string MsgCharacterStats = "El personatge 1 té {0} pols màgic\nEl personatge 2 té {1} pols màgic\nEl personatge 3 té {2} pols màgic\nEl personatge 4 té {3} pols màgic\nL'avatar té {4} de maldat";

            int avatar, evil, magicDustOne = 0, magicDustTwo = 0, magicDustThree = 0, magicDustFour = 0;

            string name;

            do
            {
                Console.Write(MsgAvatar);
                avatar = Convert.ToInt32(Console.ReadLine());
            } while (!CheckNumBetweenRange(avatar, MinAvatar, MaxAvatar));

            do
            {
                Console.Write(MsgName);
                name = Console.ReadLine();
            }while (!CheckNumBetweenRange(name.Length, MinCharsInName, MaxCharsInName) || !CheckNoSpecialChars(name));

            do
            {
                Console.Write(MsgEvil);
                evil = Convert.ToInt32(Console.ReadLine());
            }while(!CheckNumBetweenRange(evil, MinEvil, MaxEvil));

            if (CheckTwoVocalsInName(name))
            {
                Console.WriteLine(MsgWholeMagicDust);
                AssignWholeMagicDust(ref evil, ref magicDustOne, ref magicDustTwo, ref magicDustThree, ref magicDustFour);
            }
            else
            {
                Console.WriteLine(MsgPartialMagicDust);
                AssignPartialMagicDust(ref evil, ref magicDustOne, ref magicDustTwo, ref magicDustThree, ref magicDustFour);
            }

            Console.WriteLine(MsgCharacterStats, magicDustOne, magicDustTwo, magicDustThree, magicDustFour, evil);

        }

        public static bool CheckNumBetweenRange(int num, int min, int max)
        {
            return num >= min && num <= max;
        }

        public static bool CheckNoSpecialChars(string name)
        {
            const string SpecialChars = "!@#$%^&*()_+<>?:.,;{}[]|/";
            
            bool containsSpecialChars = false;

            foreach(char c in name)
            {
                if(SpecialChars.Contains(c))
                {
                    containsSpecialChars = true;
                }
            }

            return !containsSpecialChars;
        }
        
        public static bool CheckTwoVocalsInName(string name)
        {
            const string Vocals = "aeiouAEIOU";

            int vocalsCount = 0;

            foreach(char c in name)
            {
                if(Vocals.Contains(c))
                {
                    vocalsCount++;
                }
            }

            return vocalsCount >= 2;
        }

        public static void AssignWholeMagicDust(ref int evil, ref int magicDustOne, ref int magicDustTwo, ref int magicDustThree, ref int magicDustFour)
        {

            magicDustOne = evil / 4;
            magicDustTwo = evil / 4;
            magicDustThree = evil / 4;
            magicDustFour = evil / 4;
            evil = evil % 4;

        }

        
        public static void AssignPartialMagicDust(ref int evil, ref int magicDustOne, ref int magicDustTwo, ref int magicDustThree, ref int magicDustFour)
        {

            
            magicDustOne = evil * 5 / 100;
            magicDustTwo = evil * 5 / 100;
            magicDustThree = evil * 5 / 100;
            magicDustFour = evil * 5 / 100;

            evil = evil * 80 / 100;
            
        }

    }

}

