using System;

public class ConsoleDisplay : DisplayStrategy
{
    public void Display(string text)
    {
        Console.WriteLine(text);
    }
}
