int punktyBohater= 80;
int punktyPrzeciwnik = 60;
int liczbaMikstur = 2;
int tura = 1;

Random random = new Random();
int obrazBohatera = random.Next(8, 15);
int obrazPrzeciwnik = random.Next(5, 13);

bool graDziala = true;

Console.WriteLine($"TURA: {tura} ");
Console.WriteLine($"Zdrowie Bohatera: {punktyBohater}\nZdrowie Przeciwnika: {punktyPrzeciwnik} ");
Console.WriteLine($"Liczba mikstur: {liczbaMikstur} ");

while (graDziala || punktyBohater > 0)

{
    Console.WriteLine("Wybierz akcje: 1 - atak, 2 - mikstura, 3 - ucieczka.");
    int akcje = int.Parse(Console.ReadLine());

    switch (akcje)
    {
        
        case 1:
            
            for (int aktPunkty = 0; aktPunkty > 0 || ; aktPunkty++)

            /*if (punktyBohater > 0)
            {
                punktyBohater -= random.Next(8,15);
                punktyPrzeciwnik -= random.Next(5,13);
                tura++;
                Console.WriteLine($"TURA: {tura} ");
                Console.WriteLine($"Zdrowie Bohatera: {punktyBohater} ");
                Console.WriteLine($"Zdrowie Przeciwnika: {punktyPrzeciwnik} ");
            }
            else if (punktyBohater < 0)
            {
                Console.WriteLine("Bohater nie moż już atakować.");
            }
            else if (punktyPrzeciwnik < 0)
            {
                Console.WriteLine("Przeciwnik umarł. Zwycięstwo!");
            }
            break;*/
    }

}