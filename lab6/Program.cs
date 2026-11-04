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
 Console.ForegroundColor = ConsoleColor.Cyan;*/

 Console.WriteLine("Twoja sila: "); 
int.TryParse(Console.ReadLine(), out int sila);

 Console.WriteLine("Twoja premia broni: ");
int premieBroni = int.Parse(Console.ReadLine());

 /*Console.WriteLine("Twoj mnoznik ataku specjalnego(double): ");
double.TryParse(Console.ReadLine(), out double mnoznik); 
double atakSpecj = mnoznik * (premieBroni += sila);*/

Console.WriteLine("Ile masz zlota?");
int.TryParse(Console.ReadLine(), out int zloto);
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
int numertury = 1;
int sumaZLoto = 0;
int sumaZlotoTura = 0;
int uzuciePrzedmiot = 0;
int dodanieZnalezisko = 0;
int wyrzucaniePrzedm = 0;
int odpoczynek = 0;
int liczbaAtak = 0;
string odpowiedz = null;
int turyMaks = 20;
int numerPlecak = 0;

List<string> historia = new List<string>();

int[] zlotoZdobyteWTurach = new int[20];

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


int Damage(int sila, int premieBroni)
{
 int damage = sila * premieBroni;
 return damage;
}
int damage = Damage(sila, premieBroni);



void Menu()
{
 Console.WriteLine("Wybierz akcje:\n1 - Eksploruj loch, 2 - Odpocznij, 3 - Atakuj, 4 - Pokaż plecak, 5 - Użyj przedmiotu,\n6 - Dodaj znalezisko, 7 - Wyrzuć przedmiot, 8 - Pokaż historię,\n9 - Pokaż statystyki wyprawy, 10 - Statystyka Bohatera, 11 - Zakończ grę");
}

void Continue()
{
 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;
 Console.WriteLine("Contunujemy?");
}

void BackgroundSet()
{
 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;
}

void Plecak(int numerPlecak)
{
 for (numerPlecak = 0; numerPlecak < plecak.Count; numerPlecak++)
 {
  Console.BackgroundColor = ConsoleColor.DarkBlue;
  Console.ForegroundColor = ConsoleColor.Black;
  Console.WriteLine($"{numerPlecak + 1},{plecak[numerPlecak]}");
  Console.ResetColor();
 }
}

void PlecakCheck()
{
 Console.ForegroundColor = ConsoleColor.DarkRed;
 Console.WriteLine("Twój plecak jest pusty.");
 Console.ResetColor();
}

void ShowStatystyk(string username, int numertury, int aktPunkty, int maksPunkty, int sila, int premieBroni, int zloto, int eksploracja)
{
 Console.WriteLine($"Bohater: {username}");
 Console.WriteLine($"Rozegnane tury: {numertury}");
 Console.WriteLine($"Zdrowie: {aktPunkty}/{maksPunkty}");
 Console.WriteLine($"Twoja siła: {sila} | Twoja premia broni: {premieBroni}");
 Console.WriteLine($"Złoto: {zloto}");
 Console.WriteLine($"Eksploracja: {eksploracja}");
 Console.WriteLine($"Przedmioty w plecaku: {plecak.Count}");
 Console.WriteLine($"Wpisy w historii: {historia.Count}");
}

Console.WriteLine($"===== Hej, {username}! =====");
Console.WriteLine("Tura : 1");
Console.WriteLine($"Twoje startowe dane:");
Console.WriteLine($"Zloto: {zloto} | Zdrowie: {aktPunkty}/{maksPunkty} | Plecak: {plecak.Count}/6");

