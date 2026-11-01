/*
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
int wynik = 0;

for (int ind = 0; ind < zlotoWTur.Length; ind++)
{
        Console.Write($"Złoto w turze {ind + 1}: ");
        zlotoWTur[ind] = int.Parse(Console.ReadLine()!);
        suma += zlotoWTur[ind];
        
}

int najmniejsze = zlotoWTur[0];
int najwieksze = zlotoWTur[0];

for (int i = 1; i < zlotoWTur.Length; i++)
{
        if (zlotoWTur[i] < najmniejsze)
        {
                najmniejsze = zlotoWTur[i];
        }
        
        if (zlotoWTur[i] > najwieksze)
        { 
                najwieksze = zlotoWTur[i];
        }

       
        
}

foreach (int round in zlotoWTur)
{
        if (round == najwieksze)
               { 
                       wynik++;
               } 
        
}

int nul = -1;
int index = -1;
for (int tur = 0; tur < zlotoWTur.Length; tur++)
{
       
        
        if (zlotoWTur[tur] == najwieksze)
        {
             index = tur;
             break;
        }
}

for (int tur = 0; tur < zlotoWTur.Length; tur++)
{
        if (zlotoWTur[tur] == 0)
        {
                nul = tur;
                break;

        }
}

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Minimum: {najmniejsze}");
Console.WriteLine($"Maksimum: {najwieksze}");
Console.WriteLine($"Pierwsza tura z maksymalnym wynikiem: {index + 1}");
Console.WriteLine($"Liczba tur z maksimum: {wynik}");
if (nul > -1)
{
        Console.WriteLine($"Pierwsza tura bez zlota: {nul + 1}");
}
else
{
        Console.WriteLine("Nie ma tur z wynikiem 0.");
}
*/




