using System;

public class Leitura
{
    public static double LerPontoVirgula()
    {
        while (true)
        {
            string input = Console.ReadLine().Replace(',', '.').Trim();

            if (double.TryParse(input, out double valor))
                return valor;

            Console.Write("Valor inválido. Digite novamente: ");
        }

    }
}
