/* B13
 * Faça um programa que apresente o menu a seguir, permita ao usuário escolher a opção desejada, receba os dados
 * necessários para executar a operação e mostre o resultado. verifique a possibilidade de opção inválida e não
 * se preocupe com restrições, como salário negativo.
 * Menu de opções:
 * 1. Imposto
 * 2. Novo salário
 * 3. classificação
 * Digite a opção desejada.
 *
 * Na opção 1: receber o salário de um funcionário, calcular e mostrar o valor do imposto usando as regras a seguir.
 * Salário                                                  Percentual do imposto
 * Menor que R$ 500,00                                      5%
 * De R$ 500,00 (inclusive) a R$ 850,00 (inclusive)         10%
 * Acima de R$ 850,00                                       15%
 * 
 * Na opção 2: receber o salário de um funcionário, calcular e mostrar o valor do novo salário, usando as regras a seguir.
 * Salário                                                  Aumento
 * Maior que R$ 1.500,00                                    R$ 25,00
 * De R$ 750,00 (inclusive) a R$ 1.500,00 (inclusive)       R$ 50,00
 * De R$ 450,00 (inclusive) a R$ 750,00                     R$ 75,00
 * Menor que R$ 450,00                                      R$ 100,00
 * 
 * Na opção 3: receber o salário de um funcionário e mostrar sua classificação usando a tabela a seguir.
 * Salário                                                  Classificação
 * Até R$ 700,00 (inclusive)                                Mal remunerado
 * Maiores que R$ 700,00                                    Bem remunerado
*/

using System;

class B13
{
    static void Main(string[] args)
    {
        int op;
        double sal, novoSal, imp;

        Console.WriteLine("Menu de opções:");
        Console.WriteLine("1. Imposto");
        Console.WriteLine("2. Novo salário");
        Console.WriteLine("3. Classificação");
        Console.WriteLine("Digite a opção desejada.");
        op = int.Parse(Console.ReadLine());
        sal = double.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                if (sal < 500.00)
                {
                    imp = sal * 0.05;
                }
                else if (sal >= 500.00 && sal <= 850.00)
                {
                    imp = sal * 0.1;
                }
                else
                {
                    imp = sal * 0.15;
                }

                Console.WriteLine($"Imposto: {imp}%");
                break;

            case 2:
                if (sal > 1500.00)
                {
                    novoSal = sal + 25.00;
                }
                else if (sal >= 750.00 && sal <= 1500.00)
                {
                    novoSal = sal + 50.00;
                }
                else if (sal >= 450.00 && sal < 750.00)
                {
                    novoSal = sal + 75.00;
                }
                else
                {
                    novoSal = sal + 100.00;
                }

                Console.WriteLine($"Novo salário: {novoSal:C}");
                break;

            case 3:
                string resp = (sal <= 700.00) ? "Mal remunerado" : "Bem remunerado";
                Console.WriteLine(resp);
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}