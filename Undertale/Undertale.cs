using System.Drawing;
using System.Media;

namespace Undertale
{
    public partial class Undertale : Form
    {
    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Undertale()
        {

            InitializeComponent();
            player.SoundLocation= "Resources/Undertale-OST-012-Home.wav";
            player.Play();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {


            // Créez une nouvelle instance de la deuxième forme (Game)
            Game nouvelleForm = new Game();

            // Centrez le PictureBox en haut de l'écran
            nouvelleForm.EnterName_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nouvelleForm.EnterName_pictureBox.Dock = DockStyle.Top;

            // Mettez la nouvelle forme en plein écran
            nouvelleForm.WindowState = FormWindowState.Maximized;

            // Affichez la nouvelle forme
            nouvelleForm.Show();

            this.Visible = false;
            player.Stop();


        }
    }
}