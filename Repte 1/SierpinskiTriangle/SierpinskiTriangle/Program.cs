using System;

namespace MyApplication
{
    public class SierpinskiTriangle
    {
        public static void Main()
        {

            string[] t = Triangle(3);

            foreach (string s in t) Console.WriteLine(s + s);

        }
        
        public static string[] Triangle(int spaces)
        {

            int asterisks = 1;

            string[] triangleDivided = new string[spaces];
            string currentTriangle = "";

            while (spaces > 0)
            {
                for (int i = 0; i < spaces; i++) currentTriangle += " ";
                for (int i = 0; i < asterisks; i++) currentTriangle += "* ";
                for (int i = 0; i < spaces; i++) currentTriangle += " ";

                triangleDivided[asterisks-1] = currentTriangle;

                currentTriangle = "";

                spaces--;
                asterisks++;


            }

            return triangleDivided;
        }

        
        public static void Sierpinski(int spaces)
        {

            int asterisks = 1;

            while (spaces > 0)
            {
                for (int i = 0; i < spaces; i++) Console.Write(" ");
                for (int i = 0; i < asterisks; i++) Console.Write("* ");

                Console.WriteLine();
                spaces--;
                asterisks++;

            }


        }
    }
}