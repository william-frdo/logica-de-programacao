/* B17
 * Faça um programa para resolver equações do 2º grau.
 * ax² + bx + c = 0
 * A variável a deve ser diferente de zero.
 * ∆ = b² -4 * a * c
 * ∆ < 0 → não existe raiz real
 * ∆ = 0 → existe uma raiz real:
 * x = (-b) / (2 * a)
 * ∆ > 0 → existem duas raízes reais:
 * x1 = (-b + ²√∆)/ (2 * a)
 * x2 = (-b - ²√∆)/ (2 * a)
 */

using System;

class B17
{
    static void Main(string[] args)
    {
        double a, b, c, delta, x1, x2;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("O valor de a tem que ser diferente de zero!");
        }
        else
        {
            delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta == 0)
            {
                x1 = (-b) / (2 * a);

                Console.WriteLine($"x = : {x1}");
            }
            else if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Não existe raiz");
            }
        }
    }
}