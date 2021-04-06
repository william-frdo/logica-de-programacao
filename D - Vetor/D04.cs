/* D04
Faça um programa que preencha um vetor com oito números inteiros, calcule e
mostre dois vetores resultantes. O primeiro vetor resultante deve conter os
números positivos e o segundo, os números negativos. Cada vetor resultante vai
ter, no máximo, oito posições, que não poderão ser completamente utilizadas.
*/

using System;

class D04
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int[] v = new int[8];
        int[] positivo = new int[8];
        int[] negativo = new int[8];
        
        int c1 = 0;
        int c2 = 0;
        for (int i=0; i<v.Length; i++)
        {                
            v[i] = r.Next(-99, 100);
            
            if (v[i] >= 0)
            {
                positivo[c1] = v[i];
                c1++;
            }
            else
            {
                negativo[c2] = v[i];
                c2++;
            }
        }

        Console.Write("Vetor original: ");
        Console.Write("{ ");
        Console.Write(String.Join(", ", v));
        Console.Write(" }");
        Console.WriteLine();

        Console.Write("Vetor positivo: ");
        Console.Write("{ ");
        Console.Write(String.Join(", ", positivo));
        Console.Write(" }");
        Console.WriteLine();

        Console.Write("Vetor negativo: ");
        Console.Write("{ ");
        Console.Write(String.Join(", ", negativo));
        Console.Write(" }");
    }
}
