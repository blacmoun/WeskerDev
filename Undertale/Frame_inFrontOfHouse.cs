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
    public partial class Frame_inFrontOfHouse : UserControl
    {
        public Frame_InFrontOfTheDoor userControl4;

        public Frame_inFrontOfHouse()
        {
            InitializeComponent();
            userControl4 = new Frame_InFrontOfTheDoor();
            userControl4.Visible = false;
            Controls.Add(userControl4);
        }

        public void ButtonEnterDungeon_Click(object sender, EventArgs e)
        {

            Frame_TalkToGoatInDungeon thirdForm = new Frame_TalkToGoatInDungeon();
            if (thirdForm != null)
            {
                userControl4.Visible = true;
                thirdForm.userControl3.Visible = false;

                thirdForm.Button_ContinueTalkToGoat.Visible = false;
                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;



            }
            Choice_Dungeon secondForm = new Choice_Dungeon();
            if (secondForm != null)
            {
                userControl4.Visible = true;
                secondForm.userControl2.Visible = false;

                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
                thirdForm.Button_ContinueTalkToGoat.Visible = false;
                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;


            }
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    userControl4.Visible = true;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnterDungeon.Visible = false;
                    secondForm.Button_exit_dungeon.Visible = false;

                    if (!userControl4.Visible)
                    {
                        MessageBox.Show("Erreur : userControl2 ne s'affiche pas correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }




        }
    }
}
