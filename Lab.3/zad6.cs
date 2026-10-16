 Console.WriteLine("Hej,bohater! Jakie masz na imie?");
string username = Console.ReadLine();
 Console.WriteLine("Twoje aktualny punkty zycia: "); 
const int maksPunkty = 100;
int aktPunkty = int.Parse(Console.ReadLine());
bool stan = aktPunkty > 0 && aktPunkty <= 50;


 if (stan)
{
    Console.WriteLine("Masz niskie punkty zycia!");
    
}

 Console.WriteLine("Twoja sila: "); 
int sila = int.Parse(Console.ReadLine());
 Console.WriteLine("Twoja premia broni: ");
int premieBroni = int.Parse(Console.ReadLine());
 Console.WriteLine("Twoj mnoznik ataku specjalnego(double): ");
double mnoznik = double.Parse(Console.ReadLine()); 
double atakSpecj = mnoznik * (premieBroni += sila);
 Console.WriteLine("Ile masz zlota(decimal)?");
decimal zloto = decimal.Parse(Console.ReadLine());
string zasobność = zloto > 30 ? "bogata/y!" : "nie bogaty...";
 Console.WriteLine($" Bohater {zasobność}");
 Console.WriteLine("Czy masz mape(t/f)?");
bool mapa = bool.Parse(Console.ReadLine());
Console.WriteLine("Czy masz kompas(t/f)?");
bool kompas = bool.Parse(Console.ReadLine());
 Console.WriteLine("Czy masz jakas chorobe?");
bool choroba = bool.Parse(Console.ReadLine());
 Console.WriteLine("Ile mikstur masz?");
int mikstury = int.Parse(Console.ReadLine());
 Console.WriteLine("Wybierz akcje(1-leczenie,2-atak specjalny,3-wyprawa");
 int akcje = int.Parse(Console.ReadLine());
 
 Console.BackgroundColor = ConsoleColor.DarkGray;
 Console.ForegroundColor = ConsoleColor.Black;
 Console.WriteLine("===== STATYSTYKA BOHATERA =====");//33
 Console.WriteLine($"| Bohater: {username} \n| Zdrowie: {aktPunkty}/{maksPunkty}");
 if (aktPunkty < 0)
  {
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine($"| Bohater nie zyje. ");
   Console.ResetColor();
  }
  else if (aktPunkty > 0 && aktPunkty <= 50 || choroba == true)
  {
   Console.ForegroundColor = ConsoleColor.Yellow;
   Console.WriteLine("| Bohater jest ranny. ");
   Console.ResetColor();
  }
   else if ((aktPunkty > 50 && aktPunkty <= 100) && choroba == false)
   {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("| Bohater jest zdrowy.");
    Console.ResetColor();
   }
   
  Console.BackgroundColor = ConsoleColor.DarkGray;
  Console.ForegroundColor = ConsoleColor.Black;
 
 Console.WriteLine($"| Zloto: {zloto} ");
 Console.WriteLine($"| Bohater {zasobność} ");
 Console.WriteLine($"| Mikstury: {mikstury}\n| Ma mape lub kompas: {mapa || kompas} \n| Ma chorobe: {choroba} ");
 
 
 
 switch (akcje)

 {
  case 1:
   if ( stan || choroba == true && mikstury > 0)
    Console.WriteLine("| Akcja \"leczenie\": aby wyleczyc sie,\n| uzyj miksture. ");
   else if (!stan && choroba == false)
   Console.WriteLine("| Akcja \"leczenie\": bohater jest zdrowy. ");
   else if (mikstury <= 0)
    Console.WriteLine("| Akcja \"leczenie\": nie masz mikstur. ");
   break;
  case 2:
   Console.WriteLine($"| Akcja \"atak specjalny\":\n| twoj atak specjalny {atakSpecj:F2}. ");
   break;
  case 3:
   if ((mapa || kompas) && !choroba && !stan)
    Console.WriteLine("| Akcja \"wyprawa\": bohater gotowy.");
   else if (stan || choroba)
   {
    Console.WriteLine("| Akcja \"wyprawa\": bohater nie gotowy,\n| wylecz sie. ");
   }
   else if (!mapa || !kompas )
     Console.WriteLine("| Akcja \"wyprawa\":\n| bohater nie gotowy,\n| nie masz mapy/kompasa. ");
   
   break;
 }
 bool gotownosc = choroba == false && mikstury > 0 && (mapa || kompas) && !stan;
 Console.WriteLine($"| Gotowa/y do walki: {gotownosc} ");
 
