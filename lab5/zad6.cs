Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};

Console.WriteLine("Hejka! Witamy w naszym magazyne! To nasz katalog:");

foreach (var pozycja in magazyn)
{
    Console.WriteLine($"{pozycja.Key}: {pozycja.Value}");
}

Console.WriteLine("Z czym do nas przyszedł?");
string action;

while (true)
{
    action = Console.ReadLine();
    
    if (int.TryParse(action, out int liczba))
    {
        Console.WriteLine("Nie rozumiem...");
        continue;
    }

    if (action == "Dostawa")
    {
        Console.WriteLine("O, fajne! Co dostawiłes?");
        string nazwa = Console.ReadLine();

        if (magazyn.ContainsKey(nazwa))
        {
            magazyn[nazwa]++;
            Console.Write($"Cool! Teraz mamy: \n{nazwa}, {magazyn[nazwa]}");
        }
        else
        {
            {
                magazyn.Add(nazwa, 1);
                Console.WriteLine($"O wow! Nowa pozycja! \n{nazwa}, {magazyn[nazwa]} ");
            }
        }
        
    }

    if (action == "Wydanie")
    {
        Console.WriteLine("Okay, czego potrzebujesz?");
        string nazwa; 

        do
        {
            nazwa = Console.ReadLine();
            magazyn[nazwa]--;
            Console.WriteLine($"Proszę bardzo! Aktualny stan: {nazwa}, {magazyn[nazwa]} ");
            Console.WriteLine("Coś jeszcze?");
            
            
            if (magazyn[nazwa] == 0)
                             {
                                 Console.WriteLine("Niestety, już nie mamy tej pozycji. :(");
                                 continue;
                             }
                             

        } while (magazyn.ContainsKey(nazwa) && magazyn[nazwa] > 0) ;
        
        
    }

   break;
}