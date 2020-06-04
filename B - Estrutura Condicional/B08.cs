/* B08
 * Faça um programa que mostre o menu de opções a seguir, receba a opção
 * do usuário e os dados necessários para executar cada operação.
 * 
 * Menu de opções:
 * 1. Somar dois números.
 * 2. Raiz quadrada de um número.
 * Digite a opção desejada:
 */

using System;

class B08
{
    static void Main(string[] args)
    {
        int op;
        double n1, n2, sum, sqrt;

        Console.WriteLine("Menu de opções:");
        Console.WriteLine("1. Somar dois números.");
        Console.WriteLine("2. Raiz quadrada de um número.");
        Console.WriteLine("Digite a opção desejada:");

        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                sum = n1 + n2;
                Console.WriteLine(sum);
                break;

            case 2:
                n1 = double.Parse(Console.ReadLine());
                sqrt = Math.Sqrt(n1);
                Console.WriteLine(sqrt);
                break;

            default:
                break;
        }
    }
}