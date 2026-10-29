
List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};

Console.WriteLine($"Plecak ({plecak.Count}/6):");

for (int ind = 0; ind < plecak.Count; ind++)
{
    Console.WriteLine($"{ind + 1}. {plecak[ind]}");
}

Console.WriteLine("Co znaliazłaś?");
string przedmiot = Console.ReadLine();
plecak.Add(przedmiot);
Console.WriteLine("Co chcesz użyć?");
string uzyto = Console.ReadLine();
plecak.Remove(uzyto);

Console.WriteLine($"Znaleziony przedmiot: {przedmiot}");
Console.WriteLine($"Dodano do plecaka: {przedmiot}");
Console.WriteLine($"Użyto: {uzyto}");

Console.WriteLine($"Plecak ({plecak.Count}/6):");
for (int ind = 0; ind < plecak.Count; ind++)
{
    Console.WriteLine($"{ind + 1}. {plecak[ind]}");
}


