/* A09
 * Faça um programa que calcule e mostre a área de um triângulo.
 * Sabe-se que: Área = (base * altura)/2
 */

using System;

class A09
{
    static void Main(string[] args)
    {
        double b, a, area;

        b = double.Parse(Console.ReadLine());
        a = double.Parse(Console.ReadLine());

        area = (b * a) / 2;

        Console.WriteLine(area);
    }
}