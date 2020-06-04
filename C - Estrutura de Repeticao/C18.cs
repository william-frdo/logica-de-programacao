/* C18
 * Faça um programa que leia um conjunto não determinado de valores e mostre o valor
 * lido, seu quadrado, seu cubo e sua raiz quadrada. Finalize a entrada de dados com
 * um valor negativo ou zero.
 */

using System;

namespace C18
{
    class C18
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            double n = double.Parse(Console.ReadLine());
            
            while (n > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine(Math.Pow(n, 2));
                Console.WriteLine(Math.Pow(n, 3));
                Console.WriteLine(Math.Sqrt(n));

                Console.Write("Informe um número: ");
                n = double.Parse(Console.ReadLine());
            } 
            
        }
    }
}
