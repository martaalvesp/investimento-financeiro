using System;

public static class Resultado
{
    public static void MostrarResultado(double saldoFinal, int meses, double depositoMensal, int mesSuperacao)
    {
        Console.WriteLine("\n=== Resultado Final ===");
        Console.WriteLine($"Saldo final após {meses} meses: R$ {saldoFinal:F2}");

        if (mesSuperacao > 0)
        {
            Console.WriteLine($"Os juros mensais passaram a ser maiores que o depósito mensal a partir do mês {mesSuperacao}.");
            int anos = mesSuperacao / 12;
            int mesesRestantes = mesSuperacao % 12;
            Console.WriteLine($"Isso corresponde a aproximadamente {anos} anos e {mesesRestantes} meses.");
        }
        else
        {
            Console.WriteLine("Os juros mensais nunca superaram o depósito mensal durante o período.");
        }
    }
}
