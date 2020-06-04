/* B11
 * Faça um programa que receba a hora do início de um jogo e a hora do término (cada hora é composta por duas
 * variáveis inteiras: hora e minuto). Calcule e mostre a duração do jogo (horas e minutos), sabendo que o
 * tempo máximo de duração do jogo é de 24 horas e que ele pode começar em um dia e terminar no dia seguinte.
 */

using System;

class B11
{
    static void Main(string[] args)
    {
        int hInicio, mInicio, hFinal, mFinal, hDuracao, mDuracao;

        hInicio = int.Parse(Console.ReadLine());
        mInicio = int.Parse(Console.ReadLine());
        hFinal = int.Parse(Console.ReadLine());
        mFinal = int.Parse(Console.ReadLine());

        if (mInicio > mFinal)
        {
            mFinal += 60;
            hFinal += -1;
        }

        if (hInicio > hFinal)
        {
            hFinal += 24;
        }

        mDuracao = mFinal - mInicio;
        hDuracao = hFinal - hInicio;

        Console.WriteLine($"{hDuracao}:{mDuracao}");
    }
}