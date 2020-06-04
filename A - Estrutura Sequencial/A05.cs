/* A05
 * Faça um programa que receba o salário de um funcionário e o percentual
 * de aumento, calcule e mostre o valor do aumento e o novo salário.
 */

using System;

class A05
{
    static void Main(string[] args)
    {
        double salario, aumento, novoSalario;
        int percentual;

        salario = double.Parse(Console.ReadLine());
        percentual = int.Parse(Console.ReadLine());

        aumento = salario * percentual / 100;
        novoSalario = salario + aumento;

        Console.WriteLine($"Aumento: {aumento:C}");
        Console.WriteLine($"Novo salário: {novoSalario:C}");
    }
}