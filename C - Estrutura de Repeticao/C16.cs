/* C16
 * Faça um programa para calcular a área de um triângulo e que não permita a
 * entrada de dados inválidos, ou seja, medidas menores ou iguais a 0.
 */

using System;

namespace C16
{
    class C16
    {
        static void Main(string[] args)
        {
            double bas, alt, area;

            Console.Write("Base: ");
            bas = double.Parse(Console.ReadLine());

            while (bas <= 0)
            {
                Console.Write("Base: ");
                bas = double.Parse(Console.ReadLine());
            }

            Console.Write("Altura: ");
            alt = double.Parse(Console.ReadLine());

            while (alt <= 0)
            {
                Console.Write("Altura: ");
                alt = double.Parse(Console.ReadLine());
            }

            area = bas * alt / 2;

            Console.WriteLine($"Área: {area}");
        }
    }
}
