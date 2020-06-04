/* C19
 * Faça um programa que leia um número não determinado de pares de valores [m,n],
 * todos inteiros e positivos, um par de cada vez, e que calcule e mostre a soma
 * de todos os números inteiros entre m e n (inclusive). A digitação de pares
 * terminará quando m for maior ou igual a n.
 */

using System;

namespace C19
{
    class C19
    {
        static void Main(string[] args)
        {
            int m, n, soma;

            Console.Write("Valor inicial: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Valor final: ");
            n = int.Parse(Console.ReadLine());

            while (m < n)
            {
                soma = 0;

                for (int i = m; i <= n; i++)
                {
                    soma += i;
                }

                Console.WriteLine($"Soma = {soma}");
                Console.WriteLine();
                Console.Write("Valor inicial: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Valor final: ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
