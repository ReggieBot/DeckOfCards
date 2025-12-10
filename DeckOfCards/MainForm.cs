// Deck of Cards Project: COSC2100
// Reggie Brown
// December 10, 2025
// Professor Fabian

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the main form for the application
// all of the user interface and event handling will be done here
namespace DeckOfCards
{
    public partial class MainForm : Form
    {
        // standard deck
        private NormalDeck normalDeck;

        // current deck
        private CustomDeck currentDeck;

        // collection to hold dealt cards
        private List<Card> dealtCards;


        // constructor
        public MainForm()
        {
            InitializeComponent();
            dealtCards = new List<Card>();
            setupEventHandlers();
            InitializeDecks();
        }


        // connect event handlers to buttons
        private void setupEventHandlers()
        {
            txtSuit.KeyDown += CardInput_KeyDown;
            txtRank.KeyDown += CardInput_KeyDown;
            txtDraw.KeyDown += DrawInput_KeyDown;

            buttonCustom.Click += BtnAddCustomClick;
            buttonDeal.Click += BtnDealClick;
            buttonViewDeck.Click += BtnViewDeckClick;
            buttonShuffle.Click += BtnShuffleClick;
            buttonReset.Click += BtnResetClick;
            buttonExit.Click += ExitApp;
        }

        // create fresh deck and update display
        private void InitializeDecks()
        {
            normalDeck = new NormalDeck();
            currentDeck = new CustomDeck(normalDeck.cards);
            dealtCards.Clear();

            updateDeckDisplay();
            updateDealtDisplay();
        }

        // update deck listview to show current cards in deck
        private void updateDeckDisplay()
        {
            lvDeck.Items.Clear();

            for (int i = 0; i < currentDeck.GetCount(); i++)
            {
                Card card = currentDeck.cards[i];
                string DisplayText = card.ToString();
                lvDeck.Items.Add(DisplayText);
            }
        }

        // update dealt cards listview to show dealt cards
        private void updateDealtDisplay()
        {
            lvDealt.Items.Clear();

            for (int i = 0; i < dealtCards.Count; i++)
            {
                Card card = dealtCards[i];
                string displayText = card.ToString();
                lvDealt.Items.Add(displayText);
            }
        }

        // Reset everything
        private void ResetAll()
        {
            txtSuit.Clear();
            txtRank.Clear();
            txtDraw.Clear();
            InitializeDecks();

            // make suit the focus
            txtSuit.Focus();

        }

        // exit application
        private void ExitApp(object sender, EventArgs e)
        {
            try
            {
                ResetAll();
            }
            // shows error message if something goes wrong during reset
            // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-7.0
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting application before exit" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // finally get to use a finally!
            finally
            {
                Application.Exit();
            }
        }


        // check if custom card input is valid
        // check sif suit and rank are valid
        // returns true if valid, false otherwise
        // Reference for MessageBox:
        // https://stackoverflow.com/questions/2109441/how-to-show-a-custom-error-or-warning-message-box-in-net-winforms

        private bool IsCustomCardValid(string suit, string rank)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(suit))
            {
                MessageBox.Show("Suit can't be empty!", "Invalid suit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (string.IsNullOrEmpty(rank))
            {
                MessageBox.Show("Rank can't be empty!", "Invalid Rank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            return valid;
        }


        // check if draw amount input is valid
        // returns true if valid, false otherwise
        private bool IsDrawAmountValid(string drawText)
        {
            // check if blank
            if (string.IsNullOrEmpty(drawText))
            {
                MessageBox.Show("Draw amount can't be empty", "Invalid Draw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // try to convert to integer if possible
            // stores result in amount variable using out parameter
            // out parameter reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out
            // try parse reference: https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-10.0
            int amount;
            bool isNumber = int.TryParse(drawText, out amount);

            if (isNumber == false)
            {
                MessageBox.Show("Draw amount must be valid number", "Invalid Draw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check if greater than zero
            if (amount <= 0)
            {
                MessageBox.Show("Draw amount must be greater than zero", "Invalid Draw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // event handler for add custom button click
        private void BtnAddCustomClick(object sender, EventArgs e)
        {
            try
            {
                string suit = txtSuit.Text.Trim();
                string rank = txtRank.Text.Trim();

                // validate custom card input
                if (IsCustomCardValid(suit, rank) == false)
                {
                    return;
                }

                // create new card and add to current deck
                Card newCard = new Card(suit, rank);
                currentDeck.AddCard(newCard);

                // clear input fields and focus suit
                txtSuit.Clear();
                txtRank.Clear();
                txtSuit.Focus();

                // update deck display
                updateDeckDisplay();
            }

            // catch exceptions
            catch (Exception ex)
            {
                MessageBox.Show("Error adding xustom card" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // handler for when enter key is pressed in suit or rank text box
        // KeyEventArgs reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keyeventargs?view=windowsdesktop-7.0
        // KeyDown reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.keydown?view=windowsdesktop-7.0
        private void CardInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddCustomClick(buttonCustom, EventArgs.Empty);
            }
        }

        // handler for when enter key is pressed in draw amount text box
        private void DrawInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnDealClick(buttonDeal, EventArgs.Empty);
            }
        }

        // event handler for deal button click
        private void BtnDealClick(object sender, EventArgs e)
        {
            try
            {
                // check if valid
                if (IsDrawAmountValid(txtDraw.Text) == false)
                {
                    return;
                }

                // parse 
                int amount = int.Parse(txtDraw.Text);

                // deal
                List<Card> newDealCards = currentDeck.Deal(amount);

                // add to dealt cards collection
                for (int i = 0; i < newDealCards.Count; i++)
                {
                    dealtCards.Add(newDealCards[i]);
                }

                // update displays
                updateDeckDisplay();
                updateDealtDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error dealing cards " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // event handler for view deck button click
        private void BtnViewDeckClick(object sender, EventArgs e)
        {
            try
            {
                updateDeckDisplay();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error viewing deck " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // event handler for shuffle
        private void BtnShuffleClick(object sender, EventArgs e)
        {
            try
            {
                currentDeck.Shuffle();
                updateDeckDisplay();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error shuffling deck " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // event handler for reset button click
        private void BtnResetClick(object sender, EventArgs e)
        {
            try
            {
                ResetAll();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error resetting application " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}