/* A23
 * Faça um programa que receba um número real, encontre e mostre:
 * a) a parte inteira desse número;
 * b) a parte fracionária desse número;
 * c) o arredondamento desse número.
 */

using System;

class A23
{
    static void Main(string[] args)
    {
        double i, f, a, n;

        n = double.Parse(Console.ReadLine());

        // Converte doble em int para armazenar em "i" apenas a parte inteira
        i = (int)n;
        f = n - i;
        a = Math.Round(n);

        Console.WriteLine($"{i} \n{f} \n{a}");
    }
}