/* C12
 * Em uma fábrica trabalham homens e mulheres divididos em três classes:
 * trabalhadores que fazem até 30 peças por mês — classe 1;
 * trabalhadores que fazem de 31 a 50 peças por mês — classe 2;
 * trabalhadores que fazem mais de 50 peças por mês — classe 3.
 * A classe 1 recebe salário mínimo. A classe 2 recebe salário mínimo mais 3%
 * deste salário por peça, acima das 30 peças iniciais. A classe 3 recebe
 * salário mínimo mais 5% desse salário por peça, acima das 30 peças iniciais.
 * Faça um programa que receba o número do operário, o número de peças
 * fabricadas no mês, o sexo do operário, e que também calcule e mostre:
 * o número do operário e seu salário;
 * o total da folha de pagamento da fábrica;
 * o número total de peças fabricadas no mês;
 * a média de peças fabricadas pelos homens;
 * a média de peças fabricadas pelas mulheres; e
 * o número do operário ou operária de maior salário.
 * A fábrica possui 15 operários.
 */

using System;

class C12
{
    static void Main()
    {
        int nOperario, nPeca, totPeca = 0, totHomens = 0, totMulheres = 0, totPecaHomens = 0;
        int totPecaMulheres = 0, opMaiorSal = 0, medPecasHomens, medPecasMulheres;
        double sal, maiorSal = 0, folhaPagamento = 0;
        char sexo;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write("Número do operário: ");
            nOperario = int.Parse(Console.ReadLine());
            Console.Write("Sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());
            Console.Write("Número de peças: ");
            nPeca = int.Parse(Console.ReadLine());
            
            if (nPeca <= 30)
            {
                sal = 998;
            }
            else if (nPeca <= 50)
            {
                sal = 998 + (0.03 * (nPeca - 30)) * 998;
            }
            else
            {
                sal = 998 + (0.05 * (nPeca - 30)) * 998;
            }

            Console.WriteLine($"Número do operário: {nOperario}, salário: {sal:C}");
            folhaPagamento += sal;
            totPeca += nPeca;

            if (sexo == 'F')
            {
                totMulheres++;
                totPecaMulheres += nPeca;
            }
            else
            {
                totHomens++;
                totPecaHomens += nPeca;
            }

            if (sal > maiorSal)
            {
                maiorSal = sal;
                opMaiorSal = nOperario;
            }
        }

        medPecasHomens = totPecaHomens / totHomens;
        medPecasMulheres = totPecaMulheres / totMulheres;
        
        Console.WriteLine($"Folha de pagamento: {folhaPagamento:C}");
        Console.WriteLine($"Total de peças fabricadas: {totPeca}");
        Console.WriteLine($"Média de peças feitas por homens: {medPecasHomens}");
        Console.WriteLine($"Média de peças feitas por mulheres: {medPecasMulheres}");
        Console.WriteLine($"Número do operário de maior salário: {opMaiorSal}");
    }
}