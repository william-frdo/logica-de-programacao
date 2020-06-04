/* C02
   Faça um programa que leia um valor N inteiro e positivo.
   Calcule e mostre o valor de E, conforme a fórmula a seguir:
   E = 1 + 1/1! + 1/2! + 1/3! + ... + 1/N!
*/

using System;

class C02
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double E, fat;

        E = 1;
        fat = 1;

        for (int i = 1; i <= N; i++)
        {
            fat *= i;
            E += 1 / fat;
        }

        System.Console.WriteLine(E);
    }
}