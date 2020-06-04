/* A08
 * Faça um programa que receba o valor de um depósito e o valor da taxa de juros,
 * calcule e mostre o valor do rendimento e o valor total depois do rendimento.
 */

using System;

class A08
{
    static void Main(string[] args)
    {
        double dep, rend, total;

        dep = double.Parse(Console.ReadLine());
        int juros = int.Parse(Console.ReadLine());

        rend = dep * juros / 100;
        total = dep + rend;

        Console.WriteLine($"Rendimento: {rend:C}");
        Console.WriteLine($"Total: {total:C}");
    }
}