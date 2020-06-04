/* D01
 * Faça um programa que preencha um vetor com nove números inteiros, calcule e mostre os números
 * primos e suas respectivas posições.
 */

using System;

class D01
{
    static void Main(string[] args)
    {           
        int[] n = new int[9];

        for (int i = 0; i < n.Length; i++)
        {
            Console.Write($"{i + 1}º valor: ");
            n[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n.Length; i++)
        {
            int c = 0;

            for (int j = 1; j <= n[i]; j++)
            {
                if (n[i] % j == 0)
                {
                    c++;
                }
            }

            if (c == 2)
            {
                Console.WriteLine($"Primo: {n[i]} na posição {i}");
            }
        }
    }
}
