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
    public partial class Frame_ContinueAlone : UserControl
    {
        public Frame_cryAroundTheFire userControl9;
        public Frame_ToTheEndOfTheWay userControl10;


        public Frame_ContinueAlone()
        {
            InitializeComponent();
            userControl9 = new Frame_cryAroundTheFire();
            userControl9.Visible = false;
            Controls.Add(userControl9);

            userControl10 = new Frame_ToTheEndOfTheWay();
            userControl10.Visible = false;
            Controls.Add(userControl10);
        }


        public void ButtonCryArroundTheFire_Click(object sender, EventArgs e)
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
                userControl9.Visible = true;
                secondForm.userControl2.Visible = false;

                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;

                secondForm.Script_superEndroitSTATIC.Visible = false;


            }
            Frame_TalkToGoatInDungeon thirdForm = new Frame_TalkToGoatInDungeon();
            if (thirdForm != null)
            {

                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;
                thirdForm.Script_talktoGoat.Visible = false;
                Button_CryArroundTheFire.Visible = false;


            }

        }

        public void Button_ContinueToTheEnd_Click(object sender, EventArgs e)
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
                userControl9.Visible = false;
                userControl10.Visible = true;

                secondForm.userControl2.Visible = false;

                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;

                secondForm.Script_superEndroitSTATIC.Visible = false;


            }
            Frame_TalkToGoatInDungeon thirdForm = new Frame_TalkToGoatInDungeon();
            if (thirdForm != null)
            {
                Button_ContinueToTheEnd.Visible = false;
                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;
                thirdForm.Script_talktoGoat.Visible = false;
                Button_CryArroundTheFire.Visible = false;


            }

        }

    }
}
