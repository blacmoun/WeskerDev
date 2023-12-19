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
    public partial class Frame_InFrontOfTheDoor : UserControl
    {
        public Frame_hall Usercontrol5;

        public Frame_InFrontOfTheDoor()
        {
            InitializeComponent();
            Usercontrol5 = new Frame_hall();
            Usercontrol5.Visible = false;
            Controls.Add(Usercontrol5);
        }

        public void ButtonEnter_InFrontOfHouse_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    Usercontrol5.Visible = true;

                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnter_InFrontOfTheDoor.Visible = false;

                }));
            }

            Choice_Dungeon secondForm = new Choice_Dungeon();
            if (secondForm != null)
            {
                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
                secondForm.Script_superEndroitSTATIC.Visible = false;
            }

            Frame_TalkToGoatInDungeon thirdForm = new Frame_TalkToGoatInDungeon();
            if (thirdForm != null)
            {
                thirdForm.Button_ContinueAlone.Visible = false;
                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;
            }

            Frame_inFrontOfHouse fourthForm = new Frame_inFrontOfHouse();

            if (fourthForm != null)
            {
                if (fourthForm.InvokeRequired)
                {
                    fourthForm.Invoke(new Action(() =>
                    {
                        Usercontrol5.Visible = true;
                        fourthForm.userControl4.Visible = false;
                        fourthForm.ButtonGoToDoor.Visible = false;

                    }));
                }
            }
        }







    }
}

