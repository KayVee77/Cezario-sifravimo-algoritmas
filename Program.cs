using System;

class Program
{
    static char[] abecele = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    static void Main()
    {
        Console.WriteLine("Iveskite savo pasirinkima: ");
        Console.WriteLine("1 - Sifravimas" +
            "\n2 - Desifravimas" +
            "\n3 - ASCII Sifravimas" +
            "\n4 - ASCII Desifravimas");
        int pasirinkimas = int.Parse(Console.ReadLine());

        Console.Write("Iveskite teksta: ");
        string tekstas = Console.ReadLine();

        Console.Write("Iveskite poslinki: ");
        int poslinkis = int.Parse(Console.ReadLine());

        switch (pasirinkimas)
        {
            case 1:
                Console.WriteLine("Sifruotas tekstas: " + CezarioAlgoritmas(tekstas.ToUpper(), poslinkis));
                break;
            case 2:
                Console.WriteLine("Desifruotas tekstas: " + CezarioAlgoritmasDesifravimas(tekstas.ToUpper(), poslinkis));
                break;
            case 3:
                Console.WriteLine("Sifruotas tekstas ASCII: " + CezarioAlgoritmasAscii(tekstas, poslinkis));
                break;
            case 4:
                Console.WriteLine("Desifruotas tekstas ASCII: " + CezarioAlgoritmasAsciiDesifravimas(tekstas, poslinkis));
                break;
            default:
                Console.WriteLine("Neteisingas pasirinkimas.");
                break;
        }
    }

    public static string CezarioAlgoritmas(string tekstas, int poslinkis)
    {
        string rezultatas = "";
        foreach (char c in tekstas)
        {
            if (char.IsLetter(c))
            {
                bool isUpperCase = char.IsUpper(c);
                char offset = isUpperCase ? 'A' : 'a';
                int indexas = (c - offset + poslinkis) % 26;
                rezultatas += (char)(indexas + offset);
            }
            else
            {
                rezultatas += c;
            }
        }
        return rezultatas;
    }

    public static string CezarioAlgoritmasDesifravimas(string tekstas, int poslinkis)
    {
        string rezultatas = "";
        foreach (char c in tekstas)
        {
            if (char.IsLetter(c))
            {
                bool isUpperCase = char.IsUpper(c);
                char offset = isUpperCase ? 'A' : 'a';
                int indexas = (c - offset - poslinkis + 26) % 26;
                rezultatas += (char)(indexas + offset);
            }
            else
            {
                rezultatas += c;
            }
        }
        return rezultatas;
    }

    public static string CezarioAlgoritmasAscii(string tekstas, int poslinkis)
    {
        string rezultatas = "";
        foreach (char c in tekstas)
        {
            if (c >= ' ' && c <= '~')
            {
                int naujasSimbolis = ((c - ' ') + poslinkis) % 95 + ' ';
                rezultatas += (char)naujasSimbolis;
            }
            else
            {
                rezultatas += c;
            }
        }
        return rezultatas;
    }
    public static string CezarioAlgoritmasAsciiDesifravimas(string tekstas, int poslinkis)
    {
        string rezultatas = "";
        foreach (char c in tekstas)
        {
            if (c >= ' ' && c <= '~')
            {
                int naujasSimbolis = (c - ' ' - poslinkis + 95) % 95 + ' ';
                rezultatas += (char)naujasSimbolis;
            }
            else
            {
                rezultatas += c;
            }
        }
        return rezultatas.Trim();
    }
}




