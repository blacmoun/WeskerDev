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
    }
}
