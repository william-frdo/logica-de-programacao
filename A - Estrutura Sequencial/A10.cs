/* A10
 * Faça um programa que calcule e mostre a área de um círculo.
 * Sabe-se que: Área = PI * R²
 */

using System;

class A10
{
    static void Main(string[] args)
    {
        double area, r;

        r = double.Parse(Console.ReadLine());
        area = 3.14159 * r * r;

        Console.WriteLine(area);
    }
}