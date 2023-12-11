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
    }
}