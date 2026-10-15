/*Console.WriteLine("Hej,bohater! Podaj swoje punkty zycia:");
int punktyZycia = int.Parse(Console.ReadLine());
Console.WriteLine("Czy masz klucz?(t/f)");
bool klucz = bool.Parse(Console.ReadLine());
Console.WriteLine("Czy znasz haslo?(t/f)");
bool haslo = bool.Parse(Console.ReadLine());
bool zyje = punktyZycia > 0;
bool wejsce =  klucz && haslo;

if (zyje && wejsce)
{
    Console.WriteLine($"Punkty zycia: {punktyZycia}\nMa klucz: {klucz}\nZna haslo: {haslo}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Bohater może wejść do lochu.");
}
else if (!zyje) 
{
    Console.WriteLine($"Punkty zycia: {punktyZycia}\nMa klucz: {klucz}\nZna haslo: {haslo}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie może wejść - nie zyje.");
    
}
else if (!wejsce && zyje)
{   Console.WriteLine($"Punkty zycia: {punktyZycia}\nMa klucz: {klucz}\nZna haslo: {haslo}");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Bohater nie może wejść - nie ma sposobu otwarcia drzwi.");

}*/