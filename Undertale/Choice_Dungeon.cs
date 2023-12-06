using System;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Choice_Dungeon : UserControl
    {
        public Choice_Dungeon()
        {
            InitializeComponent();
        }

        private void Button_exit_dungeon_Click(object sender, EventArgs e)
        {
            // Accéder au formulaire parent et le fermer
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEnterDungeon_Click(object sender, EventArgs e)
        {

        }
    }
}
