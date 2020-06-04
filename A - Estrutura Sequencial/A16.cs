/* A16
 * Faça um programa que receba o número de horas trabalhadas e o valor do salário mínimo,
 * calcule e mostre o salário a receber, seguindo estas regras:
 * a) a hora trabalhada vale a metade do salário mínimo.
 * b) o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada.
 * c) o imposto equivale a 3% do salário bruto.
 * d) o salário a receber equivale ao salário bruto menos o imposto.
 */

using System;

class A16
{
    static void Main(string[] args)
    {
        double hTrab, salMin, salBruto, salReceber, imp;

        hTrab = double.Parse(Console.ReadLine());
        salMin = double.Parse(Console.ReadLine());

        salBruto = hTrab * salMin / 2;
        imp = salBruto * 0.03;
        salReceber = salBruto - imp;

        Console.WriteLine($"{salReceber:C}");
    }
}