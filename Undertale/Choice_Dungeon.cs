using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Choice_Dungeon : UserControl
    {
        public Frame_TalkToGoatInDungeon userControl2;


        public Choice_Dungeon()
        {
            InitializeComponent();
            userControl2 = new Frame_TalkToGoatInDungeon();
            userControl2.Visible = false;
            Controls.Add(userControl2);
        }


        private void Button_exit_dungeon_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Close();
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

                    if (!userControl2.Visible)
                    {
                        MessageBox.Show("Erreur : userControl2 ne s'affiche pas correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
        }
    }
}
