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

    switch (action)
    {
        case "Dostawa":
            
            Console.WriteLine("O, fajne! Co dostawiłes?");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Ile?");
            int iloscDostawa = int.Parse(Console.ReadLine());

            if (magazyn.ContainsKey(nazwa))
            {
                magazyn[nazwa]+= iloscDostawa;
                Console.Write($"Cool! Teraz mamy: \n{nazwa}, {magazyn[nazwa]}");
            }
            else
            {
                {
                    magazyn.Add(nazwa, 1);
                    Console.WriteLine($"O wow! Nowa pozycja! \n{nazwa}, {magazyn[nazwa]} ");
                }
            }
            
            continue;
        

        case "Wydanie":
        
            Console.WriteLine("Okay, czego potrzebujesz?");

            while (true)
            {
                string nazwa;
                nazwa = Console.ReadLine();

                if (magazyn[nazwa] == 0)
                {
                    Console.WriteLine(
                        "Niestety, już nie mamy tej pozycji. :( \nWybierz inna pozicję lub usuń nieobecne.");
                    continue;
                }

                if (magazyn.ContainsKey(nazwa))
                {
                    magazyn[nazwa]--;
                    Console.WriteLine($"Proszę bardzo! Aktualny stan: {nazwa}, {magazyn[nazwa]} ");
                    Console.WriteLine("Coś jeszcze?");
                    continue;
                }

                if (nazwa == "Usunac")
                {
                    Console.WriteLine($"Okay, czego chcesz ucunać?");
                    foreach (var pozycja in magazyn)
                    {
                        Console.WriteLine($"{pozycja.Key}: {pozycja.Value}");
                        continue;
                    }

                    string usun = Console.ReadLine();

                    if (magazyn.ContainsKey(usun) && magazyn[usun] == 0)
                    {
                        magazyn.Remove(usun);
                        Console.WriteLine($"Pozycja {usun} zostala usujeta!");
                    }
                    else if (magazyn.ContainsKey(usun) && magazyn[usun] > 0)
                    {
                        Console.WriteLine($"Nie możemy to usunać.");
                        continue;
                    }
                }

                break;
            }

            continue;
        
        default:
        {
            Console.WriteLine("Nie rozumiem...");
            continue;
        }
    }
}
