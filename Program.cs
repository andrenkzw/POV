using System;

namespace POV;
class Program
{
    static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        => (int)Math.Truncate(totalNegociado * porcentagem / (1 - porcentagem));

    static void Main(string[] args)
    {
        Console.WriteLine(funcaoRetornaQuantitadePOV((decimal)0.1, 90));
        Console.WriteLine(funcaoRetornaQuantitadePOV((decimal)0.1, 100));
        Console.WriteLine(funcaoRetornaQuantitadePOV((decimal)0.2, 70));
    }
}
