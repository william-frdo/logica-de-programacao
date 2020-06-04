/* A12
 * Faça um programa que receba dois números maiores que zero,
 * calcule e mostre um elevado ao outro.
 */

using System;

class A12
{
    static void Main(string[] args)
    {
        int n1, n2;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Pow(n1, n2));
        Console.WriteLine(Math.Pow(n2, n1));
    }
}