using System;

class Program
{
    static void Main(string[] args)
    {
        SingletonGameManager.Instance.StartGame();
        HangmanGame hangman = SingletonGameManager.Instance.Hangman;
        DisplayStrategy display = new ConsoleDisplay();

        while (!hangman.IsWordGuessed())
        {
            display.Display($"Current word: {hangman.GetGuessedWord()}");
            display.Display("Enter a letter:");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (!char.IsLetter(letter))
            {
                display.Display("Invalid input. Please enter a letter.");
                continue;
            }

            letter = char.ToLower(letter);

            if (!hangman.GuessLetter(letter))
            {
                display.Display($"Letter '{letter}' is not in the word.");
            }
        }

        display.Display($"Congratulations! You've guessed the word: {hangman.GetGuessedWord()}");
    }
}
