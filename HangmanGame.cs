using System;

public class HangmanGame
{
    private string wordToGuess;
    private string guessedWord;
    private int attemptsLeft;

    public HangmanGame(string word)
    {
        wordToGuess = word.ToLower();
        guessedWord = new string('_', word.Length);
        attemptsLeft = 5; 
    }

    public bool GuessLetter(char letter)
    {
        if (attemptsLeft <= 0)
        {
            Console.WriteLine("Ai rămas fără încercări!");
            return false;
        }

        bool found = false;
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == letter)
            {
                guessedWord = guessedWord.Substring(0, i) + letter + guessedWord.Substring(i + 1);
                found = true;
            }
        }

        if (!found)
        {
            attemptsLeft--; // Scădem numărul de încercări rămase dacă litera nu a fost găsită
        }

        return found;
    }

    public string GetGuessedWord()
    {
        return guessedWord;
    }

    public bool IsWordGuessed()
    {
        return guessedWord.Equals(wordToGuess);
    }

    public int GetAttemptsLeft()
    {
        return attemptsLeft;
    }
}
