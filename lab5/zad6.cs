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

string action;
bool wydanie = true;
bool dostawa = true;
bool usunac = true;
bool otwarcie = true;

while (otwarcie)
    
{
    Console.WriteLine("Co robimy teraz?");
    action = Console.ReadLine();

    switch (action)
    
    {
        
        case "Dostawa":

            while (dostawa)
            {
                Console.WriteLine("Co dostawiłes?");
                string key = Console.ReadLine();
                
                 
                if (key == "Zakonczenie")
                {
                    dostawa = false;
                    break;
                }
                
                Console.WriteLine("Ile?");
                int iloscDostawa = int.Parse(Console.ReadLine());

                while (iloscDostawa == 0 || iloscDostawa < 0)
                {
                    Console.WriteLine("Jeszcze raz..");
                    iloscDostawa = int.Parse(Console.ReadLine());
                }

                if (magazyn.ContainsKey(key))
                {
                    magazyn[key] += iloscDostawa;
                    Console.WriteLine($"Cool! Teraz mamy: \n{key}, {magazyn[key]}");
                }
                else
                {
                    magazyn.Add(key, iloscDostawa);
                    Console.WriteLine($"O wow! Nowa pozycja! \n{key}, {magazyn[key]} ");
                }
            }
            continue;
        

        case "Wydanie":
            
            while (wydanie)
            {
                 Console.WriteLine("Wybierz pozycję i ilość.");
                 string nazwa = Console.ReadLine();
                 
                 foreach (var pozycja in magazyn)
                 {
                     Console.WriteLine($"{pozycja.Key}: {pozycja.Value}");
                 }
                 
                if (nazwa == "Zakonczenie")
                {
                    wydanie = false;
                    break;
                }
                
                int ilosc;
                ilosc = int.Parse(Console.ReadLine());

                if (magazyn[nazwa] == 0)
                {
                    Console.WriteLine(
                        "Niestety, już nie mamy tej pozycji. :( \nWybierz inna pozicję.");
                    continue;
                }

                if (magazyn.ContainsKey(nazwa) && magazyn[nazwa] > 0)
                {
                    magazyn[nazwa] -= ilosc;

                    if (magazyn[nazwa] < 0)
                    {
                        magazyn[nazwa] += ilosc;
                        Console.WriteLine("Nie mamy tyle..");
                        continue;
                    }
                    
                    Console.WriteLine($"Proszę bardzo! Aktualny stan: {nazwa}, {magazyn[nazwa]} ");
                    Console.WriteLine("Coś jeszcze?");
                    
                }
                
            }
            continue;
            
        case "Usunac":

            while (usunac)
            {
                Console.WriteLine("Czego chcesz ucunać?");

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
                }
            }
            continue;

        case "Zakonczenie":
        {
            otwarcie = false;
        }
            break;

        default:
        {
            Console.WriteLine("Nie rozumiem...");
            
        }
        continue;
    }
}
