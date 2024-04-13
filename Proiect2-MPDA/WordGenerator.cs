using System;

public static class WordGenerator
{
    private static string[] words = { "stia", "daniel", "spanzuratoare", "solid", "pattern" };
    private static Random random = new Random();

    public static string GetRandomWord()
    {
        return words[random.Next(words.Length)];
    }
}
