namespace DeckOfCards
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtSuit = new System.Windows.Forms.TextBox();
            this.lblSuit = new System.Windows.Forms.Label();
            this.grpDraw = new System.Windows.Forms.GroupBox();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.lblDraw = new System.Windows.Forms.Label();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.grpDealt = new System.Windows.Forms.GroupBox();
            this.lblDealt = new System.Windows.Forms.Label();
            this.lvDealt = new System.Windows.Forms.ListView();
            this.grpDeck = new System.Windows.Forms.GroupBox();
            this.lvDeck = new System.Windows.Forms.ListView();
            this.lblDeck = new System.Windows.Forms.Label();
            this.buttonViewDeck = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.grpDraw.SuspendLayout();
            this.grpDealt.SuspendLayout();
            this.grpDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCustom);
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.lblRank);
            this.groupBox1.Controls.Add(this.txtSuit);
            this.groupBox1.Controls.Add(this.lblSuit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card";
            // 
            // buttonCustom
            // 
            this.buttonCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom.Location = new System.Drawing.Point(223, 49);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(112, 47);
            this.buttonCustom.TabIndex = 4;
            this.buttonCustom.Text = "Add &Custom";
            this.toolTipMain.SetToolTip(this.buttonCustom, "Add a custom card (suit and rank) to the deck");
            this.buttonCustom.UseVisualStyleBackColor = true;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(86, 84);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(100, 31);
            this.txtRank.TabIndex = 3;
            this.toolTipMain.SetToolTip(this.txtRank, "Enter the card rank");
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(15, 85);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 20);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "&Rank";
            // 
            // txtSuit
            // 
            this.txtSuit.Location = new System.Drawing.Point(86, 30);
            this.txtSuit.Name = "txtSuit";
            this.txtSuit.Size = new System.Drawing.Size(100, 31);
            this.txtSuit.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.txtSuit, "Enter the card suit");
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuit.Location = new System.Drawing.Point(15, 36);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(37, 20);
            this.lblSuit.TabIndex = 0;
            this.lblSuit.Text = "S&uit";
            // 
            // grpDraw
            // 
            this.grpDraw.Controls.Add(this.buttonDeal);
            this.grpDraw.Controls.Add(this.lblDraw);
            this.grpDraw.Controls.Add(this.txtDraw);
            this.grpDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDraw.Location = new System.Drawing.Point(10, 269);
            this.grpDraw.Name = "grpDraw";
            this.grpDraw.Size = new System.Drawing.Size(352, 107);
            this.grpDraw.TabIndex = 1;
            this.grpDraw.TabStop = false;
            // 
            // buttonDeal
            // 
            this.buttonDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeal.Location = new System.Drawing.Point(223, 41);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(112, 31);
            this.buttonDeal.TabIndex = 7;
            this.buttonDeal.Text = "&Deal";
            this.toolTipMain.SetToolTip(this.buttonDeal, "Deal");
            this.buttonDeal.UseVisualStyleBackColor = true;
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(14, 48);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(46, 20);
            this.lblDraw.TabIndex = 5;
            this.lblDraw.Text = "&Draw";
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(86, 41);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(100, 31);
            this.txtDraw.TabIndex = 6;
            this.toolTipMain.SetToolTip(this.txtDraw, "Enter how many cards to deal from deck");
            // 
            // grpDealt
            // 
            this.grpDealt.Controls.Add(this.lblDealt);
            this.grpDealt.Controls.Add(this.lvDealt);
            this.grpDealt.Location = new System.Drawing.Point(12, 407);
            this.grpDealt.Name = "grpDealt";
            this.grpDealt.Size = new System.Drawing.Size(350, 230);
            this.grpDealt.TabIndex = 2;
            this.grpDealt.TabStop = false;
            // 
            // lblDealt
            // 
            this.lblDealt.AutoSize = true;
            this.lblDealt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealt.Location = new System.Drawing.Point(100, 38);
            this.lblDealt.Name = "lblDealt";
            this.lblDealt.Size = new System.Drawing.Size(125, 25);
            this.lblDealt.TabIndex = 1;
            this.lblDealt.Text = "Cards Dealt";
            // 
            // lvDealt
            // 
            this.lvDealt.FullRowSelect = true;
            this.lvDealt.GridLines = true;
            this.lvDealt.HideSelection = false;
            this.lvDealt.Location = new System.Drawing.Point(59, 94);
            this.lvDealt.Name = "lvDealt";
            this.lvDealt.Size = new System.Drawing.Size(206, 115);
            this.lvDealt.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.lvDealt, "Shows all cards that have been dealt");
            this.lvDealt.UseCompatibleStateImageBehavior = false;
            this.lvDealt.View = System.Windows.Forms.View.Details;
            // 
            // grpDeck
            // 
            this.grpDeck.Controls.Add(this.lvDeck);
            this.grpDeck.Controls.Add(this.lblDeck);
            this.grpDeck.Location = new System.Drawing.Point(407, 23);
            this.grpDeck.Name = "grpDeck";
            this.grpDeck.Size = new System.Drawing.Size(352, 614);
            this.grpDeck.TabIndex = 3;
            this.grpDeck.TabStop = false;
            // 
            // lvDeck
            // 
            this.lvDeck.FullRowSelect = true;
            this.lvDeck.GridLines = true;
            this.lvDeck.HideSelection = false;
            this.lvDeck.Location = new System.Drawing.Point(52, 73);
            this.lvDeck.Name = "lvDeck";
            this.lvDeck.Size = new System.Drawing.Size(241, 505);
            this.lvDeck.TabIndex = 9;
            this.toolTipMain.SetToolTip(this.lvDeck, "Show all cards in the deck");
            this.lvDeck.UseCompatibleStateImageBehavior = false;
            this.lvDeck.View = System.Windows.Forms.View.Details;
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(129, 39);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(77, 31);
            this.lblDeck.TabIndex = 0;
            this.lblDeck.Text = "Deck";
            // 
            // buttonViewDeck
            // 
            this.buttonViewDeck.Location = new System.Drawing.Point(794, 96);
            this.buttonViewDeck.Name = "buttonViewDeck";
            this.buttonViewDeck.Size = new System.Drawing.Size(119, 34);
            this.buttonViewDeck.TabIndex = 10;
            this.buttonViewDeck.Text = "&View Deck";
            this.toolTipMain.SetToolTip(this.buttonViewDeck, "Show all cards in the deck");
            this.buttonViewDeck.UseVisualStyleBackColor = true;
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Location = new System.Drawing.Point(794, 185);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(119, 36);
            this.buttonShuffle.TabIndex = 11;
            this.buttonShuffle.Text = "&Shuffle";
            this.toolTipMain.SetToolTip(this.buttonShuffle, "Randomly shuffle deck");
            this.buttonShuffle.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(794, 269);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(119, 37);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTipMain.SetToolTip(this.buttonReset, "Resets all inputs and restores state");
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(794, 357);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 37);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.toolTipMain.SetToolTip(this.buttonExit, "Exit application");
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 661);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.buttonViewDeck);
            this.Controls.Add(this.grpDeck);
            this.Controls.Add(this.grpDealt);
            this.Controls.Add(this.grpDraw);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reggie\'s Deck Builder!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDraw.ResumeLayout(false);
            this.grpDraw.PerformLayout();
            this.grpDealt.ResumeLayout(false);
            this.grpDealt.PerformLayout();
            this.grpDeck.ResumeLayout(false);
            this.grpDeck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.TextBox txtSuit;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.GroupBox grpDraw;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.GroupBox grpDealt;
        private System.Windows.Forms.ListView lvDealt;
        private System.Windows.Forms.Label lblDealt;
        private System.Windows.Forms.GroupBox grpDeck;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.ListView lvDeck;
        private System.Windows.Forms.Button buttonViewDeck;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

