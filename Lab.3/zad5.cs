/*
Console.WriteLine("Hej, bohater! Podaj swoje punkty zycia:");
int punktyZycia = int.Parse(Console.ReadLine());
bool stan = punktyZycia > 0 && punktyZycia <= 30;

if (stan)
{
    Console.WriteLine("Masz niskie punkty zycia!");
    
}

Console.WriteLine("Podaj swoje podstawowe obrarzenia broni: ");
int obrazenia = int.Parse(Console.ReadLine());
Console.WriteLine("Czy masz miksture?");
bool mikstura = bool.Parse(Console.ReadLine());
Console.WriteLine("Wybierz akcje(1 — atak, 2 — leczenie, 3 — ucieczka):");
int akcje = int.Parse(Console.ReadLine());

if (punktyZycia <= 0)
{
    Console.WriteLine("Bohater nie zyje.");
}
else if (punktyZycia > 0)

    switch (akcje)
    {
        case 1:
            Console.WriteLine($"Twoje obrazeia: {obrazenia}");
            break;
        case 2:
            if (mikstura && punktyZycia < 100)
            {

                Console.WriteLine($"Twoje punkty zdrowia: {punktyZycia}. Uzyj miksture zeby wyleczyc sie.");
            }
            else
                Console.WriteLine("Nie masz mikstury zeby wyleczyc sie");

            break;
        case 3:
            if (mikstura && punktyZycia > 0 && obrazenia > 15)
            {
                Console.WriteLine("Mozesz uciec.");
            }
            else
            {
                Console.WriteLine("Nie mozesz uciec.");
            }

            break;
        default:
            Console.WriteLine("Nieznana akcja.");
            break;
    }
    */




