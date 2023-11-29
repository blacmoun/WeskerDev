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
            pictureBoxMenu = new PictureBox();
            pictureBoxFlowerL = new PictureBox();
            pictureBoxFlowerR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlowerL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlowerR).BeginInit();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.None;
            PlayButton.BackColor = SystemColors.ActiveBorder;
            PlayButton.BackgroundImage = (Image)resources.GetObject("PlayButton.BackgroundImage");
            PlayButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayButton.ForeColor = SystemColors.ButtonFace;
            PlayButton.Location = new Point(562, 134);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(154, 78);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.None;
            QuitButton.BackColor = SystemColors.ActiveBorder;
            QuitButton.BackgroundImage = (Image)resources.GetObject("QuitButton.BackgroundImage");
            QuitButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuitButton.ForeColor = SystemColors.ButtonFace;
            QuitButton.Location = new Point(136, 134);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(154, 78);
            QuitButton.TabIndex = 1;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // SettButton
            // 
            SettButton.Anchor = AnchorStyles.None;
            SettButton.BackColor = SystemColors.ActiveBorder;
            SettButton.BackgroundImage = (Image)resources.GetObject("SettButton.BackgroundImage");
            SettButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettButton.ForeColor = SystemColors.ButtonFace;
            SettButton.Location = new Point(345, 14);
            SettButton.Name = "SettButton";
            SettButton.Size = new Size(154, 78);
            SettButton.TabIndex = 2;
            SettButton.Text = "Settings";
            SettButton.UseVisualStyleBackColor = true;
            SettButton.Click += SettButton_Click;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Anchor = AnchorStyles.Bottom;
            pictureBoxMenu.Image = (Image)resources.GetObject("pictureBoxMenu.Image");
            pictureBoxMenu.Location = new Point(296, 98);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(260, 305);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMenu.TabIndex = 3;
            pictureBoxMenu.TabStop = false;
            // 
            // pictureBoxFlowerL
            // 
            pictureBoxFlowerL.Anchor = AnchorStyles.Bottom;
            pictureBoxFlowerL.Image = (Image)resources.GetObject("pictureBoxFlowerL.Image");
            pictureBoxFlowerL.Location = new Point(-3, 237);
            pictureBoxFlowerL.Name = "pictureBoxFlowerL";
            pictureBoxFlowerL.Size = new Size(293, 166);
            pictureBoxFlowerL.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlowerL.TabIndex = 4;
            pictureBoxFlowerL.TabStop = false;
            // 
            // pictureBoxFlowerR
            // 
            pictureBoxFlowerR.Anchor = AnchorStyles.Bottom;
            pictureBoxFlowerR.Image = (Image)resources.GetObject("pictureBoxFlowerR.Image");
            pictureBoxFlowerR.Location = new Point(562, 237);
            pictureBoxFlowerR.Name = "pictureBoxFlowerR";
            pictureBoxFlowerR.Size = new Size(293, 166);
            pictureBoxFlowerR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlowerR.TabIndex = 5;
            pictureBoxFlowerR.TabStop = false;
            // 
            // Undertale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(852, 366);
            Controls.Add(pictureBoxFlowerR);
            Controls.Add(pictureBoxFlowerL);
            Controls.Add(pictureBoxMenu);
            Controls.Add(SettButton);
            Controls.Add(QuitButton);
            Controls.Add(PlayButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Undertale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoryLife";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlowerL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlowerR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PlayButton;
        private Button QuitButton;
        private Button SettButton;
        private PictureBox pictureBoxMenu;
        private PictureBox pictureBoxFlowerL;
        private PictureBox pictureBoxFlowerR;
        private PictureBox pictureBoxGrass;
    }
}