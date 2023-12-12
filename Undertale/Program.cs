using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Windows.Forms;
using WindowsFormsApp1; // Assurez-vous d'ajuster le chemin vers votre espace de noms WindowsFormsApp1

namespace Undertale
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Undertale undertaleForm = new Undertale();
            undertaleForm.PlayButton.Click += (sender, e) => PlayButton_Click(undertaleForm);
            undertaleForm.QuitButton.Click += (sender, e) => QuitButton_Click(undertaleForm);
            Application.Run(undertaleForm);
        }

        private static void EnterName_next_button_Click(Game gameForm)
        {
            string enteredName = gameForm.TextBox_EnterName.Text.Trim();
            Player.SendNickname(enteredName);
            gameForm.EnterName_next_button.Visible = false;
            gameForm.EnterName_pictureBox.Visible = false;
            gameForm.TextBox_EnterName.Visible = false;
            ShowIntro();
        }

        private static void PlayButton_Click(Undertale undertaleForm)
        {
            Game gameForm = new Game();
            gameForm.EnterName_next_button.Click += (sender, e) => EnterName_next_button_Click(gameForm);
            gameForm.Show();
        }
        private static void QuitButton_Click(Undertale undertaleForm)
        {
            Application.Exit();
        }
        public static void ShowIntro()
        {
            Intro intro = new Intro();
            intro.Show();
        }
    }
}