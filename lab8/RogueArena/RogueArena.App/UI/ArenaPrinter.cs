namespace RogueArena.App.UI;

public static class ArenaPrinter
{
    public static void ShowTitle(string title)
    {
        Console.WriteLine($"=== {title.ToUpper()} ===");
    }

    public static void ShowHealth(string name, int health)
    {
        Console.WriteLine($"{name}: {health} HP");
    }
    
    public static void ShowInventory()
    {
        foreach (Item item in Inventory.Items)
        {
            Console.WriteLine($"{item.Name}: {item.Price} zlota.");
        }
    }
}