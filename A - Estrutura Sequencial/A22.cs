/* A22
 * Sabe-se que o quilowatt de energia custa um quinto do salário mínimo.
 * Faça um programa que receba o valor do salário mínimo e a quantidade
 * de quilowatts consumida por uma residência. calcule e mostre:
 * a) o valor de cada quilowatt;
 * b) o valor a ser pago por essa residência;
 * c) o valor a ser pago com desconto de 15%.
 */

using System;

class A22
{
    public static void Main(string[] args)
    {
        double sal, qtdWatts, valWatts, vTotal, vDesconto;

        sal = double.Parse(Console.ReadLine());
        qtdWatts = double.Parse(Console.ReadLine());

        valWatts = sal / 5;
        vTotal = valWatts * qtdWatts;
        vDesconto = vTotal - vTotal * 0.15;

        Console.WriteLine($"Valor do quilowatt: {valWatts:C}");
        Console.WriteLine($"Valor a ser pago: {vTotal:C}");
        Console.WriteLine($"Valor com desconto: {vDesconto:C}");
    }
}