/* A07
 * Faça um programa que receba o salário base de um funcionário, calcule
 * e mostre seu salário a receber, sabendo-se que o funcionário tem
 * gratificação de R$ 50 e paga imposto de 10% sobre o salário base.
 */

using System;

class A07
{
    static void Main(string[] args)
    {
        double sBase, sReceber;

        sBase = double.Parse(Console.ReadLine());

        sReceber = sBase + 50 - sBase * 0.10;

        Console.WriteLine($"{sReceber:C}");
    }
}