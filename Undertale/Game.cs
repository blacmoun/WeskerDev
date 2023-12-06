using System;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Game : Form
    {
        private Choice_Dungeon userControl1;

        public Game()
        {
            InitializeComponent();
            userControl1 = new Choice_Dungeon();
            userControl1.Visible = false;
            Controls.Add(userControl1);
            TextBox_EnterName.Text = TextBox_EnterName.Text.ToUpper();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            userControl1.Visible = true;
            EnterName_next_button.Visible = false;
            EnterName_pictureBox.Visible = false;
            TextBox_EnterName.Visible = false;
        }
    }
}
