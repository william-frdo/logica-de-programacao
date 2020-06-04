/* C11
   Faça um programa que receba um número inteiro maior que 1, verifique se o número fornecido
   é primo ou não e mostre uma mensagem de número primo ou de número não primo.
   Um número é primo quando é divisível apenas por 1 e por ele mesmo.
*/

using System;

class C11
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int i = 0;
        int j = 0;
        while (i != n)
        {
            if (n % 2 == 0)
            {
                j++;
            }

            i++;
        }

        if (j > 2)
        {
            Console.WriteLine($"{n} não é primo.");
        }
        else
        {
            Console.WriteLine($"{n} é primo.");
        }
    }
}