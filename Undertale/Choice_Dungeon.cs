using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Choice_Dungeon : UserControl
    {
        public Frame_TalkToGoatInDungeon userControl2;

        private bool estCharge = false;

        public Choice_Dungeon()
        {
            InitializeComponent();
            userControl2 = new Frame_TalkToGoatInDungeon();
            userControl2.Visible = false;
            Controls.Add(userControl2);
        }

        public async void ChargerRessourcesSiNecessaire()
        {
            if (!estCharge)
            {
                // Code de chargement des ressources (exécuté de manière asynchrone)
                await Task.Run(() =>
                {
                    // Mettez ici le code pour charger les ressources nécessaires
                    // Remplacez ce commentaire par le code réel
                    System.Threading.Thread.Sleep(5000);  // Exemple de chargement synchrone (remplacez cela par votre propre logique)
                });

                estCharge = true;
            }
        }

        private void Button_exit_dungeon_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void ButtonEnterDungeon_Click(object sender, EventArgs e)
        {
            ChargerRessourcesSiNecessaire();

            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    userControl2.Visible = true;
                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;
                    ButtonEnterDungeon.Visible = false;
                    Button_exit_dungeon.Visible = false;

                    if (!userControl2.Visible)
                    {
                        MessageBox.Show("Erreur : userControl2 ne s'affiche pas correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            }
        }
    }
}
