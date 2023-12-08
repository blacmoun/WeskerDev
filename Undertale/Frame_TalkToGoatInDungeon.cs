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

    public partial class Frame_TalkToGoatInDungeon : UserControl
    {
        public Frame_inFrontOfHouse userControl3;


        public Frame_TalkToGoatInDungeon()
        {
            InitializeComponent();
            userControl3 = new Frame_inFrontOfHouse();
            userControl3.Visible = false;
            Controls.Add(userControl3);


        }

        public void Button_nextTalkToGoat_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.EnterName_pictureBox.Visible = false;

                parentForm.TextBox_EnterName.Visible = false;
                parentForm.EnterName_next_button.Visible = false;
            }

            Choice_Dungeon secondForm = new Choice_Dungeon();
            if (secondForm != null)
            {
                userControl3.Visible = true;
                secondForm.userControl2.Visible = false;

                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
                Button_nextTalkToGoat.Visible = false;

                if (!userControl3.Visible)
                {
                    MessageBox.Show("Erreur : userControl2 ne s'affiche pas correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
