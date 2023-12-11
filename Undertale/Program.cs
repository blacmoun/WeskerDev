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
            Application.Run(undertaleForm);
            if (undertaleForm.DialogResult == DialogResult.OK)
            {
                Game gameForm = new Game();

                gameForm.EnterName_next_button.Click += (sender, e) => EnterName_next_button_Click(gameForm);

                Application.Run(gameForm);
            }
        }
        private static void EnterName_next_button_Click(Game gameForm)
        {
            string enteredName = gameForm.TextBox_EnterName.Text.Trim();
            Player.SendNickname(enteredName);
            gameForm.ShowChoiceDungeon();
        }
    }
}





