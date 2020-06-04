/* A01
 * Faça um programa que receba quatro números inteiros, calcule e mostre a soma desses números.
 */

using System;

class A01
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, soma;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        soma = n1 + n2 + n3 + n4;

        Console.WriteLine(soma);
    }
}