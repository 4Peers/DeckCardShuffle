using System.ComponentModel.Design.Serialization;

namespace DeckCardsShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            Console.WriteLine(deck.ToStringShuffled());
        }
    }
}