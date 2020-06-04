/* B19
 * Faça um programa que receba a altura e o peso de uma pessoa. De acordo com a tabela a seguir,
 * verifique e mostre a classificação dessa pessoa.
 * 
 *                    |                       PESO                       |
 * -------------------|--------------------------------------------------|                   
 * ALTURA             | ATÉ 60 | ENTRE 60 E 90 (INCLUSIVE) | ACIMA DE 90 |
 * -------------------|--------|---------------------------|-------------|
 * Menores que 1,20   | A      | D                         | G           |
 * De 1,20 a 1,70     | B      | E                         | H           |
 * Maiores que 1,70   | C      | F                         | I           |
 */

using System;

class B19
{
    static void Main(string[] args)
    {
        double altura = double.Parse(Console.ReadLine());
        double peso = double.Parse(Console.ReadLine());

        if (altura < 1.20)
        {
            if (peso <= 60)
            {
                Console.WriteLine("A");
            }
            else if (peso <= 90)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("G");
            }
        }
        else if (altura <= 1.70)
        {
            if (peso <= 60)
            {
                Console.WriteLine("B");
            }
            else if (peso <= 90)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("H");
            }
        }
        else
        {
            if (peso <= 60)
            {
                Console.WriteLine("C");
            }
            else if (peso <= 90)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("I");
            }
        }
    }
}