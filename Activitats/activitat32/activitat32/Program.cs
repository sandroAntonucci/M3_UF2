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

        public static void AssignWholeMagicDust(ref double evil, ref double magicDustOne, ref double magicDustTwo, ref double magicDustThree, ref double magicDustFour)
        {

            magicDustOne = evil * 0.25;
            magicDustTwo = evil * 0.25;
            magicDustThree = evil * 0.25;
            magicDustFour = evil * 0.25;
            evil = evil % 4;

        }

        public static void AssignPartialMagicDust(ref double evil, ref double magicDustOne, ref double magicDustTwo, ref double magicDustThree, ref double magicDustFour)
        {

            magicDustOne = evil * 0.05;
            magicDustTwo = evil * 0.05;
            magicDustThree = evil * 0.05;
            magicDustFour = evil * 0.05;

            evil *= 0.80;

        }
    }

}

