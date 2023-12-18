using System;
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
            EnterName_pictureBox_Static.Visible = false;

            timer1.Interval = 3000;
            timer1.Start();
            timer1.Tick += timer1_Tick;

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
                if (!string.IsNullOrEmpty(TextBox_EnterName.Text.Trim()))
                {
                    ShowChoiceDungeon();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EnterName_pictureBox.Visible = false;
            EnterName_pictureBox_Static.Visible = true;
            timer1.Stop();

        }

        private void EnterName_next_button_KeyDown(object sender, KeyEventArgs e)
        {
            Game gameForm = new Game();
            if (e.KeyCode == Keys.Enter)
            {
                Program.EnterName_next_button_Click(gameForm);
            }
        }
    }
}