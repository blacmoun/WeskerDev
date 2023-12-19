namespace Undertale
{
    partial class Frame_TalkToGoatInDungeon
    {

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_TalkToGoatInDungeon));
            Button_ContinueAlone = new WindowsFormsApp1.RJButton();
            Button_FollowTheGoat_TalkToGoat = new WindowsFormsApp1.RJButton();
            Timer_FriskTalkToGoat = new System.Windows.Forms.Timer(components);
            Script_talktoGoat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Script_talktoGoat).BeginInit();
            SuspendLayout();
            // 
            // Button_ContinueAlone
            // 
            Button_ContinueAlone.BackColor = Color.Transparent;
            Button_ContinueAlone.BackgroundColor = Color.Transparent;
            Button_ContinueAlone.BorderColor = Color.PaleVioletRed;
            Button_ContinueAlone.BorderRadius = 40;
            Button_ContinueAlone.BorderSize = 0;
            Button_ContinueAlone.FlatAppearance.BorderSize = 0;
            Button_ContinueAlone.FlatStyle = FlatStyle.Flat;
            Button_ContinueAlone.Font = new Font("Segoe UI", 19F);
            Button_ContinueAlone.ForeColor = Color.White;
            Button_ContinueAlone.Location = new Point(1391, 411);
            Button_ContinueAlone.Name = "Button_ContinueAlone";
            Button_ContinueAlone.Size = new Size(315, 78);
            Button_ContinueAlone.TabIndex = 0;
            Button_ContinueAlone.Text = "Continuer seul";
            Button_ContinueAlone.TextColor = Color.White;
            Button_ContinueAlone.UseVisualStyleBackColor = false;
            // 
            // Button_FollowTheGoat_TalkToGoat
            // 
            Button_FollowTheGoat_TalkToGoat.BackColor = Color.Transparent;
            Button_FollowTheGoat_TalkToGoat.BackgroundColor = Color.Transparent;
            Button_FollowTheGoat_TalkToGoat.BorderColor = Color.PaleVioletRed;
            Button_FollowTheGoat_TalkToGoat.BorderRadius = 40;
            Button_FollowTheGoat_TalkToGoat.BorderSize = 0;
            Button_FollowTheGoat_TalkToGoat.FlatAppearance.BorderSize = 0;
            Button_FollowTheGoat_TalkToGoat.FlatStyle = FlatStyle.Flat;
            Button_FollowTheGoat_TalkToGoat.Font = new Font("Segoe UI", 19F);
            Button_FollowTheGoat_TalkToGoat.ForeColor = Color.White;
            Button_FollowTheGoat_TalkToGoat.Location = new Point(1391, 284);
            Button_FollowTheGoat_TalkToGoat.Name = "Button_FollowTheGoat_TalkToGoat";
            Button_FollowTheGoat_TalkToGoat.Size = new Size(315, 78);
            Button_FollowTheGoat_TalkToGoat.TabIndex = 1;
            Button_FollowTheGoat_TalkToGoat.Text = "Suivre la chèvre";
            Button_FollowTheGoat_TalkToGoat.TextColor = Color.White;
            Button_FollowTheGoat_TalkToGoat.UseVisualStyleBackColor = false;
            // 
            // Script_talktoGoat
            // 
            Script_talktoGoat.Image = (Image)resources.GetObject("Script_talktoGoat.Image");
            Script_talktoGoat.Location = new Point(560, 17);
            Script_talktoGoat.Name = "Script_talktoGoat";
            Script_talktoGoat.Size = new Size(877, 233);
            Script_talktoGoat.SizeMode = PictureBoxSizeMode.StretchImage;
            Script_talktoGoat.TabIndex = 4;
            Script_talktoGoat.TabStop = false;
            // 
            // Frame_TalkToGoatInDungeon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Script_talktoGoat);
            Controls.Add(Button_FollowTheGoat_TalkToGoat);
            Controls.Add(Button_ContinueAlone);
            Name = "Frame_TalkToGoatInDungeon";
            Size = new Size(1910, 1100);
            ((System.ComponentModel.ISupportInitialize)Script_talktoGoat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_ContinueAlone;
        public WindowsFormsApp1.RJButton Button_FollowTheGoat_TalkToGoat;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.Timer Timer_FriskTalkToGoat;
        public PictureBox Script_talktoGoat;
    }
}
