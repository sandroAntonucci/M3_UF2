using System;

namespace MyApplication
{

    class NaturalNumbers
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre natural: ";

            Console.WriteLine(MsgNum);
            Validate(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(MsgNum);
            Validate(Convert.ToInt32(Console.ReadLine()));

        }

        public static void Validate(int num)
        {
            Console.WriteLine(num > 0 ? $"El nombre {num} és natural" : $"El nombre {num} no és natural");
        }
    }
}