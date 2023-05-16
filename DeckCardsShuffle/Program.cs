using System.ComponentModel.Design.Serialization;

namespace ConsoleApp1
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