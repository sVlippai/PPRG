Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

Console.WriteLine($"Kupiec ma {ceny.Count} pozycji.");

foreach (var pozycja in ceny)
{
    Console.WriteLine($"{pozycja.Key}: {pozycja.Value} złotych");
    
}

while (true)
{
    Console.WriteLine("Co chcesz kupić?");

    string zakup = Console.ReadLine();

    if (ceny.ContainsKey(zakup))
    {
        Console.WriteLine($"Cena {zakup} wynośi {ceny[zakup]} złotych.");
        break;
    }
    else
    {
        Console.WriteLine("Kupic nie ma takiej pozycji.");
    }
    continue;
}

ceny["Mikstura"] = 12;
    
Console.WriteLine("Oh, poczekaj..Póki myśliałeś, kupic zmienił cene na miksturę.");
Console.WriteLine("Teraz ceny są takie:");
    
foreach (var pozycja in ceny)
{
    Console.WriteLine($"{pozycja.Key}: {pozycja.Value} złotych");
    
}