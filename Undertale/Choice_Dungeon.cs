﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Choice_Dungeon : UserControl
    {
        public Frame_TalkToGoatInDungeon userControl2;
        public credit usercontrolCredit;

        public Choice_Dungeon()
        {
            InitializeComponent();
            userControl2 = new Frame_TalkToGoatInDungeon();
            userControl2.Visible = false;
            Controls.Add(userControl2);
            Script_superEndroitSTATIC.Visible = true;

            usercontrolCredit = new credit();
            usercontrolCredit.Visible = false;
            Controls.Add(usercontrolCredit);



        }


        private void Button_exit_dungeon_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    usercontrolCredit.Visible = true;

                    userControl2.Visible = false;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnterDungeon.Visible = false;
                    Button_exit_dungeon.Visible = false;
                    Script_superEndroitSTATIC.Visible = false;
                }));
            }




            credit creditForm = new credit();

            if (creditForm != null)
            {
                if (creditForm.InvokeRequired)
                {
                    creditForm.Invoke(new Action(() =>
                    {
                        usercontrolCredit.Visible = true;


                    }));
                }
            }

        }

        private void ButtonEnterDungeon_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    Script_superEndroitSTATIC.Enabled = false;
                    Script_superEndroitSTATIC.Visible = false;

                    userControl2.Visible = true;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnterDungeon.Visible = false;
                    Button_exit_dungeon.Visible = false;


                }));
            }


        }
    }
}
