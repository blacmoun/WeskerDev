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
        public void Timer_FriskTalkToGoat_Tick(object sender, EventArgs e)
        {
            Script_talktoGoat.Visible = false;
            Timer_FriskTalkToGoat.Stop();
        }
    }
}
