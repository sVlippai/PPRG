int tura;
int suma = 0;

while (true)
{
        Console.WriteLine("Podaj liczbe tur od 1 do 10.");
        tura = int.Parse(Console.ReadLine());
        
        if(tura < 1 || tura > 10)
        {
                Console.WriteLine("Liczba powinna być w okresie od 1 do 10.");
                continue;
        }

        break;
}

int[] zlotoWTur = new int[tura];
int najmniejsze = zlotoWTur[0];
int najwieksze = zlotoWTur[0];
int wynik = 0;

for (int ind = 0; ind < zlotoWTur.Length; ind++)
{
        Console.Write($"Złoto w turze {ind + 1}: ");
        zlotoWTur[ind] = int.Parse(Console.ReadLine()!);
        suma += zlotoWTur[ind];
        
        if (zlotoWTur[ind] < najmniejsze)
        {
                najmniejsze = zlotoWTur[ind];
        }

        if (zlotoWTur[ind] > najwieksze)
        {
                najwieksze = zlotoWTur[ind];
        }
        
        if (zlotoWTur[ind] == najwieksze)
        {
                wynik++;
        }
}
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Minimum: {najmniejsze}");
Console.WriteLine($"Maksimum: {najwieksze}");
Console.WriteLine($"Liczba tur z maiksimum: {wynik}");



