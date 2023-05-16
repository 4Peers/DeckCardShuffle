using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        private List<string> _suits = new List<string>(4);
        public Deck()
        {
            _suits.AddRange(new string[] { "Diamond", "Spades", "Heart", "Clubs" });

            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 13; y++)
                    _cards.Add(new Card((y + 1).ToString(), _suits[x]));
        }

        public  List<Card> Shuffle()
        {
            List<Card> randomizedList = new List<Card>();
            List<Card> list = new List<Card>(_cards);

            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count); 
                randomizedList.Add(list[index]);
                list.RemoveAt(index);
            }
            return randomizedList;
        }
       
        public string ToStringShuffled()
        {
            return string.Join("\n", Shuffle());
        }

        public override string ToString()
        {
            return string.Join("\n", _cards);
        }
    }

}
