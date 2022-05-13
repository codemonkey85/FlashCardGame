namespace FlashCardGame.Pages;

public partial class AlphabetFlashCardsPage : ComponentBase
{
    protected int CurrentLetterValue = 0;

    protected int Minimum = 0;

    protected int Maximum = 25;

    protected void Previous() => CurrentLetterValue = CurrentLetterValue == Minimum ? Maximum : CurrentLetterValue - 1;

    protected void Next() => CurrentLetterValue = CurrentLetterValue == Maximum ? Minimum : CurrentLetterValue + 1;

    protected void Randomize()
    {
        Alphabet.Shuffle();
        CurrentLetterValue = Minimum;
    }

    protected void Reset()
    {
        Alphabet = Alphabet.OrderBy(a => a).ToList();
        CurrentLetterValue = Minimum;
    }

    protected string CurrentLetterDisplay => Alphabet[CurrentLetterValue];

    protected static string GetLetterClass => "alpha-letter";

    private IList<string> Alphabet
    {
        get; set;
    } = new List<string>
    {
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "I",
        "J",
        "K",
        "L",
        "M",
        "N",
        "O",
        "P",
        "Q",
        "R",
        "S",
        "T",
        "U",
        "V",
        "W",
        "X",
        "Y",
        "Z",
    };
}
