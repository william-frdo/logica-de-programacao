/* B12
 * Faça um programa que receba o código correspondente ao cargo de um funcionário e seu salário atual
 * e mostre o cargo, o valor do aumento e seu novo salário. Os cargos estão na tabela a seguir.
 * 
 * Código   Cargo           Percentual
 * 1        Escriturário    50%
 * 2        Secretário      35%
 * 3        Caixa           20%
 * 4        Gerente         10%
 * 5        Diretor         Não tem aumento
 */

using System;

class B12
{
    static void Main(string[] args)
    {
        int cod;
        double sal, aumento = 0;
        string cargo = "";

        cod = int.Parse(Console.ReadLine());
        sal = int.Parse(Console.ReadLine());

        switch (cod)
        {
            case 1:
                aumento = sal * 0.5;
                cargo = "Escriturário";
                break;

            case 2:
                aumento = sal * 0.35;
                cargo = "Secretário";
                break;

            case 3:
                aumento = sal * 0.2;
                cargo = "Caixa";
                break;

            case 4:
                aumento = sal * 0.1;
                cargo = "Gerente";
                break;

            case 5:
                aumento = 0;
                cargo = "Diretor";
                break;

            default:
                break;
        }

        sal += aumento;

        Console.WriteLine($"{cargo}, aumento: {aumento:C}, novo salário: {sal:C}");
    }
}