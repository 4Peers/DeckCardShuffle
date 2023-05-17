using DeckCardsShuffle.Extensions;

namespace DeckCardsShuffle
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        
        //private List<string> _suits = new List<string>(4);
        //Instead let create an Enum
        private enum Suits
        {
            Diamond,
            Spade,
            Heart,
            Club
        }

        //Let create Enum for the faces also
        //Now that I have more time to think about it.
        private enum Faces
        {
            Ace,
            King,
            Queen,
            Jack,
            Ten,
            Nine,
            Eight,
            Seven,
            Six,
            Five,
            Four,
            Three,
            Two
        }

        public Deck()
        {

            //Load the deck of cards
            //_suits.AddRange(new string[] { "Diamond", "Spades", "Heart", "Clubs" });
            
            //Why not make the enum into a list for stronger binding
            //Having fun with this :)

            var suits = Enum.GetValues(typeof(Suits)).Cast<Suits>().Select(v => v.ToString()).ToList();
            var faces = Enum.GetValues(typeof(Faces)).Cast<Faces>().Select(v => v.ToString()).ToList();

            foreach (var suit in suits)
                foreach (var face in faces)
                    _cards.Add(new Card(face, suit));
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
