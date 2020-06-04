/* A06
 * Faça um programa que receba o salário base de um funcionário, calcule e
 * mostre o salário a receber, sabendo-se que o funcionário tem gratificação
 * de 5% sobre o salário base e paga imposto de 7% também sobre o salário base.
 */

using System;

class A06
{
    static void Main(string[] args)
    {
        double sBase, sReceber;

        sBase = double.Parse(Console.ReadLine());

        sReceber = sBase + sBase * 0.05 - sBase * 0.07;

        Console.WriteLine($"{sReceber:C}");
    }
}