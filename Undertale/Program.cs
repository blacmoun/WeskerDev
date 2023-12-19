using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;
 
namespace Undertale
{
    public static class Program
    {
        public static Undertale undertaleForm;
        public static Intro introControl;
        public static Choice_Dungeon ChoiceControl;

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
        }
    }
}