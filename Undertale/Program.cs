using System.Windows.Forms;

namespace Undertale
{
    public static class Program
    {
        public static Undertale? undertaleForm;
        public static Intro? introControl;
        public static Choice_Dungeon? ChoiceControl;
        public static Frame_TalkToGoatInDungeon? Frame_TalkGoatControl;
        public static credit? creditControl;
        public static Frame_ContinueAlone? Frame_ContinueAloneControl;
        public static Frame_inFrontOfHouse? Frame_InFrontOfHouseControl;
        public static Frame_InFrontOfTheDoor? Frame_InFrontOfTheDoorControl;
        public static Frame_hall? Frame_hallControl;
        public static Frame_LivingRoom? Frame_LivingRoomControl;
        public static Frame_kitchen? Frame_kitchenControl;
        public static Frame_Bathroom? Frame_BathroomControl;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            undertaleForm = new Undertale();
            undertaleForm.PlayButton.Click += (sender, e) => PlayButton_Click();
            undertaleForm.QuitButton.Click += (sender, e) => QuitButton_Click();

            Application.Run(undertaleForm);
        }

        public static void PlayButton_Click()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;
            gameForm.EnterName_next_button.Click += (sender, e) => EnterName_next_button_Click(gameForm);
            gameForm.Show();
        }

        public static void QuitButton_Click()
        {
            Application.Exit();
        }

        public static void ShowIntro()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;

            if (introControl == null)
            {
                introControl = new Intro();
                gameForm.Controls.Clear();
                gameForm.Controls.Add(introControl);
                gameForm.Visible = true;
                introControl.button_skip.Click += (sender, e) => button_skip_click();
                introControl.button_skip.Click += (sender, e) => gameForm.Close();
            }
        }
        public static void EnterName_next_button_Click(Game gameForm)
        {
            string enteredName = gameForm.TextBox_EnterName.Text.Trim();
            Player.SendNickname(enteredName);
            gameForm.EnterName_next_button.Visible = false;
            gameForm.EnterName_pictureBox.Visible = false;
            gameForm.TextBox_EnterName.Visible = false;
            gameForm.Close();
            ShowIntro();
        }
        public static void button_skip_click()
        {
            ShowChoiceDungon();
        }
        public static void ShowChoiceDungon()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;
            ChoiceControl = new Choice_Dungeon();
            gameForm.Controls.Clear();
            gameForm.Controls.Add(ChoiceControl);
            gameForm.Visible = true;
            ChoiceControl.ButtonEnterDungeon.Click += (sender, e) => ButtonEnterDungeon_Click();
            ChoiceControl.ButtonEnterDungeon.Click += (sender, e) => gameForm.Close();
            ChoiceControl.Button_exit_dungeon.Click += (sender, e) => Button_exit_dungeon_Click();
            ChoiceControl.Button_exit_dungeon.Click += (sender, e) => gameForm.Close();
        }
        public static void ButtonEnterDungeon_Click()
        {
            ShowTalkGoat();
        }
        public static void Button_exit_dungeon_Click()
        {
            ShowCredit();
        }
        public static void ShowTalkGoat()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;
            Frame_TalkGoatControl = new Frame_TalkToGoatInDungeon();
            gameForm.Controls.Clear();
            gameForm.Controls.Add(Frame_TalkGoatControl);
            gameForm.Visible = true;
            Frame_TalkGoatControl.Button_ContinueAlone.Click += (sender, e) => Button_ContinueAlone_Click();
            Frame_TalkGoatControl.Button_ContinueAlone.Click += (sender, e) => gameForm.Close();
            Frame_TalkGoatControl.Button_FollowTheGoat_TalkToGoat.Click += (sender, e) => Button_FollowTheGoat_TalkToGoat_Click();
            Frame_TalkGoatControl.Button_FollowTheGoat_TalkToGoat.Click += (sender, e) => gameForm.Close();
        }
        public static void ShowCredit()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;
            creditControl = new credit();
            gameForm.Controls.Clear();
            gameForm.Controls.Add(creditControl);
            gameForm.Visible = true;
        }
        public static void Button_ContinueAlone_Click()
        {
            ShowAlone();
        }
        public static void Button_FollowTheGoat_TalkToGoat_Click()
        {
            ShowInFrontHouse();
        }
        public static void ShowAlone()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;
            Frame_ContinueAloneControl = new Frame_ContinueAlone();
            gameForm.Controls.Clear();
            gameForm.Controls.Add(Frame_ContinueAloneControl);
            gameForm.Visible = true;
        }
        public static void ShowInFrontHouse()
        {
            Game gameForm = new Game();
            gameForm.WindowState = FormWindowState.Maximized;
            Frame_InFrontOfHouseControl = new Frame_inFrontOfHouse();
            gameForm.Controls.Clear();
            gameForm.Controls.Add(Frame_InFrontOfHouseControl);
            gameForm.Visible = true;
        }
    }
}