namespace Undertale
{
    public partial class Game : Form
    {
        public Intro userControl0;

        public Game()
        {
            InitializeComponent();

            userControl0 = new Intro();
            userControl0.Visible = false;
            Controls.Add(userControl0);
            EnterName_pictureBox_Static.Visible = false;

            TextBox_EnterName.Text = TextBox_EnterName.Text.ToUpper();

            EnterName_next_button.Enabled = !string.IsNullOrEmpty(TextBox_EnterName.Text);
            TextBox_EnterName.TextChanged += TextBox_EnterName_TextChanged;
        }

        public void TextBox_EnterName_TextChanged(object sender, EventArgs e)
        {
            EnterName_next_button.Enabled = !string.IsNullOrEmpty(TextBox_EnterName.Text);
        }

    }
}