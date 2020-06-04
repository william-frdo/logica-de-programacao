/* C17
 * Faça um programa que receba o salário de um funcionário chamado Carlos. Sabe-se
 * que outro funcionário, João, tem salário equivalente a um terço do salário de
 * Carlos. Carlos aplicará seu salário integralmente na caderneta de poupança, que
 * rende 2% ao mês, e João aplicará seu salário integralmente no fundo de renda fixa,
 * que rende 5% ao mês. O programa deverá calcular e mostrar a quantidade de meses
 * necessários para que o valor pertencente a João iguale ou ultrapasse o valor
 * pertencente a Carlos.
 */

using System;

namespace C17
{
    class C17
    {
        static void Main(string[] args)
        {
            int meses;
            double salCarlos, salJoao, poupanca, rendaFixa;

            Console.Write("Salário de Carlos: ");
            salCarlos = double.Parse(Console.ReadLine());
            
            salJoao = salCarlos / 3;
            poupanca = salCarlos;
            rendaFixa = salJoao;
            meses = 0;

            while (rendaFixa < poupanca)
            {
                poupanca += poupanca * 0.02;
                rendaFixa += rendaFixa * 0.05;
                meses++;
            }

            Console.WriteLine($"Quantidade necessária de meses: {meses}");
        }
    }
}
