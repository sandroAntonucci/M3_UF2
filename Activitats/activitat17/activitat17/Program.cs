/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 07/12/2023
 * Activitat 17. Implementa un programa que llegeixi graus en escala Celsius (CC) i els converteixi en graus en escala Fahrenheit (FF). Arrodoneix el resultat a 2 dígits després del punt decimal.
 *
 */


using System;

namespace MyApplication
{

    public static class CelsiusToFahrenheit
    {
        public static void Main()
        {

            const string MsgCelsius = "Introdueix els graus Celsius: ";
            const string MsgFahrenheit = "{0} graus celsius equivalen a {1} graus Fahrenheit";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            decimal celsius;

            Console.Write(MsgCelsius);
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgFahrenheit, celsius, ToFahrenheit(celsius));

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }

        public static decimal ToFahrenheit(decimal celsius)
        {
            return Decimal.Round((celsius * 9 / 5) + 32, 2);
        }
    }
}
