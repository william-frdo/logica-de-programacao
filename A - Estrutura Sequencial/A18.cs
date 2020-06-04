/* A18
 * Pedro comprou um saco de ração com peso em quilos.
 * Ele possui dois gatos, para os quais fornece a quantidade de ração em gramas.
 * A quantidade diária de ração fornecida para cada gato é sempre a mesma.
 * Faça um programa que receba o peso do saco de ração e a quantidade de ração
 * fornecida para cada gato, calcule e mostre quanto restará de ração no saco após cinco dias.
 */

using System;

class A18
{
    static void Main(string[] args)
    {
        double peso, qtdGato1, qtdGato2, qtdRestante, totDias;

        peso = double.Parse(Console.ReadLine());
        qtdGato1 = double.Parse(Console.ReadLine());
        qtdGato2 = double.Parse(Console.ReadLine());

        totDias = (qtdGato1 / 1000 + qtdGato2 / 1000) * 5;
        qtdRestante = peso - totDias;

        Console.WriteLine(qtdRestante.ToString("F3"));
    }
}