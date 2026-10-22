static class Konzol
{
    public static void Cim(string szoveg)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"═══ {szoveg} ═══");
        Console.ResetColor();
    }

    public static void Siker(string szoveg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"✔ {szoveg}");
        Console.ResetColor();
    }

    public static void Hiba(string szoveg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"✘ {szoveg}");
        Console.ResetColor();
    }
}