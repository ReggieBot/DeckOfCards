// Deck of Cards Project: COSC2100
// Reggie Brown
// December 10, 2025
// Professor Fabian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Custom deck class to allow users to start with existing cards
// and accept additional custom cards
// inherits from Deck class
namespace DeckOfCards
{
    public class CustomDeck : Deck
    {
        // constructor for empty custom deck
        public CustomDeck()
        {
        }

        public CustomDeck(List<Card> initialCards)
        {
            for (int i = 0; i < initialCards.Count; i++)
            {
                cards.Add(initialCards[i]);
            }
        }
    }
}
