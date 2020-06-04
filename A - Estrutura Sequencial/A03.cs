/* A03
 * Faça um programa que receba três notas e seus respectivos pesos, calcule e mostre a média ponderada.
 */

using System;
using System.Globalization;

class A03
{
    static void Main(string[] args)
    {
        double nota1, nota2, nota3, media;
        int peso1, peso2, peso3;

        string[] vet = Console.ReadLine().Split(' ');
        nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
        nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
        peso1 = int.Parse(vet[3]);
        peso2 = int.Parse(vet[4]);
        peso3 = int.Parse(vet[5]);

        media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}