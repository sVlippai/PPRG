/*
bool gra = true;
int ekspLiczba = 0;
int odpoczLiczba = 0;
int przedmLiczba = 0;

List<string> historia = new List<string>(); 

while (gra)
{
    Console.WriteLine("Wybierz opcję z menu:\n1-Eksploruj\n2-Odpocznij\n3-Zhajdź przedmiot");
    Console.WriteLine("4 - Pokaż całą historię\n5 - Pokaż ostatnie trzy wpisy\n6 - Policz wybraną akcję\n7 - Wyczyść historię\n8 - Zakończ");
    string opcja = Console.ReadLine();

    switch (opcja)
    {
        case "1":
            historia.Add("Eksploracja");
            ekspLiczba++;
            continue;
        case "2":
            historia.Add("Odpocznynek");
            odpoczLiczba++;
            continue;
        case "3":
            historia.Add("Znaleziono przedmiot");
            przedmLiczba++;
            continue;
        
        case "4":
            if (historia.Count == 0)
            {
                Console.WriteLine("Nie masz zapisów w swojej historii.");
                break;
            }
            
            foreach (var akcja in historia)
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(akcja);
                Console.ResetColor();
            }
            continue;
        case "5":
            if (historia.Count == 0)
            {
                Console.WriteLine("Nie masz zapisów w swojej historii.");
                break;
            }

            if (historia.Count < 3)
            {
                Console.WriteLine($"Masz tylko {historia.Count} zapisów w swojej historii.");
                break;
            }
            
            for (int index = historia.Count - 3; index < historia.Count; index++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(historia[index]);
                Console.ResetColor();
            }
            continue;
        case "6":
            Console.WriteLine("Podaj akcje:");
            Console.WriteLine("Eksploracja, Odpoczynek, Przedmiot");
            string action = Console.ReadLine();

            switch (action)
            {
                case "Eksploracja":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Akcja występuje {ekspLiczba} raz/y.");
                        Console.ResetColor();
                    continue;
                
                case "Odpoczynek":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Akcja występuje {odpoczLiczba} raz/y.");
                        Console.ResetColor();
                    continue;
                
                case "Przedmiot":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Akcja występuje {przedmLiczba} raz/y.");
                        Console.ResetColor();
                    continue;
            }
            continue;
        
        case "7":
            Console.WriteLine("Naprawdę chesz wyczyścić historię?(t/n)");
            string znak = Console.ReadLine();

            if (znak == "t")
            {
                historia.Clear();
                Console.WriteLine("Historia zostala wyczyszczona.");
                break;
            }

            if (znak == "n")
            {
                break;
            }
            continue;
        
        case "8":
            gra = false;
            break;
        default:
        {
            Console.WriteLine("Nieznana opcja.");
            continue;
        }
    }
}
*/

