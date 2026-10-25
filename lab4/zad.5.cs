/*int punktyBohater= 80;
int punktyPrzeciwnik = 60;
int liczbaMikstur = 3;
int tura = 1;

Random random = new Random();
int obrazBohatera = random.Next(8, 15);
int obrazPrzeciwnik = random.Next(5, 13);

bool graDziala = true;

Console.WriteLine($"TURA: {tura} ");
Console.WriteLine($"Zdrowie Bohatera: {punktyBohater}\nZdrowie Przeciwnika: {punktyPrzeciwnik} ");
Console.WriteLine($"Liczba mikstur: {liczbaMikstur} ");

while (graDziala)

{
    Console.WriteLine("Wybierz akcje: 1 - atak, 2 - mikstura, 3 - ucieczka.");
    int akcje = int.Parse(Console.ReadLine());

    switch (akcje)
    {

        case 1:

            while (punktyBohater > 0 && punktyPrzeciwnik > 0)
            {
                punktyPrzeciwnik -= random.Next(5, 13);
                punktyBohater -= random.Next(8, 15);
                tura++;
                Console.WriteLine($"TURA: {tura} ");
                Console.WriteLine($"Zdrowie Bohatera: {punktyBohater} ");
                Console.WriteLine($"Zdrowie Przeciwnika: {punktyPrzeciwnik} ");
                break;
            }


            if (punktyBohater <= 0)
            {
                Console.WriteLine("Bohater nie moż już atakować. Walka przegrana...");
                graDziala = false;

            }
            else if (punktyPrzeciwnik <= 0)
            {
                Console.WriteLine("Przeciwnik umarł. Zwycięstwo!");
                graDziala = false;
            }

            continue;
        
        case 2:
            
            while (liczbaMikstur >= 0)
            {
                punktyBohater += 15;
                liczbaMikstur --;
                Console.WriteLine($"TURA: {tura} ");
                Console.WriteLine($"Zdrowie Bohatera: {punktyBohater} ");
                Console.WriteLine($"Zdrowie Przeciwnika: {punktyPrzeciwnik} ");
                break;
            }

            if (liczbaMikstur == 0)
            {
                Console.WriteLine("Nie masz mikstur do uzycia.");
            }

            break;
        
        case 3:
            graDziala = false;
            Console.WriteLine("Bohater uciekł. Walka skończona z wynikiem:");
            Console.WriteLine($"Liczba tur: {tura} ");
            Console.WriteLine($"Zdrowie Bohatera: {punktyBohater} ");
            Console.WriteLine($"Zdrowie Przeciwnika: {punktyPrzeciwnik} ");
            break;
        
        default:
            Console.WriteLine("Nie ma takie akcji.");
            break;
    }

   

}*/