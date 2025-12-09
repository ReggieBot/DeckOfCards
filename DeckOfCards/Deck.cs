// Deck of Cards project: COSC2100
// Reggie Brown
// December 9, 2025
// Professor Fabian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// This is the base class for a deck of cards
// Uses a list collection to store cards
// includes various methods such as shuffle, add card, deal, clear, and get count
namespace DeckOfCards
{
    public class Deck
    {
        // List to hold cards
        public List<Card> cards;

        // random generator for shuffling
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-10.0
        private Random random;


        // Constructor
        // creates an empty list and intializes the random generator
        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
        }

        // method to create deck (52 cards)
        // Not sure if we are doing aces high or low though
        public void CreateDeck()
        {
            string[] ranks = new string[13];
            ranks[0] = "Ace";
            ranks[1] = "2";
            ranks[2] = "3";
            ranks[3] = "4";
            ranks[4] = "5";
            ranks[5] = "6";
            ranks[6] = "7";
            ranks[7] = "8";
            ranks[8] = "9";
            ranks[9] = "10";
            ranks[10] = "Jack";
            ranks[11] = "Queen";
            ranks[12] = "King";

            string[] suits = new string[4];
            suits[0] = "Hearts";
            suits[1] = "Diamonds";
            suits[2] = "Clubs";
            suits[3] = "Spades";

            cards.Clear();

            // nestdd loops to create one card for each rank and suit combo
            // then adds each card to list

            for (int s = 0; s < suits.Length; s++)
            {
                for (int r = 0; r < ranks.Length; r++)
                {
                    Card newCard = new Card(suits[s], ranks[r]);
                    cards.Add(newCard);
                }
            }
        }

        // method to add card to deck
        public void AddCard(Card card)
        {
            if (card == null)
            {
                throw new ArgumentNullException("Card can't be null!");
            }

            cards.Add(card);
        }

        // method to deal
        // removes and returns the top card from the deck
        public List<Card> Deal(int count)
        {
            if (count < 0 || count > cards.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid number of cards to deal!");
            }

            List<Card> dealt = new List<Card>();

            for (int i = 0; i < count; i++)
            {
                Card topCard = cards[0];
                cards.RemoveAt(0);
                dealt.Add(topCard);
            }

            return dealt;
        }

        // method to shuffle the deck
        // this uses the fisher-yates algorithm
        // Reference: https://www.geeksforgeeks.org/dsa/shuffle-a-given-array-using-fisher-yates-shuffle-algorithm/
        // simply, all I'm doing is iterating through the list backwards,
        // and for each card, swapping it with a randomly selected card that comes before it (including itself)
        // this makes sure the shuffle isn't biased (all permutations are equally likely)
        // my poker background helped me understand how important a good shuffle is lol
        public void Shuffle()
        {
            for (int i = cards.Count -1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Card temporary = cards[i];
                cards[i] = cards[j];
                cards[j] = temporary;
            }
        }

        // method to clear deck
        // Reference: https://www.codecademy.com/resources/docs/c-sharp/arrays/clear
        public void Clear()
        {
            cards.Clear();
        }

        // method to get count of cards in deck
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=net-10.0
        public int GetCount()
        {
            return cards.Count;
        }
    }
}
