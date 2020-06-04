/* B04
 * 
 * Faça um programa que receba três números e mostre-os em ordem crescente.
 * Suponha que o usuário digitará três números diferentes.
 */

using System;

class B04
{
    static void Main(string[] args)
    {
        int n1, n2, n3;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

        if (n1 < n2 && n1 < n3)
        {
            if (n2 < n3)
            {
                Console.Write($"{n1}, {n2}, {n3}");
            }
            else
            {
                Console.Write($"{n1}, {n3}, {n2}");
            }
        }
        else if (n2 < n1 && n2 < n3)
        {
            if (n1 < n3)
            {
                Console.Write($"{n2}, {n1}, {n3}");
            }
            else
            {
                Console.Write($"{n2}, {n3}, {n1}");
            }
        }
        else
        {
            if (n1 < n2)
            {
                Console.Write($"{n3}, {n1}, {n2}");
            }
            else
            {
                Console.Write($"{n3}, {n2}, {n1}");
            }
        }
    }
}