/* A17
 * Um trabalhador recebeu seu salário e o depositou em sua conta bancária.
 * Esse trabalhador emitiu dois cheques e agora deseja saber seu saldo atual.
 * Sabe-se que cada operação bancária de retirada paga CPMF de 0,38% e o saldo
 * inicial da conta está zerado.
 */

using System;

class A17
{
    static void Main(string[] args)
    {
        double sal, cheque1, cheque2, saldo;

        sal = double.Parse(Console.ReadLine());
        cheque1 = double.Parse(Console.ReadLine());
        cheque2 = double.Parse(Console.ReadLine());

        saldo = sal - (cheque1 + cheque1 * 0.0038 + cheque2 + cheque2 * 0.0038);

        Console.WriteLine($"{saldo:C}");
    }
}