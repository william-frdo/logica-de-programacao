/* A24
 * Faça um programa que receba uma hora formada por hora e minutos
 * (um número real), calcule e mostre a hora digitada apenas em minutos.
 * Lembre-se de que:
 * para quatro e meia, deve-se digitar 4.30;
 * os minutos vão de 0 a 59.
 */

using System;
using System.Globalization;

class A24
{
    static void Main(string[] args)
    {
        double m, h, totMin;
        h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        totMin = (int)h;
        m = h - totMin;
        totMin = totMin * 60 + m * 100;

        Console.WriteLine(totMin);
    }
}