using System;
using System.Timers;

namespace VideogameRoutines
{
    public class Ex31
    {
        public static void Main()
        {
            const string NICKNAMEMSG = "Escriu un nom de no més de 10 caràcters: ", RANGMSG = "Escriu un nombre entre 1 i 500: ";
            string username;
            int numInRange, position;
            do
            {
                Console.Write(NICKNAMEMSG);
                username = Console.ReadLine();
            }
            while (!NoMore10CharsName(username));

            do
            {
                Console.Write(RANGMSG);
                numInRange = Convert.ToInt32(Console.ReadLine());
            } while (!NumInRange(numInRange));

            position = RandomNum();
            Console.WriteLine("Nom: " + username + ", nombre del rang: " + numInRange + ", posició: " + position);
        }
        public static bool NoMore10CharsName(string username)
        {
            const string TOOLONG = "El nom és massa llarg! Torna a escriure-ho.", CORRECT = "El nom és correcte!";
            if (username.Length > 10)
            {
                Console.WriteLine(TOOLONG);
                return false;
            }
            Console.WriteLine(CORRECT);
            return true;
        }
        public static bool NumInRange(int num)
        {
            const string NOTINRANGE = "El nombre no és dins el rang!", CORRECT = "El nombre és correcte!";
            if (num < 1 || num > 500)
            {
                Console.WriteLine(NOTINRANGE);
                return false;
            }
            Console.WriteLine(CORRECT);
            return true;
        }
        public static int RandomNum()
        {
            Random randomPosition = new Random();
            return randomPosition.Next(1, 101);
        }
    }
}