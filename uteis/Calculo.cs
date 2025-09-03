using System;

public static class Calculadora
{
    public static double CalcularTaxaMensal(double taxaAnual)
    {
        return Math.Pow(1 + taxaAnual, 1.0 / 12) - 1;
    }

    public static double CalcularSaldo(double valorInicial, double depositoMensal, int meses, double taxaMensal, out int mesSuperacao)
    {
        double saldo = valorInicial;
        bool jurosSuperamDeposito = false;
        mesSuperacao = 0;

        Console.WriteLine($"Taxa mensal equivalente: {taxaMensal * 100:F4}%");
        Console.WriteLine("\nMês\tSaldo\t\tJuros do mês\tDepósito mensal");
        Console.WriteLine("---------------------------------------------------------------");

        for (int mes = 1; mes <= meses; mes++)
        {
            double jurosMes = saldo * taxaMensal;
            saldo += jurosMes + depositoMensal;

            Console.WriteLine($"{mes}\tR$ {saldo:F2}\tR$ {jurosMes:F2}\t\tR$ {depositoMensal:F2}");

            if (!jurosSuperamDeposito && jurosMes > depositoMensal)
            {
                jurosSuperamDeposito = true;
                mesSuperacao = mes;
            }
        }

        return saldo;
    }
}
