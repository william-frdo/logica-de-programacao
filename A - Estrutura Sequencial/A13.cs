/* A13
 * Sabe-se que:
 * pé = 12 polegadas
 * 1 jarda = 3 pés
 * 1 milha = 1,760 jarda
 * Faça um programa que receba uma medida em pés, faça as conversões a seguir e mostre os resultados.
 * a) polegadas;
 * b) jardas;
 * c) milhas.
 */

using System;

class A13
{
    static void Main(string[] args)
    {
        double polegada, jarda, milhas, pe;

        pe = double.Parse(Console.ReadLine());

        polegada = pe * 12;
        jarda = pe / 3;
        milhas = jarda / 1760;

        Console.WriteLine(polegada);
        Console.WriteLine(jarda);
        Console.WriteLine(milhas);
    }
}