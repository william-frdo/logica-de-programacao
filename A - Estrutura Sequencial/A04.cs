/* A04
 * Faça um programa que receba o salário de um funcionário, calcule e
 * mostre o novo salário, sabendo-se que este sofreu um aumento de 25%.
 */

using System;

class A04
{
    static void Main(string[] args)
    {
        double salario, novoSalario;

        salario = double.Parse(Console.ReadLine());

        novoSalario = salario + salario * 0.25;

        Console.WriteLine($"{novoSalario:C}");
    }
}