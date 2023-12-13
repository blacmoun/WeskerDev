using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;
 
namespace Undertale
{
    public static class Program
    {
        public static Undertale undertaleForm;

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
            gameForm.EnterName_next_button.Click += (sender, e) => EnterName_next_button_Click(gameForm);
            gameForm.Show();
        }

        public static void QuitButton_Click()
        {
            Application.Exit();
        }

        public static void ShowIntro()
        {
            Intro userControl0 = new Intro();

            undertaleForm.Controls.Add(userControl0);
            userControl0.Show();

        }

        public static void EnterName_next_button_Click(Game gameForm)
        {
            string enteredName = gameForm.TextBox_EnterName.Text.Trim();
            Player.SendNickname(enteredName);
            gameForm.EnterName_next_button.Visible = false;
            gameForm.EnterName_pictureBox.Visible = false;
            gameForm.TextBox_EnterName.Visible = false;
            ShowIntro();
        }


    }
}