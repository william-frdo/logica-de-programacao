/* C08
   Faça um programa que leia o número de termos, determine e mostre os valores de acordo com a
   série a seguir:
   Série = 2, 7, 3, 4, 21, 12, 8, 63, 48, 16, 189, 192, 32, 567, 768...
*/

using System;

class C08
{
    static void Main(string[] args)
    {
        int n1 = 2, n2 = 7, n3 = 3, cont = -1;
        int termos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= termos; i++)
        {
            if (cont == -1)
            {
                Console.Write($"{n1}");
            }

            if (cont == 0)
            {
                Console.Write($"{n2}");
            }

            if (cont == 1)
            {
                Console.Write($"{n3}");
            }

            if (cont == 2)
            {
                n1 *= cont;
                Console.Write($"{n1}");
            }

            if (cont == 3)
            {
                n2 *= cont;
                Console.Write($"{n2}");
            }

            if (cont == 4)
            {
                n3 *= cont;
                Console.Write($"{n3}");
                cont = 1;
            }

            if (i < termos)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine("...");
            }

            cont++;
        }
    }
}