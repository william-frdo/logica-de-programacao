/* E01
 * Faça um programa que preencha uma matriz M (2 x 2), calcule e mostre a matriz R, resultante
 * da multiplicação dos elementos de M pelo seu maior elemento.
 */

using System;

class E01
{
    static void Main(string[] args)
    {
        double[,] m = new double[2, 2];
        double[,] r = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Linha {i + 1}, Coluna {j + 1}: ");
                m[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maior = m[0, 0];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (m[i, j] > maior)
                {
                    maior = m[i, j];
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                r[i, j] = m[i, j] * maior;
            }
        }

        Console.WriteLine();
        Console.Write($"Matriz resultante: ");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{r[i, j]} ");
            }
        }
    }
}
