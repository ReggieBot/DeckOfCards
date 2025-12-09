// Deck of Cards Project: COSC2100
// Reggie Brown
// December 9, 2025
// Professor Fabian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// standard 52-card deck
// inherits from Deck class
// Reference: https://www.w3schools.com/cs/cs_inheritance.php
namespace DeckOfCards
{
    public class NormalDeck : Deck
    {
        public NormalDeck()
        {
            CreateDeck();
        }
    }
}
