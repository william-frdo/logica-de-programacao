/* A02
 * Faça um programa que receba três notas, calcule e mostre a média aritmética.
 */

using System;
using System.Globalization;

class A02
{
    static void Main(string[] args)
    {
        double n1, n2, n3, media;

        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (n1 + n2 + n3) / 3;

        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}