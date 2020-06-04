/* A25
 * Faça um programa que receba o custo de um espetáculo teatral e o preço do convite desse espetáculo.
 * Esse programa deverá calcular e mostrar a quantidade de convites que devem ser vendidos para que,
 * pelo menos, o custo do espetáculo seja alcançado.
 */

using System;

class A25
{
    static void Main(string[] args)
    {
        double espetaculo, convite, qtdNecessaria;

        espetaculo = double.Parse(Console.ReadLine());
        convite = double.Parse(Console.ReadLine());

        qtdNecessaria = espetaculo / convite;

        Console.WriteLine(qtdNecessaria);
    }
}