/* C03
   Faça um programa que leia um número N que indica quantos valores inteiros e positivos devem ser lidos
   a seguir. Para cada número lido, mostre uma tabela contendo o valor lido e o fatorial desse valor.
*/

using System;

class C03
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int v = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int j = 1; j <= v; j++)
            {
                fat *= j;
            }
            Console.WriteLine($"{v}: {fat}");
        }
    }
}