/* C21
 * Faça um programa que receba vários números, calcule e mostre:
 * a soma dos números digitados;
 * a quantidade de números digitados;
 * a média dos números digitados;
 * o maior número digitado;
 * o menor número digitado;
 * a média dos números pares;
 * a porcentagem dos números ímpares entre todos os números digitados.
 * Finalize a entrada de dados com a digitação do número 30.000.
 */

using System;

class C21
{
	static void Main(string[] args)
	{
		int n, soma, somaPar, qtd, qtdPar, qtdImpar, media, maior, menor, mediaPar, percImpar;

		Console.WriteLine("Para parar digite 30000)");
		Console.Write("Digite um valor inteiro: ");
		n = int.Parse(Console.ReadLine());
		qtd = 0;
		qtdPar = 0;
		qtdImpar = 0;
		soma = 0;
		somaPar = 0;
		menor = n;
		maior = n;

		while (n != 30000)
		{
			if (n < menor)
			{
				menor = n;
			}

			if (n > maior)
			{
				maior = n;
			}

			if (n % 2 == 0)
			{
				somaPar += n;
				qtdPar++;
			}
			else
			{
				qtdImpar++;
			}

			soma += n;
			qtd++;

			Console.Write("Digite um valor inteiro: ");
			n = int.Parse(Console.ReadLine());
		}

		media = soma / qtd;
		mediaPar = somaPar / qtdPar;
		percImpar = qtdImpar * 100 / qtd;

		Console.WriteLine($"Soma dos números: {soma}");
		Console.WriteLine($"Quantidade de números: {qtd}");
		Console.WriteLine($"Média dos valores: {media}");
		Console.WriteLine($"Maior número: {maior}");
		Console.WriteLine($"Menor número: {menor}");
		Console.WriteLine($"Média dos pares: {mediaPar}");
		Console.WriteLine($"Porcentagem dos ímpares: {percImpar}%");
	}
}