/* B05
 * Faça um programa que receba três números obrigatoriamente em ordem
 * crescente e um quarto número que não siga essa regra. Mostre, em seguida,
 * os quatro números em ordem decrescente. Suponha que o usuário digitará
 * quatro números diferentes.
 */

using System;

class B05
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if (n4 > n3)
        {
            Console.WriteLine($"{n4}, {n3}, {n2}, {n1}");
        }

        if (n4 > n2 && n4 < n3)
        {
            Console.WriteLine($"{n3}, {n4}, {n2}, {n1}");
        }

        if (n4 > n1 && n4 < n2)
        {
            Console.WriteLine($"{n3}, {n2}, {n4}, {n1}");
        }

        if (n4 < n1)
        {
            Console.WriteLine($"{n3}, {n2}, {n1}, {n4}");
        }
    }
}
