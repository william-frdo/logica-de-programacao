/* A14
 * Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual, calcule e mostre:
 * a) a idade dessa pessoa;
 * b) quantos anos ela terá em 2050
 */

using System;

class A14
{
    static void Main(string[] args)
    {
        int nasc, atual, idade, idade2050;

        nasc = int.Parse(Console.ReadLine());
        atual = int.Parse(Console.ReadLine());

        idade = atual - nasc;
        idade2050 = 2050 - nasc;

        Console.WriteLine($"Idade atual: {idade}, idade em 2050: {idade2050}");
    }
}