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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Undertale));
            PlayButton = new Button();
            QuitButton = new Button();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.None;
            PlayButton.BackColor = SystemColors.ActiveCaptionText;
            PlayButton.BackgroundImageLayout = ImageLayout.Stretch;
            PlayButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayButton.ForeColor = SystemColors.ButtonFace;
            PlayButton.Location = new Point(760, 390);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(369, 81);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.None;
            QuitButton.BackColor = SystemColors.ActiveCaptionText;
            QuitButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuitButton.ForeColor = SystemColors.ButtonFace;
            QuitButton.Location = new Point(760, 487);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(369, 81);
            QuitButton.TabIndex = 1;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
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
        public Button PlayButton;
        public Button SettButton;
        public Button QuitButton;
    }
}