/* A20
 * Faça um programa que receba a medida do ângulo (em graus) formado por
 * uma escada apoiada no chão e encostada na parede e a altura da parede
 * onde está a ponta da escada. calcule e mostre a medida dessa escada.
 * Observação: as funções trigonométricas implementadas nas linguagens
 * de programação trabalham com medidas de ângulos em radianos.
 */

using System;

class A20
{
    static void Main(string[] args)
    {
        double ang, altParede, escada, rad;

        ang = double.Parse(Console.ReadLine());
        altParede = double.Parse(Console.ReadLine());

        // converte angulo em radianos
        rad = ang * 3.14159 / 180;

        // calcula comprimento da escada
        escada = altParede / Math.Sin(rad);

        Console.WriteLine(escada.ToString("F2"));
    }
}