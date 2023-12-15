using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Intro : UserControl
    {


        public Choice_Dungeon userControl1;

        public Intro()
        {
            InitializeComponent();

            userControl1 = new Choice_Dungeon();
            userControl1.Visible = false;
            Controls.Add(userControl1);

            userControl1.Enabled = false;

        }


        public void SkipIntro()
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    userControl1.Visible = true;
                    pictureBox1.Visible = false;
                    parentForm.EnterName_next_button.Visible = false;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;

                    button_skip.Visible = false;


                    if (!userControl1.Visible)
                    {
                        MessageBox.Show("Erreur : userControl1 ne s'affiche pas correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
        }

        private void pictureBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SkipIntro();
            }
            button_skip.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl1.Enabled = true;

            userControl1.timer_Choice_dungeon.Interval = 4000;
            userControl1.timer_Choice_dungeon.Start();
            userControl1.timer_Choice_dungeon.Tick += userControl1.timer1_Tick;
            SkipIntro();


        }
    }
}
