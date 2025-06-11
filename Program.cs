using System;
using System.Text.RegularExpressions;

namespace Validador_De_Bandeira
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do cartão:");
            string numeroCartao = Console.ReadLine();

            string bandeira = IdentificarBandeira(numeroCartao);

            if (bandeira != null)
                Console.WriteLine($"Bandeira identificada: {bandeira}");
            else
                Console.WriteLine("Bandeira não identificada.");
        }

        public static string IdentificarBandeira(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
                return null;

            // Visa: começa com 4
            if (Regex.IsMatch(numero, @"^4"))
                return "Visa";

            // MasterCard: 51-55 ou 2221-2720
            if (Regex.IsMatch(numero, @"^(5[1-5])") || Regex.IsMatch(numero, @"^(222[1-9]|22[3-9]\d|2[3-6]\d{2}|27[01]\d|2720)"))
                return "MasterCard";

            // Elo: exemplos comuns
            if (Regex.IsMatch(numero, @"^(4011|4312|4389)"))
                return "Elo";

            // American Express: 34 ou 37
            if (Regex.IsMatch(numero, @"^(34|37)"))
                return "American Express";

            // Discover: 6011, 65, 644-649
            if (Regex.IsMatch(numero, @"^(6011|65|64[4-9])"))
                return "Discover";

            // Hipercard: 6062
            if (Regex.IsMatch(numero, @"^6062"))
                return "Hipercard";

            // Diners Club: 300-305, 36, 38
            if (Regex.IsMatch(numero, @"^(30[0-5]|36|38)"))
                return "Diners Club";

            // EnRoute: 2014 ou 2149
            if (Regex.IsMatch(numero, @"^(2014|2149)"))
                return "EnRoute";

            // JCB: começa com 35
            if (Regex.IsMatch(numero, @"^35"))
                return "JCB";

            // Voyager: começa com 8699
            if (Regex.IsMatch(numero, @"^8699"))
                return "Voyager";

            // Aura: começa com 50
            if (Regex.IsMatch(numero, @"^50"))
                return "Aura";

            return null;
        }

    }
}
