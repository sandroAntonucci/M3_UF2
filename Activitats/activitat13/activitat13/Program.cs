/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 01/12/2023
 * Activitat 13. Implementa un algorisme que demani 20 nombres enters per teclat i retorni els valors de  les posicions senars.
 *
 */


using System;

namespace MyApplication
{

    class TwentyNumbers
    {
        public static void Main()
        {
            const int quant = 20;

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[] nums = new int[quant];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(MsgNum);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] oddPositions = Numbers(nums);

            foreach(int i in oddPositions)
            {
                Console.WriteLine(i + " ");
            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static int[] Numbers(int[] nums)
        {
            int[] result = new int[nums.Length/2];

            for(int i = 0; i < result.Length; i++)
            {
                result[i] = nums[i*2+1];
            }

            return result;
        }
    }

}

