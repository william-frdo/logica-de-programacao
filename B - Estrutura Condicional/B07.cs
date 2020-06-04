/* B07
 * Faça um programa que receba quatro valores: I, A, B e C. Desses valores,
 * I é inteiro e positivo, A, B e C são reais. Escreva os números A, B e C
 * obedecendo à tabela a seguir.
 * Suponha que o valor digitado para I seja sempre um valor válido, ou seja,
 * 1, 2 ou 3, e que os números digitados sejam diferentes um do outro.
 * 
 * VALOR DE I       FORMA A ESCREVER
 * 1                A, B e C em ordem crescente.
 * 2                A, B e C em ordem decrescente.
 * 3                O maior fica entre os outros dois números
 */

using System;

class B07
{
    static void Main(string[] args)
    {
        int i;
        double a, b, c;

        i = int.Parse(Console.ReadLine());
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        switch (i)
        {
            case 1:
                if (a < b && a < c)
                {
                    if (b < c)
                    {
                        Console.WriteLine($"{a}, {b}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{a}, {c}, {b}");
                    }
                }
                else if (b < a && b < c)
                {
                    if (a < c)
                    {
                        Console.WriteLine($"{b}, {a}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{b}, {c}, {a}");
                    }
                }
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine($"{c}, {a}, {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{c}, {b}, {a}");
                    }
                }
                break;

            case 2:
                if (a < b && a < c)
                {
                    if (b < c)
                    {
                        Console.WriteLine($"{c}, {b}, {a}");
                    }
                    else
                    {
                        Console.WriteLine($"{b}, {c}, {a}");
                    }
                }
                else if (b < a && b < c)
                {
                    if (a < c)
                    {
                        Console.WriteLine($"{c}, {a}, {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{a}, {c}, {b}");
                    }
                }
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine($"{b}, {a}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{a}, {b}, {c}");
                    }
                }
                break;

            case 3:
                if (a < b && a < c)
                {
                    if (b < c)
                    {
                        Console.WriteLine($"{b}, {a}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c}, {a}, {b}");
                    }
                }
                else if (b < a && b < c)
                {
                    if (a < c)
                    {
                        Console.WriteLine($"{a}, {b}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c}, {b}, {a}");
                    }
                }
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine($"{a}, {c}, {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{b}, {c}, {a}");
                    }
                }
                break;

            default:
                break;
        }
    }
}