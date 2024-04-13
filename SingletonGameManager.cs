public class SingletonGameManager
{
    private static SingletonGameManager instance;
    public HangmanGame Hangman { get; private set; }

    private SingletonGameManager() { }

    public static SingletonGameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonGameManager();
            }
            return instance;
        }
    }

    public void StartGame()
    {
        Hangman = new HangmanGame(WordGenerator.GetRandomWord());
    }
}
