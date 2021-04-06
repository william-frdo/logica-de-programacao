/* D03
Faça um programa que preencha dois vetores de dez elementos numéricos
cada um e mostre o vet[] da intercalação deles.

Vetor 1 { 3, 5, 4, 2, 2, 5, 3, 2, 5, 9 }
          1  2  4  4  5  6  7  8  9  10

Vetor 2 { 7, 15, 20, 0, 18, 4, 55, 23, 8, 6 }
          1  2   4   4  5   6  7   8   9  10

Vetor resultante da intercalação
{ 3, 7, 5, 15, 4, 20, 2, 0, 2, 18, 5, 4, 3, 55, 2, 23, 5, 8, 9, 6 }
  1  2  3  4   5  6   7  8  9  10  11 12 13 14  15 16  17 18 19 20
*/

using System;

class D03
{
    static void Main(string[] args)
    {
        int[] v1 = { 3, 5, 4, 2, 2, 5, 3, 2, 5, 9 };
        int[] v2 = { 7, 15, 20, 0, 18, 4, 55, 23, 8, 6 };
        int[] v3 = new int[20];
        
        int c = 0;
        for (int i=0; i<v1.Length; i++)
        {                
            v3[c] = v1[i];
            c++;
            v3[c] = v2[i];
            c++;
        }

        Console.Write("{ ");
        Console.Write(String.Join(", ", v3));
        Console.Write(" }");
    }
}
