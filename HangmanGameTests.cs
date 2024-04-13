using NUnit.Framework;
using NUnit.Framework.Legacy;

[TestFixture]
public class HangmanGameTests
{
    [Test]
    public void GuessLetter_CorrectGuess_ReturnsTrue()
    {
        var game = new HangmanGame("test");
        ClassicAssert.IsTrue(game.GuessLetter('t'));
    }

    [Test]
    public void GuessLetter_IncorrectGuess_ReturnsFalse()
    {
        var game = new HangmanGame("test");
        ClassicAssert.IsFalse(game.GuessLetter('2'));
    }

    [Test]
    public void IsWordGuessed_WordNotGuessed_ReturnsFalse()
    {
        var game = new HangmanGame("test");
        ClassicAssert.IsFalse(game.IsWordGuessed());
    }

    [Test]
    public void IsWordGuessed_WordGuessed_ReturnsTrue()
    {
        var game = new HangmanGame("test");
        game.GuessLetter('t');
        game.GuessLetter('e');
        game.GuessLetter('s');
        ClassicAssert.IsTrue(game.IsWordGuessed());
    }
}
