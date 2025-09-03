using System;

public static class TipoInvestimento
{
    public static int LerTipo()
    {
        Console.WriteLine("Escolha o tipo de investimento:");
        Console.WriteLine("1 - Tesouro Selic");
        Console.WriteLine("2 - Tesouro IPCA");
        Console.WriteLine("3 - CDB");
        Console.WriteLine("4 - Poupança");
        Console.Write("Digite a opção (1-4): ");

        if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 1 || opcao > 4)
        {
            Console.WriteLine("Opção inválida.");
            Environment.Exit(1);
        }

        return opcao;
    }

    public static double ObterTaxa(int tipo)
    {
        return tipo switch
        {
            1 => 0.15,
            2 => 0.07,
            3 => 0.14,
            4 => 0.06,
            _ => 0
        };
    }
}
