/* B06
 * Faça um programa que receba um número inteiro e verifique se é par ou ímpar.
 */

using System;

class B06
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} é par.");
        }
        else
        {
            Console.WriteLine($"{n} é ímpar.");
        }
    }
}