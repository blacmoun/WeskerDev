namespace Undertale
{
    partial class Undertale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Undertale));
            PlayButton = new Button();
            QuitButton = new Button();
            SettButton = new Button();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.None;
            PlayButton.BackColor = SystemColors.ActiveCaptionText;
            PlayButton.BackgroundImageLayout = ImageLayout.Stretch;
            PlayButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayButton.ForeColor = SystemColors.ButtonFace;
            PlayButton.Location = new Point(760, 367);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(369, 81);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.None;
            QuitButton.BackColor = SystemColors.ActiveCaptionText;
            QuitButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuitButton.ForeColor = SystemColors.ButtonFace;
            QuitButton.Location = new Point(760, 546);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(369, 81);
            QuitButton.TabIndex = 1;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // SettButton
            // 
            SettButton.Anchor = AnchorStyles.None;
            SettButton.BackColor = SystemColors.ActiveCaptionText;
            SettButton.BackgroundImageLayout = ImageLayout.Stretch;
            SettButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettButton.ForeColor = SystemColors.ButtonFace;
            SettButton.Location = new Point(760, 458);
            SettButton.Name = "SettButton";
            SettButton.Size = new Size(369, 81);
            SettButton.TabIndex = 2;
            SettButton.Text = "Settings";
            SettButton.UseVisualStyleBackColor = false;
            SettButton.Click += SettButton_Click;
            // 
            // Undertale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1137, 639);
            Controls.Add(SettButton);
            Controls.Add(QuitButton);
            Controls.Add(PlayButton);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Name = "Undertale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoryLife";
            ResumeLayout(false);
        }

        #endregion

        private Button PlayButton;
        private Button QuitButton;
        private Button SettButton;
    }
}