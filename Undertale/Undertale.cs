using System.Drawing;

namespace Undertale
{
    public partial class Undertale : Form
    {
        public Undertale()
        {

            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettButton_Click(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {


            // Créez une nouvelle instance de la deuxième forme (Game)
            Game nouvelleForm = new Game();

            // Centrez le PictureBox en haut de l'écran
            nouvelleForm.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nouvelleForm.pictureBox1.Dock = DockStyle.Top;

            // Mettez la nouvelle forme en plein écran
            nouvelleForm.WindowState = FormWindowState.Maximized;

            // Affichez la nouvelle forme
            nouvelleForm.Show();


        }
    }
}