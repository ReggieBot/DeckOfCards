// DeckOfCards Project: COSC2100
// Reggie Brown
// December 9, 2025
// Professor Fabian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I used this class to define what a single playing card is 
// Stores the suit and rank
// Includes getter and setter methods (did them in Java style, not sure if that's the C# way)
// Uses ToString() method to return a string representation of the given card

namespace DeckOfCards
{
    public class Card
    {
        private string suit;
        private string rank;

        public string GetSuit()
        {
            return suit;
        }

        public void setSuit(string value)
        {
            suit = value;
        }

        public string GetRank()
        {
            return rank;
        }

        public void setRank(string value)
        {
            rank = value;
        }

        // Constructor
        // Includes some basic validation to ensure suit and rank are not empty or null
        public Card(string suit, string rank)
        {
            if (string.IsNullOrEmpty(suit) || string.IsNullOrEmpty(rank))
            {
                throw new ArgumentException("Suit and Rank can't be empty!");
            }

            this.suit = suit;
            this.rank = rank;
        }

        // concatenates rank and suit to get string representation of card
        // Overrides default ToString() method in order to provide a custom output
        // Without this, calling the ToString() method would just return the class name
        // This took a while to figure out haha
        // Reference: https://www.geeksforgeeks.org/c-sharp/method-overriding-in-c-sharp/
        public override string ToString()
        {
            return rank + " of " + suit;
        }
    }
}
