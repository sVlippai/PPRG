/*
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("Hej,bohater! Jakie masz na imie?");
string username = Console.ReadLine();

 Console.WriteLine("Twoje aktualny punkty zycia: "); 
const int maksPunkty = 100;
int.TryParse(Console.ReadLine(), out int aktPunkty);


bool stan = aktPunkty > 0 && aktPunkty <= 40;
 

 if (stan)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Masz niskie punkty zycia!");
    Console.ResetColor();
  }

 Console.BackgroundColor = ConsoleColor.DarkBlue;
 Console.ForegroundColor = ConsoleColor.Cyan;

 Console.WriteLine("Twoja sila: "); 
int.TryParse(Console.ReadLine(), out int sila);

 Console.WriteLine("Twoja premia broni: ");
int premieBroni = int.Parse(Console.ReadLine());

 Console.WriteLine("Twoj mnoznik ataku specjalnego(double): ");
double.TryParse(Console.ReadLine(), out double mnoznik); 
double atakSpecj = mnoznik * (premieBroni += sila);

 Console.WriteLine("Ile masz zlota?");
decimal.TryParse(Console.ReadLine(), out decimal zloto);
string zasobność = zloto > 50 ? "bogata/y!" : "nie bogaty...";



Console.WriteLine("Czy masz mape(t/f)?");
bool mapa = bool.Parse(Console.ReadLine());

Console.WriteLine("Czy masz kompas(t/f)?");
bool kompas = bool.Parse(Console.ReadLine());

 Console.WriteLine("Czy masz jakas chorobe?");
bool choroba = bool.Parse(Console.ReadLine());


 Console.WriteLine("Ile mikstur masz?");
int.TryParse(Console.ReadLine(), out int mikstury);

bool graDziala = true;

Console.WriteLine($"===== Hej, {username}! =====");
Console.WriteLine("Tura : 1");
Console.WriteLine($"Twoje startowe dane:");
Console.WriteLine($"Zloto: {zloto}, zdrowie: {aktPunkty}.");
Console.WriteLine($"Mikstury: {mikstury}.");
int eksploracja = 0;



  while (graDziala && aktPunkty >= 0)
  {
   Console.BackgroundColor = ConsoleColor.DarkBlue;
   Console.ForegroundColor = ConsoleColor.Cyan;
   Console.WriteLine("Wybierz akcje:\n1 - Eksploruj loch\n2 - Użyj mikstury\n3 - Odpocznij\n4 - Statystyka\n5 - Zakończ grę.");
   int.TryParse(Console.ReadLine(), out int akcje);
   

   switch (akcje)
   {

    case 1:
     

     while (aktPunkty > 0)
     {
      
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
      break;
     }
     Console.BackgroundColor = ConsoleColor.DarkBlue;
     Console.ForegroundColor = ConsoleColor.Cyan;

     

     if (aktPunkty < 30 && aktPunkty > 0)
     {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Masz niskie punkty zycia!");
      Console.ResetColor();

     }
    
     continue;

    case 2:

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