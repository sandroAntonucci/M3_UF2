/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 18/12/2023
 * Activitat 22. Implementa un programa que simuli el moviment d'un objecte en un entorn 2D, representant així un escenari de videojoc. L'objecte té una posició inicial en l'origen (0, 0) i es mou en funció d'una velocitat i direcció controlades per funcions trigonomètriques. La velocitat inicial de l'objecte és d'1.0 unitats per segon, i la direcció inicial és de 45 graus respecte a l'eix positiu x. Durant la simulació, la direcció de l'objecte canviarà en intervals de 10 graus per a simular esdeveniments en el joc. Mostra la posició actual de l'objecte en cada iteració de la simulació. La simulació ha de tenir una durada total de 5 segons. Implementa el seu test unitari.
 *
 */


using System;

class Program
{
    static void Main()
    {

        double velocity = 1.0; 
        double direction = 45.0; 

        double x = 0.0;
        double y = 0.0;


        for (int time = 0; time <= 5; time++)
        {

            Console.WriteLine($"Tiempo: {time}s - Posición: ({x}, {y})");

            x += velocity * Math.Cos(DegreesToRadians(direction));
            y += velocity * Math.Sin(DegreesToRadians(direction));

            System.Threading.Thread.Sleep(1000);
            direction += 10.0;
        }
    }

    static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }
}