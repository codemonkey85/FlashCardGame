namespace FlashCardGame.Pages;

public partial class NumberFlashCardsPage : ComponentBase
{
    protected int CurrentNumberValue = 0;

    protected int Minimum = 0;

    protected int Maximum = 9;

    protected override void OnInitialized() => ReloadRange(false);

    protected void Previous() => CurrentNumberValue = CurrentNumberValue == Minimum ? Maximum : CurrentNumberValue - 1;

    protected void Next() => CurrentNumberValue = CurrentNumberValue == Maximum ? Minimum : CurrentNumberValue + 1;

    protected void Randomize()
    {
        ReloadRange(true);
        CurrentNumberValue = Minimum;
    }

    protected void Reset()
    {
        ReloadRange(false);
        CurrentNumberValue = Minimum;
    }

    protected string CurrentNumberDisplay => NumberRange[CurrentNumberValue].ToString();

    protected static string GetNumberClass => "alpha-number";

    private void ReloadRange(bool isRandom)
    {
        NumberRange.Clear();
        for (var i = Minimum; i <= Maximum; i++)
        {
            NumberRange.Add(i);
        }
        if (isRandom)
        {
            NumberRange.Shuffle();
        }
    }

    private IList<int> NumberRange
    {
        get; set;
    } = new List<int>();
}
