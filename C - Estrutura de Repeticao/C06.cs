/* C06
   Uma empresa possui dez funcionários com as seguintes características: código, número de
   horas trabalhadas no mês, turno de trabalho (M — matutino; V — vespertino; ou N — noturno),
   categoria (O — operário; ou G — gerente), valor da hora trabalhada. Sabendo-se que essa
   empresa deseja informatizar sua folha de pagamento, faça um programa que:
   a) leia as informações dos funcionários, exceto o valor da hora trabalhada, não permitindo
   que sejam informados turnos e nem categorias inexistentes. Trabalhe sempre com a digitação
   de letras maiúsculas.
   b) Calcule o valor da hora trabalhada, conforme a tabela a seguir. Adote o valor de R$ 450,00
   para o salário mínimo.
    
   CATEGORIA | TURNO  | VALOR DA HORA TRABALHADA
   G         | N      | 18% do salário mínimo
   G         | M ou V | 15% do salário mínimo
   O         | N      | 13% do salário mínimo
   O         | M ou V | 10% do salário mínimo

   c) Calcule o salário inicial dos funcionários com base no valor da hora trabalhada e no
   número de horas trabalhadas.
   d) Calcule o valor do auxílio alimentação recebido pelo funcionário de acordo com seu
   salário inicial, conforme a tabela a seguir.

   SALÁRIO INICIAL              | AUXÍLIO ALIMENTAÇÃO
   Até R$ 300,00                | 20% do salário inicial
   Entre R$ 300,00 e R$ 600,00  | 15% do salário inicial
   Acima de R$ 600,00           | 5% do salário inicial

   e) Mostre o código, número de horas trabalhadas, valor da hora trabalhada, salário inicial,
   auxílio alimentação e salário final (salário inicial + auxílio alimentação)
*/

using System;

class C06
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            double vHora = 0, sInicial, sFinal, aux;

            int cod = int.Parse(Console.ReadLine());
            int hMes = int.Parse(Console.ReadLine());
            char turno = char.Parse(Console.ReadLine());

            while (turno != 'M' && turno != 'V' && turno != 'N')
            {
                Console.Write("Turno inválido! Digite M, V ou N: ");
                turno = char.Parse(Console.ReadLine());
            }

            char categ = char.Parse(Console.ReadLine());

            while (categ != 'O' && categ != 'G')
            {
                Console.Write("Categoria inválida! Digite O ou G: ");
                categ = char.Parse(Console.ReadLine());
            }

            if (categ == 'G')
            {
                if (turno == 'N')
                {
                    vHora = 450.00 * 0.18;
                }
                else
                {
                    vHora = 450.00 * 0.15;
                }
            }
            else
            {
                if (turno == 'N')
                {
                    vHora = 450.00 * 0.13;
                }
                else
                {
                    vHora = 450.00 * 0.10;
                }
            }

            sInicial = hMes * vHora;

            if (sInicial <= 300.00)
            {
                aux = sInicial * 0.20;
            }
            else if (sInicial <= 600.00)
            {
                aux = sInicial * 0.15;
            }
            else
            {
                aux = sInicial * 0.05;
            }

            sFinal = sInicial + aux;

            Console.WriteLine($"{i}º Funcionário: {cod}, {hMes}, {vHora}, {sInicial}, {aux}, {sFinal}");
        }
    }
}