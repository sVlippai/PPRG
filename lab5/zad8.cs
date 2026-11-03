Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("Hej,bohater! Jakie masz na imie?");
string username = Console.ReadLine();

 Console.WriteLine("Twoje aktualny punkty zycia: "); 
const int maksPunkty = 100;
int.TryParse(Console.ReadLine(), out int aktPunkty);


/*bool stan = aktPunkty > 0 && aktPunkty <= 40;

if (stan)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Masz niskie punkty zycia!");
    Console.ResetColor();
  }

 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;

 /*Console.WriteLine("Twoja sila: "); 
int.TryParse(Console.ReadLine(), out int sila);

 Console.WriteLine("Twoja premia broni: ");
int premieBroni = int.Parse(Console.ReadLine());

 Console.WriteLine("Twoj mnoznik ataku specjalnego(double): ");
double.TryParse(Console.ReadLine(), out double mnoznik); 
double atakSpecj = mnoznik * (premieBroni += sila);*/

 Console.WriteLine("Ile masz zlota?");
decimal.TryParse(Console.ReadLine(), out decimal zloto);
/*string zasobność = zloto > 50 ? "bogata/y!" : "nie bogaty...";*/


/*Console.WriteLine("Czy masz mape(t/f)?");
bool mapa = bool.Parse(Console.ReadLine());

Console.WriteLine("Czy masz kompas(t/f)?");
bool kompas = bool.Parse(Console.ReadLine());

 Console.WriteLine("Czy masz jakas chorobe?");
bool choroba = bool.Parse(Console.ReadLine());


 Console.WriteLine("Ile mikstur masz?");
int.TryParse(Console.ReadLine(), out int mikstury);*/

bool graDziala = true;
int eksploracja = 0;
int numertury = 0;
int uzuciePrzedmiot = 0;
int dodanieZnalezisko = 0;
int wyrzucaniePrzedm = 0;
string odpowiedz;

string[] znaleziska =
{
 "Mikstura",
 "Klucz",
 "Pochodnia",
 "Zwój"
};

List<string> plecak = new List<string>
{
 "Miecz",
 "Mikstura",
 "jajco"
};

List<string> historia = new List<string>();

Console.WriteLine($"===== Hej, {username}! =====");
Console.WriteLine("Tura : 1");
Console.WriteLine($"Twoje startowe dane:");
Console.WriteLine($"Zloto: {zloto} | Zdrowie: {aktPunkty}/{maksPunkty} | Plecak: {plecak.Count}/6");
/*Console.WriteLine($"Mikstury: {mikstury}.");*/


