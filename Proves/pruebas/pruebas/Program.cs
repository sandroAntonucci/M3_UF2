using System;

namespace MyApplication
{

    class hola
    {

        static void Main()
        {

            const string MsgNames = "Introdueix els noms dels personatges (4) separats per comes i un espai: ";
            const string MsgNamesNotValid = "Aquest format no és vàlid.";

            string[] assignedNames = new string[4];

            string names;
            bool namesValid = true;


            do
            {
                Console.WriteLine(MsgNames);

                names = Console.ReadLine();
                names = names.Trim(',');


                if (names.Split(' ').Length != 4)
                {
                    Console.Write(MsgNamesNotValid);
                    namesValid = false;
                }
                else
                {
                    namesValid = true;
                    assignedNames = names.Split(' ');
                }

            } while (!namesValid);

            foreach (string name in assignedNames) Console.WriteLine(name);

        }

    }


}