/* A15
 * O custo ao consumidor de um carro novo é a soma do preço de fábrica com
 * o percentual de lucro do distribuidor e dos impostos aplicados ao preço de fábrica.
 * Faça um programa que receba o preço de fábrica de um veículo, o percentual de lucro
 * do distribuidor e o percentual de impostos, calcule e mostre:
 * a) o valor correspondente ao lucro do distribuidor;
 * b) o valor correspondente aos impostos;
 * c) o preço final do veículo.
 */

using System;

class A15
{
    static void Main(string[] args)
    {
        double pFab, percDist, percImp;

        pFab = double.Parse(Console.ReadLine());
        percDist = double.Parse(Console.ReadLine());
        percImp = double.Parse(Console.ReadLine());

        double lucroDist = pFab * (percDist / 100);
        double valorImp = pFab * (percImp / 100);
        double pFinal = pFab + lucroDist + valorImp;

        Console.WriteLine($"{lucroDist:C}");
        Console.WriteLine($"{valorImp:C}");
        Console.WriteLine($"{pFinal:C}");
    }
}