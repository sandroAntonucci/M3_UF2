using System;

namespace MyApplication
{

    public class Power
    {
        public static void Main()
        {
            const string MsgNum = "Introdueix la base: ";
            const string MsgExp = "Introdueix el exponent: ";
            const string MsgResult = "La teva potència és {0}";

            int num, exp;

            Console.WriteLine(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgExp);
            exp = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(MsgResult, PowerMethod(num, exp));
            
        }

        public static int PowerMethod(int num, int exp)
        {
            int result = 1;

            for(int i = 0; i < exp; i++)
            {
                result *= num;
            }

            return result;
        }


    }
}