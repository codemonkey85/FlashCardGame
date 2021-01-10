using System.Collections.Generic;
using System.Linq;
using FlashCardGame.Shared;

namespace FlashCardGame.Pages
{
    public partial class AlphabetFlashCardsPage
    {
        protected int CurrentLetterValue { get; set; } = 0;

        protected void Previous() => CurrentLetterValue = CurrentLetterValue == 0 ? 25 : CurrentLetterValue - 1;

        protected void Next() => CurrentLetterValue = CurrentLetterValue == 25 ? 0 : CurrentLetterValue + 1;

        protected void Randomize()
        {
            Alphabet.Shuffle();
            CurrentLetterValue = 0;
        }

        protected void Reset()
        {
            Alphabet = Alphabet.OrderBy(a => a).ToList();
            CurrentLetterValue = 0;
        }

        protected string CurrentLetterDisplay => Alphabet[CurrentLetterValue];

        protected static string GetLetterClass => "alpha-letter";

        private IList<string> Alphabet { get; set; } = new List<string>
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
}