while (graDziala && aktPunkty >= 0)
{
 
 int Heal(int aktPunkty) => Math.Min(aktPunkty + 8, 100);
 aktPunkty = Heal(aktPunkty);
  
 BackgroundSet();
 Menu();
 Console.WriteLine($"Masz {turyMaks} tur/y.");
 int.TryParse(Console.ReadLine(), out int akcje);
 turyMaks--;
 
if (akcje == 4 || akcje == 8 || akcje == 9 || akcje == 10)
   {
    turyMaks++;
   }

 if (turyMaks == 0)
 {
  Console.WriteLine("Więciej nie masz tur.");
  graDziala = false;
 }


 switch (akcje)
 {
  
  case 1:

   while (aktPunkty > 0)
   {
    do
    {
     eksploracja++;
     aktPunkty -= 8;
     sumaZlotoTura += 10;
     zloto += 10;
     zlotoZdobyteWTurach[numertury - 1] += sumaZlotoTura;

     if (aktPunkty < 0)
     {
      aktPunkty = 0;
      graDziala = false;
     }

     Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine($"Eksplorujesz! ZLoto : {zloto}, zdrowie: {aktPunkty}");
     historia.Add("EKsplorujesz");
     Console.ResetColor();
     
     if (aktPunkty < 30 && aktPunkty > 0)
          {
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Masz niskie punkty zycia!");
           Console.ResetColor();
          }
     
     Continue();
     odpowiedz = Console.ReadLine();
     if (odpowiedz == "Nie" || odpowiedz == "nie")
         {
          numertury++;
          break;
         }
     
     
    } while (odpowiedz == "Tak" || odpowiedz == "tak");
   }
   continue;
  
  case 2:
   do
   {
    if (aktPunkty == 100)
    {
     Console.WriteLine($"Zdrowie nie może być więcej niż 100.");
     break;
    }

    Heal(aktPunkty);
    Console.WriteLine($"Odpoczywasz. Twoje zdrowie: {aktPunkty}");
    historia.Add("Odpoczywasz");
    odpoczynek++;
    Continue();
    odpowiedz = Console.ReadLine();
    
    if (odpowiedz == "Nie" || odpowiedz == "nie")
       {
        numertury++;
        break;
       }
    
   }while (odpowiedz == "Tak" || odpowiedz == "tak");

   
   continue;
  
  case 3:
   Random rnd1 = new Random();
   
   int przeciwnik = rnd1.Next(50, 70);
   
   do
   {
     int atak = rnd1.Next(10, 20);
     aktPunkty = Math.Max(aktPunkty - atak, 0);

     if (aktPunkty <= 0)
     {
      graDziala = false;
      break;
     }

     liczbaAtak++;
     przeciwnik-=damage;
     historia.Add("Atakujesz");
     Console.WriteLine($"Twój atak: {damage}. Atak przeciwnika: {atak}.");
     Console.WriteLine($"Twoje zdrowie: {aktPunkty}. Zdrowie przeciwnika: {przeciwnik}.");

     if (przeciwnik <= 0)
     {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Zwycięstwo!");
      break;
     }
     
     BackgroundSet();
     Continue();
     odpowiedz = Console.ReadLine();
    
     if (odpowiedz == "Nie" || odpowiedz == "nie")
     {
      numertury++;
      break;
     }
       
   } while (odpowiedz == "Tak" || odpowiedz == "tak");
   continue;

  case 4:

   if (plecak.Count == 0)
   {
    PlecakCheck();
    break;
   }
   
   Plecak(numerPlecak);
   
   continue;

  case 5:
   int numer;

   if (plecak.Count == 0)
   {
    PlecakCheck();
    break;
   }

   do
   {
    Plecak(numerPlecak);
    BackgroundSet();
    
    Console.WriteLine("Wpisz numer przedmiotu:");
    int.TryParse(Console.ReadLine(), out numer);
    uzuciePrzedmiot++;
    

    if (numer - 1 == plecak.IndexOf("Mikstura"))
    {
     aktPunkty = Math.Min(aktPunkty + 10, 100);

     if (aktPunkty == 100)
     {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine($"Zdrowie nie może być więcej niż 100.");

     }
     else
     {
      historia.Add($"Używasz przedmiot: {plecak[numer - 1]} ");
      plecak.RemoveAt(numer - 1);
      Console.WriteLine($"Twoje punkty zdrowia: {aktPunkty}");
     }
     
    }

    if (numer - 1 == plecak.IndexOf("Pochodnia"))
    {
     historia.Add($"Używasz przedmiot: {plecak[numer - 1]} ");
     Console.WriteLine("Rozświetlono korytarz.");
     plecak.RemoveAt(numer - 1);
    }

    if (numer - 1 == plecak.IndexOf("Zwój"))
    {
     historia.Add($"Używasz przedmiot: {plecak[numer - 1]} ");
     zloto += 15;
     plecak.RemoveAt(numer - 1);
     Console.WriteLine($"Twoje zloto: {zloto}");
    }

    if (numer - 1 < 0 || numer - 1 > plecak.Count)
    {
     uzuciePrzedmiot--;
     turyMaks++;
     Console.ForegroundColor = ConsoleColor.DarkRed;
     Console.WriteLine("Nie masz takiego predmiotu.");
     Console.ResetColor();
    }

    Continue();
    odpowiedz = Console.ReadLine();

    if (odpowiedz == "Nie" || odpowiedz == "nie")//method
    {
     numertury++;
     break;
    }

   } while (odpowiedz == "Tak" || odpowiedz == "tak");

   continue;

  case 6:
   int numer2;
   odpowiedz = "";
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
    BackgroundSet();
    Console.WriteLine("Wybiersz nagrodę.");
    int.TryParse(Console.ReadLine(), out numer2);
    dodanieZnalezisko++;
    plecak.Add(znaleziska[numer2 - 1]);
    historia.Add($"Dodałeś nagrodę: {znaleziska[numer2 - 1]}");
    Console.WriteLine("Teraz masz:");

    Plecak(numerPlecak);
    BackgroundSet();
    
     if (numer2 - 1 < 0 || numer2 - 1 > znaleziska.Length)
    {
     turyMaks++;
     Console.ForegroundColor = ConsoleColor.DarkRed;
     Console.WriteLine("Nie ma takiego predmiotu.");
     Console.ResetColor();
     continue;
    }
    
    Continue();
    odpowiedz = Console.ReadLine();

    if (odpowiedz == "Nie" || odpowiedz == "nie")//method
    {
     numertury++;
     break;
    }

   } while (odpowiedz == "Tak" || odpowiedz == "tak");
   

   continue;

  case 7:
   int numer3;
   odpowiedz = "";
   do
   {
    if (plecak.Count == 0)
    {
     PlecakCheck();
     break;
    }
    
    Plecak(numerPlecak);
    BackgroundSet();
    
    Console.WriteLine("Czego chcesz usunac?");
    int.TryParse(Console.ReadLine(), out numer3);
    
    if (numer3 - 1 < 0 || numer3 - 1 > plecak.Count)
    {
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.DarkRed;
     Console.WriteLine("Nie masz takiego predmiotu.");
     Console.ResetColor();
     continue;
    }
    
    wyrzucaniePrzedm++;
    historia.Add($"Wyrzuciłeś przedmiot: {plecak[numer3 - 1]} ");
    plecak.RemoveAt(numer3 - 1);
    Console.WriteLine("Teraz masz:");
    
    Plecak(numerPlecak);

    Continue();
    odpowiedz = Console.ReadLine();

    if (odpowiedz == "Nie" || odpowiedz == "nie")//method
    {
     numertury++;
     break;
    }

   } while (odpowiedz == "Tak" || odpowiedz == "tak");

   continue;

  case 8:

   if (historia.Count == 0)
   {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Nie masz zapiców w swojej historię.");
    Console.ResetColor();
    break;
   }

   foreach (var action in historia)
   {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(action);
    Console.ResetColor();
   }

   BackgroundSet();
   Console.WriteLine(
    $"Eksploracja: {eksploracja} raz/y.\nUżycie przedmiotu: {uzuciePrzedmiot} raz/y.\nDodanie znalezisko: {dodanieZnalezisko} raz/y.\nWyrzucanie przedmiotu: {wyrzucaniePrzedm} raz/y.");
   continue;

  case 9:
  
   Console.WriteLine($"{eksploracja} eksploracji.");
   int wynik = 0;

   for (int tura = 0; tura < zlotoZdobyteWTurach.Length; tura++)
   {
    Console.WriteLine($"Tura: {tura + 1}: {zlotoZdobyteWTurach[tura]} sztuk złota.");
    sumaZLoto += zlotoZdobyteWTurach[tura];

    if (zlotoZdobyteWTurach[tura] == 0)
    {
     wynik++;
    }
   }

   int maksZlotoTura = zlotoZdobyteWTurach[0];
   for (int i = 1; i < zlotoZdobyteWTurach.Length; i++)
   {
    if (zlotoZdobyteWTurach[i] > maksZlotoTura)
    {
     maksZlotoTura = zlotoZdobyteWTurach[i];
    }
   }

   Console.WriteLine($"lacznie w turach {sumaZLoto}");
   Console.WriteLine($"maksymaknie zza turu: {maksZlotoTura}");
   Console.WriteLine($"Liczba tur bez zlota: {wynik}");
   continue;
  
  case 10:
   
   ShowStatystyk(username,  numertury,  aktPunkty,  maksPunkty,  zloto, sila, premieBroni, eksploracja);
   continue;
  
  case 11:
   graDziala = false;
   Console.WriteLine("=== KONIEC GRY ===");
   ShowStatystyk( username,  numertury,  aktPunkty,  maksPunkty,  zloto, sila, premieBroni, eksploracja);
   if (historia.Count < 3)
   {
    foreach (var action in historia)
    {
     Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine(action);
     Console.ResetColor();
    }
    BackgroundSet();
    Console.WriteLine("Powód zakończenia: gracz wybrał wyjście."); 
   }

   for (int index = historia.Count - 3; index < historia.Count; index++)
   {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(historia[index]);
    Console.ResetColor();
   }
   BackgroundSet();
   Console.WriteLine("Powód zakończenia: gracz wybrał wyjście.");
   break;

  default:
  {
   turyMaks++;
   Console.WriteLine("Wybierz poprawna akcje.");
  }
   continue;
 }
}

Console.WriteLine("=== GRACZ UMATŁ ==="); 
ShowStatystyk( username,  numertury,  aktPunkty,  maksPunkty,  zloto, sila, premieBroni,  eksploracja);
if (historia.Count < 3)
{
 foreach (var action in historia)
 {
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine(action);
  Console.ResetColor();
 }
}

for (int index = Math.Max(0, historia.Count - 3); index < historia.Count; index++)
 {
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine(historia[index]);
  Console.ResetColor();
 }
 BackgroundSet();

 

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