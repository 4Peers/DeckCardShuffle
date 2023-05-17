using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckCardsShuffle.Extensions;

namespace DeckCardsShuffle
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        private List<string> _suits = new List<string>(4);
        public Deck()
        {

            //Load the deck of cards
            _suits.AddRange(new string[] { "Diamond", "Spades", "Heart", "Clubs" });

            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 13; y++)
                    _cards.Add(new Card((y + 1).ToString(), _suits[x]));
        }

        public string ToStringShuffled()
        {
            return string.Join("\n", _cards.Shuffle());
        }

        public override string ToString()
        {
            return string.Join("\n", _cards);
        }
    }

}
