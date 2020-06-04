/* C24
 * Faça um programa que apresente o menu de opções a seguir, permita ao usuário escolher a opção
 * desejada, receba os dados necessários para executar a operação e mostre o resultado. Verifique
 * a possibilidade de opção inválida e não se preocupe com restrições do tipo salário inválido.
 * 
 * Menu de opções:
 * 1. Imposto
 * 2. Novo salário
 * 3. Classificação
 * 4. Finalizar o programa
 * Digite a opção desejada.
 * 
 * Na opção 1: receber o salário de um funcionário, calcular e mostrar o valor do imposto usando
 * as regras a seguir.
 * SALÁRIOS                 | % DO IMPOSTO
 * Menor que R$ 500,00      | 5
 * De R$ 500,00 a R$ 850,00 | 10
 * Acima de R$ 850,00       | 15
 *
 * Na opção 2: receber o salário de um funcionário, calcular e mostrar o valor do novo salário
 * usando as regras a seguir. 
 * SALÁRIOS                                           | AUMENTO
 * Maiores que R$ 1.500,00                            | R$ 25,00
 * De R$ 750,00 (inclusive) a R$ 1.500,00 (inclusive) | R$ 50,00
 * De R$ 450,00 (inclusive) a R$ 750,00               | R$ 75,00
 * Menores que R$ 450,00                              | R$ 100,00
 * 
 * Na opção 3: receber o salário de um funcionário e mostrar sua classificação usando esta tabela:
 * SALÁRIOS              | CLASSIFICAÇÃO
 * Até R$ 700,00         | Mal remunerado
 * Maiores que R$ 700,00 | Bem remunerado
 */

using System;

class C24
{
	static void Main(string[] args)
	{
		Console.WriteLine("Menu de opções:");
		Console.WriteLine("1. Imposto");
		Console.WriteLine("2. Novo salário");
		Console.WriteLine("3. Classificação");
		Console.WriteLine("4. Finalizar o programa");
		Console.WriteLine("Digite a opção desejada.");
		int op = int.Parse(Console.ReadLine());

		while (op != 4)
		{
			if (op <= 0 || op >= 5)
			{
				Console.WriteLine("Opção inválida.");
			}
			else
			{
				Console.Write("Digite o salário: ");
				double sal = double.Parse(Console.ReadLine());

				if (op == 1)
				{
					double imp = 0;

					if (sal < 500)
					{
						imp = sal * 5 / 100;
					}
					else if (sal < 850)
					{
						imp = sal * 10 / 100;
					}
					else
					{
						imp = sal * 15 / 100;
					}

					Console.WriteLine($"Valor do imposto: {imp:C}");
				}

				if (op == 2)
				{
					if (sal < 450)
					{
						sal += 100;
					}
					else if (sal < 750)
					{
						sal += 75;
					}
					else if (sal <= 1500)
					{
						sal += 50;
					}
					else
					{
						sal += 25;
					}

					Console.WriteLine($"Novo salário: {sal:C}");
				}

				if (op == 3)
				{
					if (sal <= 700)
					{
						Console.WriteLine("Mal remunerado");
					}
					else
					{
						Console.WriteLine("Bem remunerado");
					}
				}
			}

			Console.WriteLine();
			Console.WriteLine("Menu de opções:");
			Console.WriteLine("1. Imposto");
			Console.WriteLine("2. Novo salário");
			Console.WriteLine("3. Classificação");
			Console.WriteLine("4. Finalizar o programa");
			Console.WriteLine("Digite a opção desejada.");
			op = int.Parse(Console.ReadLine());
		}            
	}
}
