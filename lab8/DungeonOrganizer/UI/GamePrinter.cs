namespace DungeonOrganizer.UI;

public static class GamePrinter
{
    public static void ShowHeader(string title)
    {
        Console.WriteLine($"=== {title.ToUpper()} ===");
    }

    public static void ShowCharacter(string name, int health)
    {
        Console.WriteLine($"{name}: {health} HP");
    }

    public static void ShowItem(string name, int price)
    {
        Console.WriteLine($"Przedmiot: {name}, cena: {price}");
    }

    public static void ShowWeapon(string name, int damage)
    {
        Console.WriteLine($"{name} zadaje {damage} obrażeń.");
    }

    public static void ShowSymbol(string symbol)
    {
        Console.WriteLine($"Symbol na mapie: {symbol}");
    }

}