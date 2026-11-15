Player player = new Player("Maciuś", 100, 60, 1, 35, 50, 15);
int itemLecz = 0;
List<Item> medicines = new List<Item>
{
    new Item("Mikstura",15,3),
    new Item("Zioła",10, 5),
    new Item("Hotdog", 20,2 )
};

List<Item> invertory = new List<Item>
{
    new Item("Miecz", 15,1),
    new Item("Jajco",3,5)
};

void Medicine()
{
    foreach (Item item in medicines)
    {
        Console.WriteLine($"{medicines.IndexOf(item) + 1}. {item.Name}, {item.Power}, {item.Amount} ");
    }
}

void Invertory()
{
    foreach (Item item in invertory)
    {
        Console.WriteLine($"{invertory.IndexOf(item) + 1}. {item.Name}, {item.Power}, {item.Amount} ");
    }
}

void Choice()
{
    while (true)
    {
        bool format = int.TryParse(Console.ReadLine(), out itemLecz);

        if (!format)
        {
            Console.WriteLine("Wpisz liczbę.");
            continue;
        }

        if (itemLecz <= 0)
        {
            Console.WriteLine("Wybierz liczbę dodatna.");
            continue;
        }

        if (itemLecz - 1 >= medicines.Count)
        {
            Console.WriteLine("Wybierz liczbę od 1 do 5.");

        }

        else
        {
            break;
        }
    }
}
Invertory();
Console.WriteLine("------------------------");
Medicine();
Console.WriteLine("Wybierz przedmiot leczniczy.");
Choice();
Item selectedItem = medicines[itemLecz - 1];
Item itemInInvertory = new Item(selectedItem.Name, selectedItem.Power, 1);
invertory.Add(itemInInvertory);
Invertory();
Console.WriteLine("Używasz wybranego przedmiotu?");
string answer = Console.ReadLine();
if (answer == "y")
{
   itemInInvertory.Use();
   player.Heal(itemInInvertory.Power);
   medicines[itemLecz - 1].Use();
   Console.WriteLine($"Twoje zdrowie: {player.Health}");
   Invertory();
   Console.WriteLine("------------------------");
   Medicine();
   
}

if (answer == "n")
{
    Console.WriteLine($"Twoje zdrowie: {player.Health}");
       Invertory();
       Console.WriteLine("------------------------");
       Medicine(); 
}