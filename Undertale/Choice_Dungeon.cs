using System;
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

            usercontrolCredit = new credit();
            usercontrolCredit.Visible = false;
            Controls.Add(usercontrolCredit);

            Script_superEndroitSTATIC.Visible = false;

            timer1.Interval = 4000;
            timer1.Start();
            timer1.Tick += timer1_Tick;
        }


        private void Button_exit_dungeon_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    usercontrolCredit.Visible = true;
                    timer1.Enabled = false;
                    userControl2.Visible = false;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnterDungeon.Visible = false;
                    Button_exit_dungeon.Visible = false;
                    Script_ChoiceDungeon.Visible = false;
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
                    userControl2.Visible = true;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnterDungeon.Visible = false;
                    Button_exit_dungeon.Visible = false;
                    Script_ChoiceDungeon.Visible = false;

                }));
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Script_ChoiceDungeon.Visible = false;
            Script_superEndroitSTATIC.Visible = true;
            timer1.Stop();
        }
    }
}
