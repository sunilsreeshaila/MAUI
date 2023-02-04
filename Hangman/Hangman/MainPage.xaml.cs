using System.ComponentModel;

namespace Hangman;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    #region UI Properties

    private string spotLight;

    public string SpotLight
    {
        get { return spotLight; }
        set
        {
            spotLight = value;
            OnPropertyChanged();
        }
    }

    private List<char> letters = new List<char>();

    public List<char> Letters
    {
        get { return letters; }
        set
        {
            letters = value; 
            OnPropertyChanged();
        }
    }

    private string message;

    public string Message
    {
        get { return message; }
        set
        {
            message = value;
            OnPropertyChanged();
        }
    }

    private string gameStatus;

    public string GameStatus
    {
        get { return gameStatus; }
        set
        {
            gameStatus = value;
            OnPropertyChanged();
        }
    }

    private string currentImage = "img0.png";

    public string CurrentImage
    {
        get { return currentImage; }
        set
        {
            currentImage = value;
            OnPropertyChanged();
        }
    }



    #endregion

    #region Fields

    private List<string> words = new List<string>()
    {
        "python",
        "javascript",
        "maui",
        "csharp",
        "mongodb",
        "sql",
        "xaml",
        "word",
        "excel",
        "powerpoint",
        "code",
        "hotreload",
        "snippets"
    };

    private string answer = "";

    private List<char> guessed = new List<char>();

    private int mistakes = 0;
    private int maxWrong = 6;

    #endregion

    public MainPage()
	{
		InitializeComponent();
        Letters.AddRange("abcdefghijklmnopqrstuvwxyz");
        BindingContext = this;
        PickWord();
        CalculateWord(answer, guessed);
	}

    #region Game Engine

    private void PickWord()
    {
        answer = words[new Random().Next(0, words.Count)];
        System.Diagnostics.Debug.WriteLine(answer);
    }

    private void CalculateWord(string answer, List<char> guessed)
    {
        var temp = answer.Select(x => (guessed.IndexOf(x) >= 0 ? x : '_')).ToArray();

        SpotLight = string.Join(' ', temp);
    }
    #endregion

    private void Button_Clicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        if (btn != null)
        {
            var letter = btn.Text;
            btn.IsEnabled = false;
            HandleGlass(letter[0]);
        }
    }

    private void HandleGlass(char letter)
    {
        if (guessed.IndexOf(letter) == -1)
        {
            guessed.Add(letter);
        }

        if (answer.IndexOf(letter) >= 0)
        {
            CalculateWord(answer, guessed);
            CheckIfGameWon();
        }
        else if (answer.IndexOf(letter) == -1)
        {
            mistakes++;
            UpdateStatus();
            CheckIfGameLost();
            CurrentImage = $"img{mistakes}.jpg";
        }
    }

    private void CheckIfGameWon()
    {
        if (SpotLight.Replace(" ", "") == answer)
        {
            Message = "You Win!";
            DisableLetters();
        }
    }

    private void UpdateStatus()
    {
        GameStatus = $"Errors: {mistakes} of {maxWrong}";
    }

    private void CheckIfGameLost()
    {
        if (mistakes == maxWrong)
        {
            Message = "You Lost!!";
            DisableLetters();
        }
    }

    private void DisableLetters()
    {
        foreach (var lettersContainerChild in LettersContainer.Children)
        {
            var btn = lettersContainerChild as Button;
            if (btn != null)
            {
                btn.IsEnabled = false;
            }
        }
    }

    private void EnableLetters()
    {
        foreach (var lettersContainerChild in LettersContainer.Children)
        {
            var btn = lettersContainerChild as Button;
            if (btn != null)
            {
                btn.IsEnabled = true;
            }
        }
    }

    private void Reset_Clicked(object sender, EventArgs e)
    {
        mistakes = 0;
        guessed = new List<char>();
        CurrentImage = "img0.png";
        PickWord();
        CalculateWord(answer, guessed);
        Message = "";
        UpdateStatus();
        EnableLetters();
    }
}

