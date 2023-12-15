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
    public partial class Frame_LivingRoom : UserControl
    {
        public Frame_kitchen userControl8;

        public Frame_LivingRoom()
        {
            InitializeComponent();
            userControl8 = new Frame_kitchen();
            userControl8.Visible = false;
            Controls.Add(userControl8);
        }

        private void ButtonEnter_InFrontOfTheDoor_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {

                    userControl8.Visible = true;
                    Button_ToKitchenFromLivingRoom.Visible = false;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;


                }));
            }

            Choice_Dungeon secondForm = new Choice_Dungeon();
            if (secondForm != null)
            {
                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
            }

            Frame_TalkToGoatInDungeon thirdForm = new Frame_TalkToGoatInDungeon();
            if (thirdForm != null)
            {
                thirdForm.Button_ContinueTalkToGoat.Visible = false;
                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;
            }

            Frame_inFrontOfHouse fourthForm = new Frame_inFrontOfHouse();

            if (fourthForm != null)
            {
                if (fourthForm.InvokeRequired)
                {
                    fourthForm.Invoke(new Action(() =>
                    {
                        fourthForm.userControl4.Visible = false;
                        fourthForm.ButtonGoToDoor.Visible = false;

                    }));
                }
            }
            Frame_InFrontOfTheDoor fifthForm = new Frame_InFrontOfTheDoor();

            if (fifthForm != null)
            {
                if (fifthForm.InvokeRequired)
                {
                    fifthForm.Invoke(new Action(() =>
                    {

                        fifthForm.Usercontrol5.Visible = false;
                        fifthForm.ButtonEnter_InFrontOfTheDoor.Visible = false;

                    }));
                }
            
            }

        }
    }
}
