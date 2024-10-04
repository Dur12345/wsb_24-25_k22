using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Wczytanie liczby osób
        Console.Write("Podaj liczbę osób: ");
        int n;

        // Sprawdzenie, czy wprowadzona liczba jest poprawna
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Proszę podać poprawną liczbę całkowitą większą od 0.");
        }

        // Tablice do przechowywania imion i wieków
        string[] imiona = new string[n];
        int[] wieki = new int[n];

        // Lista do przechowywania imion zaczynających się na 'A'
        List<string> imionaNaA = new List<string>();

        // Słownik do przechowywania par (imie, wiek) dla osób powyżej 18 lat
        Dictionary<string, int> osobyPow18 = new Dictionary<string, int>();

        // Wczytanie imion i wieków
        for (int i = 0; i < n; i++)
        {
            Console.Write("Podaj imię: ");
            imiona[i] = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            int wiek;

            // Sprawdzenie, czy wprowadzony wiek jest poprawny
            while (!int.TryParse(Console.ReadLine(), out wiek) || wiek < 0)
            {
                Console.WriteLine("Proszę podać poprawny wiek (liczba całkowita nieujemna).");
            }

            wieki[i] = wiek;

            // Sprawdzenie, czy imię zaczyna się na 'A'
            if (!string.IsNullOrEmpty(imiona[i]) && imiona[i].StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                imionaNaA.Add(imiona[i]);
            }

            // Sprawdzenie, czy wiek jest większy niż 18
            if (wiek > 18)
            {
                osobyPow18[imiona[i]] = wiek;
            }
        }

        // Wypisanie zawartości tablicy, listy i słownika
        Console.WriteLine("\nZawartość tablicy imion:");
        foreach (var imie in imiona)
        {
            Console.WriteLine(imie);
        }

        Console.WriteLine("\nImiona zaczynające się na 'A':");
        foreach (var imie in imionaNaA)
        {
            Console.WriteLine(imie);
        }

        Console.WriteLine("\nOsoby powyżej 18 lat:");
        foreach (var osoba in osobyPow18)
        {
            Console.WriteLine($"{osoba.Key}: {osoba.Value} lat");
        }
    }
}

