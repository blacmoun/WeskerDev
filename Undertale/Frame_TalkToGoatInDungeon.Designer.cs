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
            Button_ContinueTalkToGoat = new WindowsFormsApp1.RJButton();
            Button_FollowTheGoat_TalkToGoat = new WindowsFormsApp1.RJButton();
            Script_FriskTalkToGoat_STATIC = new PictureBox();
            Script_talktoGoat = new PictureBox();
            Timer_FriskTalkToGoat = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Script_FriskTalkToGoat_STATIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Script_talktoGoat).BeginInit();
            SuspendLayout();
            // 
            // Button_ContinueTalkToGoat
            // 
            Button_ContinueTalkToGoat.BackColor = Color.Transparent;
            Button_ContinueTalkToGoat.BackgroundColor = Color.Transparent;
            Button_ContinueTalkToGoat.BorderColor = Color.PaleVioletRed;
            Button_ContinueTalkToGoat.BorderRadius = 40;
            Button_ContinueTalkToGoat.BorderSize = 0;
            Button_ContinueTalkToGoat.FlatAppearance.BorderSize = 0;
            Button_ContinueTalkToGoat.FlatStyle = FlatStyle.Flat;
            Button_ContinueTalkToGoat.Font = new Font("Segoe UI", 19F);
            Button_ContinueTalkToGoat.ForeColor = Color.White;
            Button_ContinueTalkToGoat.Location = new Point(1391, 411);
            Button_ContinueTalkToGoat.Name = "Button_ContinueTalkToGoat";
            Button_ContinueTalkToGoat.Size = new Size(315, 78);
            Button_ContinueTalkToGoat.TabIndex = 0;
            Button_ContinueTalkToGoat.Text = "Continuer seul";
            Button_ContinueTalkToGoat.TextColor = Color.White;
            Button_ContinueTalkToGoat.UseVisualStyleBackColor = false;
            Button_ContinueTalkToGoat.Click += Button_ContinueTalkToGoat_Click;
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
            Button_FollowTheGoat_TalkToGoat.Click += Button_FollowTheGoat_TalkToGoat_Click_1;
            // 
            // Script_FriskTalkToGoat_STATIC
            // 
            Script_FriskTalkToGoat_STATIC.BackgroundImageLayout = ImageLayout.Stretch;
            Script_FriskTalkToGoat_STATIC.Image = (Image)resources.GetObject("Script_FriskTalkToGoat_STATIC.Image");
            Script_FriskTalkToGoat_STATIC.Location = new Point(503, 24);
            Script_FriskTalkToGoat_STATIC.Name = "Script_FriskTalkToGoat_STATIC";
            Script_FriskTalkToGoat_STATIC.Size = new Size(877, 233);
            Script_FriskTalkToGoat_STATIC.SizeMode = PictureBoxSizeMode.StretchImage;
            Script_FriskTalkToGoat_STATIC.TabIndex = 3;
            Script_FriskTalkToGoat_STATIC.TabStop = false;
            // 
            // Script_talktoGoat
            // 
            Script_talktoGoat.BackgroundImageLayout = ImageLayout.Stretch;
            Script_talktoGoat.Image = (Image)resources.GetObject("Script_talktoGoat.Image");
            Script_talktoGoat.Location = new Point(503, 24);
            Script_talktoGoat.Name = "Script_talktoGoat";
            Script_talktoGoat.Size = new Size(877, 233);
            Script_talktoGoat.SizeMode = PictureBoxSizeMode.StretchImage;
            Script_talktoGoat.TabIndex = 4;
            Script_talktoGoat.TabStop = false;
            // 
            // Timer_FriskTalkToGoat
            // 
            Timer_FriskTalkToGoat.Tick += Timer_FriskTalkToGoat_Tick;
            // 
            // Frame_TalkToGoatInDungeon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Script_talktoGoat);
            Controls.Add(Button_FollowTheGoat_TalkToGoat);
            Controls.Add(Button_ContinueTalkToGoat);
            Controls.Add(Script_FriskTalkToGoat_STATIC);
            Name = "Frame_TalkToGoatInDungeon";
            Size = new Size(1910, 1100);
            ((System.ComponentModel.ISupportInitialize)Script_FriskTalkToGoat_STATIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)Script_talktoGoat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_ContinueTalkToGoat;
        public WindowsFormsApp1.RJButton Button_FollowTheGoat_TalkToGoat;
        public PictureBox Script_FriskTalkToGoat_STATIC;
        public PictureBox Script_talktoGoat;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.Timer Timer_FriskTalkToGoat;
    }
}
