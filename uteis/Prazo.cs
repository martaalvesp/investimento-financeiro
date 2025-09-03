using System;

public static class Prazo
{
    public static int LerPrazo()
    {
        Console.Write("Informe o prazo de investimento (ex: 20 anos ou 240 meses): ");
        string prazoInput = Console.ReadLine().Trim().ToLower();

        if (prazoInput.EndsWith("anos"))
        {
            if (int.TryParse(prazoInput.Replace("anos", "").Trim(), out int anos))
                return anos * 12;
        }
        else if (prazoInput.EndsWith("meses"))
        {
            if (int.TryParse(prazoInput.Replace("meses", "").Trim(), out int meses))
                return meses;
        }

        Console.WriteLine("Prazo inválido. Use 'X anos' ou 'Y meses'.");
        Environment.Exit(1);
        return 0; // só para compilação
    }
}
