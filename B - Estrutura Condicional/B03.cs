/* B03
 * Faça um programa que receba dois números e mostre o maior.
 */

using System;

class B03
{
    static void Main(string[] args)
    {
        int n1, n2;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine(n1);
        }
        else
        {
            Console.WriteLine(n2);
        }
    }
}