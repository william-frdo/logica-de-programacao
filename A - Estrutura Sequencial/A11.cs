/* A11
 * Faça um programa que receba um número positivo e maior que zero, calcule e mostre:
 * a) o número digitado ao quadrado;
 * b) o número digitado ao cubo;
 * c) a raiz quadrada do número digitado;
 * d) a raiz cúbica do número digitado
 */

using System;

class A11
{
    static void Main(string[] args)
    {
        double n, quad, cub, raizQuad, raizCub;

        n = double.Parse(Console.ReadLine());

        quad = Math.Pow(n, 2);
        cub = Math.Pow(n, 3);
        raizQuad = Math.Sqrt(n);
        raizCub = Math.Cbrt(n);

        Console.WriteLine($"{n} ao quadrado = {quad}");
        Console.WriteLine($"{n} ao cubo = {cub}");
        Console.WriteLine($"Raíz quadrada de {n} = {raizQuad}");
        Console.WriteLine($"Raíz cúbica de {n} = {raizCub}");
    }
}