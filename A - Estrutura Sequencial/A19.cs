/* A19
 * Cada degrau de uma escada tem X de altura. Faça um programa que
 * receba essa altura e a altura que o usuário deseja alcançar subindo
 * a escada, calcule e mostre quantos degraus ele deverá subir para
 * atingir seu objetivo, sem se preocupar com a altura do usuário.
 * Todas as medidas fornecidas devem estar em metros.
 */

using System;

class A19
{
    static void Main(string[] args)
    {
        double degrau, altura, qtdDegraus;

        degrau = double.Parse(Console.ReadLine());
        altura = double.Parse(Console.ReadLine());

        qtdDegraus = altura / degrau;

        Console.WriteLine(qtdDegraus);
    }
}