while (graDziala && aktPunkty >= 0)
{
 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Wybierz akcje:\n1 - Eksploruj loch, 2 - Pokaż plecak, 3 - Użyj przedmiotu, 4 - Dodaj znalezisko\n5 - Wyrzuć przedmiot, 6 - Pokaż historię, 7 - Pokaż statystyki wyprawy\n8 - Zakończ grę");
 int.TryParse(Console.ReadLine(), out int akcje);


 switch (akcje)
 {

  case 1:

   while (aktPunkty > 0)
   {
    do
    {

     historia.Add("EKsplorujesz");
     eksploracja++;
     aktPunkty -= 8;
     zloto += 10;

     if (aktPunkty < 0)
     {
      aktPunkty = 0;
      graDziala = false;
     }

     Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine($"Eksplorujesz! ZLoto : {zloto}, zdrowie: {aktPunkty}");
     Console.ResetColor();
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.Cyan;
     Console.WriteLine("Contunujemy?");
     odpowiedz = Console.ReadLine();
     
     if (aktPunkty < 30 && aktPunkty > 0)
         {
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("Masz niskie punkty zycia!");
          Console.ResetColor();
         }
     
    } while (odpowiedz == "Tak" || odpowiedz == "tak");

    if (odpowiedz == "Nie" || odpowiedz == "nie")
    {
     numertury++;
     break;
    }
    
   }
   continue;

  case 2:

   if (plecak.Count == 0)
   {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Twój plecak jest pusty.");
    Console.ResetColor();
    break;
   }
   for (int numerPlecak = 0; numerPlecak < plecak.Count; numerPlecak++)
   {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"{numerPlecak + 1},{plecak[numerPlecak]}");
    Console.ResetColor();
  }
   continue;
   
  case 3:
   int numer;
   
   if (plecak.Count == 0)
   {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Twój plecak jest pusty.");
    Console.ResetColor();
    break;
   }
   
   do
   {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    for (int numerPlecak = 0; numerPlecak < plecak.Count; numerPlecak++)
       {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"{numerPlecak + 1}. {plecak[numerPlecak]}");
        Console.ResetColor();
       }
    Console.WriteLine("Wpicz numer przedmiotu:");
    int.TryParse(Console.ReadLine(), out numer);
    uzuciePrzedmiot++;

    if (numer - 1 == plecak.IndexOf("Mikstura"))
    {
     aktPunkty += 20;
     plecak.RemoveAt(numer - 1);
     Console.WriteLine($"Twoje punkty zdrowia: {aktPunkty}");
    }

    if (numer - 1 == plecak.IndexOf("Pochodnia"))
    {
     Console.WriteLine("Rozświetlono korytarz.");
     plecak.RemoveAt(numer - 1);
    }

    if (numer - 1 == plecak.IndexOf("Zwój"))
    {
     zloto += 15;
     plecak.RemoveAt(numer - 1);
     Console.WriteLine($"Twoje zloto: {zloto}");
    }
    
    if (numer < 0 || numer > plecak.Count)
    {
      uzuciePrzedmiot--;
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Nie masz takiego predmiotu."); 
      Console.ResetColor();
    }
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Contunujemy?");
    odpowiedz = Console.ReadLine();
    
     if (odpowiedz == "Nie" || odpowiedz == "nie") 
     {
      numertury++;
      break;
     }
    
   } while (odpowiedz == "Tak" || odpowiedz == "tak");
   continue;
  
  case 4:
   int numer1;
   do
   {
    if (plecak.Count == 6)
       {
        Console.WriteLine("Nie masz wolnego miejsca w plecaku.");
        break;
       }
    for (int index = 0; index < znaleziska.Length; index++)
    {
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.Black;
     Console.WriteLine($"{index + 1}. {znaleziska[index]}");
     Console.ResetColor();
    }
    
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Wybiersz nagrodę.");
    int.TryParse(Console.ReadLine(), out numer1);
    plecak.Add(znaleziska[numer1 - 1]);
    dodanieZnalezisko++;
    Console.WriteLine("Teraz masz:");
    
    for (int numerPlecak = 0; numerPlecak < plecak.Count; numerPlecak++)
    {
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.Black;
     Console.WriteLine($"{numerPlecak + 1}. {plecak[numerPlecak]}");
     Console.ResetColor();
    }
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Contunujemy?");
    odpowiedz = Console.ReadLine();
    
    if (odpowiedz == "Nie" || odpowiedz == "nie") 
    {
     numertury++;
     break;
    }

   } while (odpowiedz == "Tak" || odpowiedz == "tak");
   continue;
  
  case 5:
   int numer2;
   do
   {
    for (int numerPlecak = 0; numerPlecak < plecak.Count; numerPlecak++)
    {
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.Black;
     Console.WriteLine($"{numerPlecak + 1}. {plecak[numerPlecak]}");
     Console.ResetColor();
    }
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Czego chcesz usunac?");
    int.TryParse(Console.ReadLine(), out numer2);
    plecak.RemoveAt(numer2);
    Console.WriteLine("Teraz masz:");
    for (int numerPlecak = 0; numerPlecak < plecak.Count; numerPlecak++)
    {
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.Black;
     Console.WriteLine($"{numerPlecak + 1}. {plecak[numerPlecak]}");
     Console.ResetColor();
    }
    
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Contunujemy?");
    odpowiedz = Console.ReadLine();
    
    
    
   }while (odpowiedz == "Tak" || odpowiedz == "tak");
   continue;

   
 }
 
}
/*case 2:

 while (mikstury > 0 && aktPunkty <= 80)
 {
  mikstury--;
  aktPunkty += 20;

  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"Otrzymasz 20 punktów życia!Twoje zdrowie: {aktPunkty}");
  Console.ResetColor();
  break;
 }
 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;

   if (aktPunkty >= 100 )
       {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Punkty zdrowia nie moga byċ wyższej niż 100.");
        Console.ResetColor();

       }
       else if (mikstury <= 0)
       {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie masz mikstur do użycia.");
        Console.ResetColor();
       }

 continue;

case 3:

 while (zloto > 3 && aktPunkty <= 96)
 {
  zloto -= 3;
  aktPunkty += 5;
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"Skutecznie odpoczywasz!Twoje zdrowie: {aktPunkty}, twoje zloto : {zloto}");
  Console.ResetColor();

  Console.BackgroundColor = ConsoleColor.DarkBlue;
  Console.ForegroundColor = ConsoleColor.Cyan;

  if (aktPunkty >= 96)
       {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Nie możesz więciej odpoczywaċ,\nwięc punkty zdrowia nie moga byċ wyższej niż 100.");
        Console.ResetColor();
       }

  break;
 }

 if (zloto <= 2)
 {
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Nie masz już wystarczajace złota dla odpoczynku..");
  Console.ResetColor();
 }

 continue;

case 4:
{
 Console.WriteLine("===== STATYSTYKA BOHATERA =====");
 Console.WriteLine($"| Bohater: {username} \n| Zdrowie: {aktPunkty}/{maksPunkty}");

 if (aktPunkty < 0)
 {
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine($"| Bohater nie zyje. ");
  Console.ResetColor();
 }
 else if (aktPunkty > 0 && aktPunkty <= 50 )//|| choroba == true
 {
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine("| Bohater jest ranny. ");
  Console.ResetColor();
 }
 else if ((aktPunkty > 50 && aktPunkty <= 100) )//&& choroba == false
 {
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("| Bohater jest zdrowy.");
  Console.ResetColor();
 }

 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;

 Console.WriteLine($"| Zloto: {zloto}.  ");
 Console.WriteLine($"| Mikstury: {mikstury} ");
 Console.WriteLine($"| Ma mape lub kompas: {mapa || kompas} \n| Ma chorobe: {choroba} ");
 Console.WriteLine($"| Liczba turów: {eksploracja}");
 continue;
}

case 5:
{
 graDziala = false;
 Console.WriteLine("=== KONIEC GRY ===");
 Console.WriteLine($"Bohater: {username}");
 Console.WriteLine($"Rozegnane tury: {eksploracja}");
 Console.WriteLine($"Zdrowie: {aktPunkty}/{maksPunkty}");
 Console.WriteLine($"Złoto: {zloto}");
 Console.WriteLine($"Mikstury: {mikstury}");
 Console.WriteLine("Powód zakończenia: gracz wybrał wyjście.");
 break;
}
default:
{
 Console.WriteLine("Nieznana akcja.");
 continue;
}

}
}
Console.WriteLine("=== KONIEC GRY ===");
Console.WriteLine($"Bohater: {username}");
Console.WriteLine($"Rozegnane tury: {eksploracja}");
Console.WriteLine($"Zdrowie: {aktPunkty}/{maksPunkty}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"Mikstury: {mikstury}");
Console.WriteLine("Powód zakończenia: bohater umarł. :(");*/