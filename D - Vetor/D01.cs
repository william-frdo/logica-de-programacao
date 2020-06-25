/* D01
 * Faça um programa que preencha um vetor com nove números inteiros,
 * calcule e mostre os números primos e suas respectivas posições.
 */

using System;

class D01
{
    static void Main(string[] args)
    {
        int[] n = new int[9];
        Random r = new Random();

        // Preenche o array com valores aleatórios de 0 à 100
        for (int i = 0; i < n.Length; i++)
        {
            n[i] = r.Next(101);
        }

        // Exibe o array
        foreach (var item in n)
        {
            Console.Write($"[{item}]");
        }

        Console.WriteLine();

        bool b = false;
        for (int i = 0; i < n.Length; i++)
        {
            // Verifica se é primo
            int c = 0;
            for (int j = n[i]; j > 0; j--)
            {
                if (n[i] % j == 0)
                {
                    c++;
                }
            }

            // Exibe os valores primos
            if (c == 2)
            {
                Console.WriteLine($"Primo: {n[i]} na posição {i}");
                b = true;
            }
        }

        if (b == false)
        {
            Console.WriteLine("Não há números primos");
        }
    }
}
