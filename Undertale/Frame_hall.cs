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
    public partial class Frame_hall : UserControl
    {
        public Frame_LivingRoom Usercontrol6;
        public Frame_Bathroom Usercontrol7;


        public Frame_hall()
        {
            InitializeComponent();
            Usercontrol6 = new Frame_LivingRoom();
            Usercontrol6.Visible = false;
            Controls.Add(Usercontrol6);

            Usercontrol7 = new Frame_Bathroom();
            Usercontrol7.Visible = false;
            Controls.Add(Usercontrol7);
        }

        private void Button_livingRoom_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {

                    Usercontrol6.Visible = true;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    Button_livingRoom.Visible = false;
                    Button_Bathroom.Visible = false;

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
                        Usercontrol6.Visible = true;
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
                        Usercontrol6.Visible = true;
                        fifthForm.Usercontrol5.Visible = false;
                        fifthForm.ButtonEnter_InFrontOfTheDoor.Visible = false;

                    }));
                }
            }
        }




        private void Button_Bathroom_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {

                    Usercontrol7.Visible = true;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    Button_livingRoom.Visible = false;
                    Button_Bathroom.Visible = false;

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
                        Usercontrol6.Visible = true;
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
                        Usercontrol6.Visible = true;
                        fifthForm.Usercontrol5.Visible = false;
                        fifthForm.ButtonEnter_InFrontOfTheDoor.Visible = false;

                    }));
                }
            }
            Frame_InFrontOfTheDoor sixthForm = new Frame_InFrontOfTheDoor();

            if (fifthForm != null)
            {
                if (fifthForm.InvokeRequired)
                {
                    fifthForm.Invoke(new Action(() =>
                    {
                        Usercontrol7.Visible = true;
                        fifthForm.Usercontrol5.Visible = false;
                        fifthForm.ButtonEnter_InFrontOfTheDoor.Visible = false;

                    }));
                }
            }
        }
    }
}


