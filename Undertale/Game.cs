﻿using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Undertale
{
    public partial class Game : Form
    {
        public Intro userControl0;

        public Game()
        {
            InitializeComponent();

            userControl0 = new Intro();
            userControl0.Visible = false;
            Controls.Add(userControl0);

            TextBox_EnterName.Text = TextBox_EnterName.Text.ToUpper();

            EnterName_next_button.Enabled = !string.IsNullOrEmpty(TextBox_EnterName.Text);
            TextBox_EnterName.TextChanged += TextBox_EnterName_TextChanged;
        }

        public void TextBox_EnterName_TextChanged(object sender, EventArgs e)
        {
            EnterName_next_button.Enabled = !string.IsNullOrEmpty(TextBox_EnterName.Text);
        }

        public void ShowChoiceDungeon()
        {
            userControl0.Visible = true;
            EnterName_next_button.Visible = false;
            EnterName_pictureBox.Visible = false;
            TextBox_EnterName.Visible = false;
            
        }

        public void EnterName_next_button_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox_EnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TextBox_EnterName.Text.Trim()))  // Vérifie si le texte n'est pas vide (après suppression des espaces)
                {
                    ShowChoiceDungeon();
                }
            }
        }


    }
}
