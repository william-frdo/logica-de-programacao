/* B10
 * Faça um programa que determine a data cronologicamente maior entre duas datas fornecidas pelo usuário.
 * Cada data deve ser composta por três valores inteiros, em que o primeiro representa o dia, o segundo,
 * o mês e o terceiro, o ano.
 */

using System;

class B10
{
    static void Main(string[] args)
    {
        int dd1, mm1, aaaa1, dd2, mm2, aaaa2;

        dd1 = int.Parse(Console.ReadLine());
        mm1 = int.Parse(Console.ReadLine());
        aaaa1 = int.Parse(Console.ReadLine());

        Console.WriteLine();

        dd2 = int.Parse(Console.ReadLine());
        mm2 = int.Parse(Console.ReadLine());
        aaaa2 = int.Parse(Console.ReadLine());

        if (aaaa1 >= aaaa2)
        {
            if (mm1 >= mm2)
            {
                if (dd1 >= dd2)
                {
                    Console.WriteLine($"\n{dd1}/{mm1}/{aaaa1}");
                }
                else
                {
                    Console.WriteLine($"\n{dd2}/{mm1}/{aaaa1}");
                }
            }
            else
            {
                Console.WriteLine($"\n{dd2}/{mm2}/{aaaa1}");
            }
        }
        else
        {
            Console.WriteLine($"\n{dd2}/{mm2}/{aaaa2}");
        }
    }
}