using System;
using System.Xml.Serialization;

namespace MyApplication
{
    public class SierpinskiTriangle
    {
        public static void Main()
        {
            int spaces = 3;

            string[] t = Triangle(spaces);

            Sierpinski(t, spaces);

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

        
        public static void Sierpinski(string[] t, int spaces, int quant)
        {
            string[] triangles = new string[quant];
            string space = "";
            string actualTriangle = "";

            foreach (string s in t){

                for (int i = 0; i <= spaces; i++) space += " ";
                
                actualTriangle += space + s + "\n";

                space = "";

            }
            foreach (string s in t) Console.WriteLine(s + s);

        }
    }
}