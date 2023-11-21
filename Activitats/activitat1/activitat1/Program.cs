using System;

namespace MyApplication
{

    public class NaturalNumbers
    {
        public static void Main()
        {

            const string MsgNum = "Introdueix un nombre natural: ";
            const string MsgFirstGreater = "El primer nombre és major que el segon";
            const string MsgSecondGreater = "El segon nombre és major que el primer";
            const string MsgEqual = "Els nombres són iguals";


            int firstNum, secondNum;

            do
            {
                Console.WriteLine(MsgNum);
                firstNum = Convert.ToInt32(Console.ReadLine());

            } while (!(Validate(firstNum)));

            do
            {
                Console.WriteLine(MsgNum);
                secondNum = Convert.ToInt32(Console.ReadLine());

            } while (!(Validate(firstNum)));


            if (firstNum > secondNum) Console.WriteLine(MsgFirstGreater);
            else if (secondNum > firstNum) Console.WriteLine(MsgSecondGreater);
            else Console.WriteLine(MsgEqual);

        }

        public static bool Validate(int num)
        {

            return num > 0;

        }


    }
}