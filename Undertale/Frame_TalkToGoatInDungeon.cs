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
        public Frame_ContinueAlone userControl4;

        public Frame_TalkToGoatInDungeon()
        {
            InitializeComponent();
            userControl3 = new Frame_inFrontOfHouse();
            userControl3.Visible = false;
            Controls.Add(userControl3);

            userControl4 = new Frame_ContinueAlone();
            userControl4.Visible = false;
            Controls.Add(userControl4);
        }


        private void Button_FollowTheGoat_TalkToGoat_Click_1(object sender, EventArgs e)
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
                secondForm.Script_ChoiceDungeon.Visible = false;

                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
                Button_ContinueTalkToGoat.Visible = false;
                Button_FollowTheGoat_TalkToGoat.Visible = false;
                secondForm.Script_superEndroitSTATIC.Visible = false;
                secondForm.Script_ChoiceDungeon.Visible = false;
                Script_FriskTalkToGoat_STATIC.Visible = false;
                Script_talktoGoat.Visible = false;


            }
        }

        private void Button_ContinueTalkToGoat_Click(object sender, EventArgs e)
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
                userControl3.Visible = false;
                userControl4.Visible = true;
                secondForm.userControl2.Visible = false;
                secondForm.Script_ChoiceDungeon.Visible = false;
                secondForm.Script_superEndroitSTATIC.Visible = false;
                secondForm.Script_ChoiceDungeon.Visible = false;
                Script_talktoGoat.Visible = false;
                Script_FriskTalkToGoat_STATIC.Visible = false;

                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
                Button_ContinueTalkToGoat.Visible = false;
                Button_FollowTheGoat_TalkToGoat.Visible = false;
                secondForm.Script_superEndroitSTATIC.Visible = false;
                secondForm.Script_ChoiceDungeon.Visible = false;


            }
        }

        public void Timer_FriskTalkToGoat_Tick(object sender, EventArgs e)
        {
            Script_talktoGoat.Visible = false;
            Timer_FriskTalkToGoat.Stop();
        }


    }
}
