using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Simulador de Investimentos ===");

        Console.Write("Informe o valor inicial a ser depositado (R$): ");
        double valorInicial = Leitura.LerPontoVirgula();

        Console.Write("Informe o depósito mensal (R$): ");
        double depositoMensal = Leitura.LerPontoVirgula();

        int meses = Prazo.LerPrazo();

        int tipo = TipoInvestimento.LerTipo();

        double taxaAnual = TipoInvestimento.ObterTaxa(tipo);

        double taxaMensal = Calculadora.CalcularTaxaMensal(taxaAnual);

        double saldoFinal = Calculadora.CalcularSaldo(valorInicial, depositoMensal, meses, taxaMensal, out int mesSuperacao);

        Resultado.MostrarResultado(saldoFinal, meses, depositoMensal, mesSuperacao);
    }
}
