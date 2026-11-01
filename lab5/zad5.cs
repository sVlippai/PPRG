/*List<string> przedmioty = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};

for (int index = 0; index < przedmioty.Count; index++)
{
    Console.WriteLine($"{index +1}. {przedmioty[index]}");
}

int przedmiot;
Console.WriteLine("Wybierz przedmiot do usunięcia:");
while (true)
{
    bool format = int.TryParse(Console.ReadLine(), out przedmiot);

    if (!format)
    {
        Console.WriteLine("Wpisz liczbę całkowita.");
        continue;
    }
    
    if (przedmiot > przedmioty.Count || przedmiot < 0)
    {
        Console.WriteLine("Numer musi należeć do zakresu 1-4.");
        continue;
    }
    

    break;
}
Console.WriteLine($"Usunięto: {przedmioty[przedmiot -1]}");
przedmioty.RemoveAt(przedmiot -1);

for (int index = 0; index < przedmioty.Count; index++)
{
    Console.WriteLine($"{index +1}. {przedmioty[index]}");
}*/