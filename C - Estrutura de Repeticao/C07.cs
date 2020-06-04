/* C07
   Faça um programa que monte os oito primeiros termos da sequência de Fibonacci.
   0-1-1-2-3-5-8-13-21-34-55...
*/

using System;

class C07
{
    static void Main(string[] args)
    {
        int f = 0, n1 = 1, aux;

        for (int i = 1; i <= 8; i++)
        {
            if (i < 8)
            {
                Console.Write($"{f}-");
            }
            else
            {
                Console.WriteLine($"{f}...");
            }

            aux = f + n1;
            f = n1;
            n1 = aux;
        }
    }
}