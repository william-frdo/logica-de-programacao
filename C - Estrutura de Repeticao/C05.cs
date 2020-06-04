/* C05
   Faça um programa que leia o número de termos e um valor positivo para X.
   Calcule e mostre o valor da série a seguir:
   S = -X^2/1! +X^3/2! –X^4/3! +X^5/4! -X^6/3! +X^7/2! -X^8/1! +X^9/2! -X^10/3! +X^11/4! -...
*/

using System;

class C05
{
    static void Main(string[] args)
    {
        int termos, x;
        double s = 0;

        termos = int.Parse(Console.ReadLine());
        x = int.Parse(Console.ReadLine());

        int c = 1;
        bool limiteC = false;

        for (int i = 2; i <= termos + 1; i++)
        {
            double fat = 1;

            for (int j = 1; j <= c; j++)
            {
                fat *= j;
            }

            if (c == 1)
            {
                limiteC = false;
            }

            if (c == 4)
            {
                limiteC = true;
            }

            if (limiteC)
            {
                c--;
            }
            else
            {
                c++;
            }

            if (i % 2 == 0)
            {
                s -= Math.Pow(x, i) / fat;
            }
            else
            {
                s += Math.Pow(x, i) / fat;
            }
        }

        Console.WriteLine(s);
    }
}