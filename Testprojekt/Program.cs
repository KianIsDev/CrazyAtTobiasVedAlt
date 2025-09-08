// Program.cs
// Simpelt terminalspil: "Gæt tallet"
// Kræver .NET 6+ (top-level statements)

using System;

var rnd = new Random();
bool playAgain = true;

Console.WriteLine("Velkommen til 'Gæt tallet'!");
Console.WriteLine("Du skal gætte et tal mellem 1 og 100. God fornøjelse!\n");

while (playAgain)
{
    int secret = rnd.Next(1, 101); // 1..100
    int attemptsLeft = 8;
    int attemptsUsed = 0;
    bool guessed = false;

    while (attemptsLeft > 0 && !guessed)
    {
        Console.Write($"Du har {attemptsLeft} forsøg tilbage. Indtast dit gæt: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ugyldigt input — prøv igen.");
            continue;
        }

        if (!int.TryParse(input.Trim(), out int guess))
        {
            Console.WriteLine("Skriv venligst et tal (fx 42).");
            continue;
        }

        if (guess < 1 || guess > 100)
        {
            Console.WriteLine("Tallet skal være mellem 1 og 100.");
            continue;
        }

        attemptsUsed++;
        attemptsLeft--;

        if (guess == secret)
        {
            Console.WriteLine($"\n🎉 Rigtigt! Du gættede tallet {secret} på {attemptsUsed} forsøg.");
            guessed = true;
        }
        else if (guess < secret)
        {
            Console.WriteLine("For lavt! Prøv et højere tal.\n");
        }
        else
        {
            Console.WriteLine("For højt! Prøv et lavere tal.\n");
        }
    }

    if (!guessed)
    {
        Console.WriteLine($"\nØv — du løb tør for forsøg. Hemmeligt tal var: {secret}");
    }

    // Simple scoring tip
    int score = guessed ? Math.Max(0, 100 - (attemptsUsed - 1) * 10) : 0;
    Console.WriteLine($"Din score: {score}\n");

    // Spørg om genstart
    Console.Write("Vil du spille igen? (j/n): ");
    string? again = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(again) || !(again.Trim().ToLower().StartsWith("j")))
    {
        playAgain = false;
    }
    Console.WriteLine();
}

Console.WriteLine("Tak for spillet — farvel!");






























Console.WriteLine ("-------------------");
