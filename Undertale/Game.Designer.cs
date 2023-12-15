using System.Drawing;

namespace Undertale
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            EnterName_pictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            EnterName_next_button = new WindowsFormsApp1.RJButton();
            TextBox_EnterName = new TextBox();
            EnterName_pictureBox_Static = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EnterName_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnterName_pictureBox_Static).BeginInit();
            SuspendLayout();
            // 
            // EnterName_pictureBox
            // 
            EnterName_pictureBox.BackgroundImage = (Image)resources.GetObject("EnterName_pictureBox.BackgroundImage");
            EnterName_pictureBox.BackgroundImageLayout = ImageLayout.Center;
            EnterName_pictureBox.Image = (Image)resources.GetObject("EnterName_pictureBox.Image");
            EnterName_pictureBox.Location = new Point(531, 29);
            EnterName_pictureBox.Name = "EnterName_pictureBox";
            EnterName_pictureBox.Size = new Size(872, 234);
            EnterName_pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            EnterName_pictureBox.TabIndex = 0;
            EnterName_pictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // EnterName_next_button
            // 
            EnterName_next_button.BackColor = Color.Transparent;
            EnterName_next_button.BackgroundColor = Color.Transparent;
            EnterName_next_button.BorderColor = Color.PaleVioletRed;
            EnterName_next_button.BorderRadius = 40;
            EnterName_next_button.BorderSize = 0;
            EnterName_next_button.FlatAppearance.BorderSize = 0;
            EnterName_next_button.FlatStyle = FlatStyle.Flat;
            EnterName_next_button.Font = new Font("Segoe UI", 19F);
            EnterName_next_button.ForeColor = Color.White;
            EnterName_next_button.Location = new Point(1139, 688);
            EnterName_next_button.Name = "EnterName_next_button";
            EnterName_next_button.Size = new Size(315, 78);
            EnterName_next_button.TabIndex = 0;
            EnterName_next_button.TabStop = false;
            EnterName_next_button.Text = "Suivant";
            EnterName_next_button.TextColor = Color.White;
            EnterName_next_button.UseVisualStyleBackColor = false;
            // 
            // TextBox_EnterName
            // 
            TextBox_EnterName.BackColor = SystemColors.ActiveCaptionText;
            TextBox_EnterName.Font = new Font("Chiller", 90F);
            TextBox_EnterName.ForeColor = SystemColors.Window;
            TextBox_EnterName.Location = new Point(656, 353);
            TextBox_EnterName.MinimumSize = new Size(90, 25);
            TextBox_EnterName.Name = "TextBox_EnterName";
            TextBox_EnterName.Size = new Size(642, 146);
            TextBox_EnterName.TabIndex = 1;
            TextBox_EnterName.TextAlign = HorizontalAlignment.Center;
            // 
            // EnterName_pictureBox_Static
            // 
            EnterName_pictureBox_Static.BackgroundImage = (Image)resources.GetObject("EnterName_pictureBox_Static.BackgroundImage");
            EnterName_pictureBox_Static.BackgroundImageLayout = ImageLayout.Center;
            EnterName_pictureBox_Static.Image = (Image)resources.GetObject("EnterName_pictureBox_Static.Image");
            EnterName_pictureBox_Static.Location = new Point(531, 29);
            EnterName_pictureBox_Static.Name = "EnterName_pictureBox_Static";
            EnterName_pictureBox_Static.Size = new Size(872, 234);
            EnterName_pictureBox_Static.SizeMode = PictureBoxSizeMode.CenterImage;
            EnterName_pictureBox_Static.TabIndex = 2;
            EnterName_pictureBox_Static.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1894, 1061);
            Controls.Add(EnterName_pictureBox_Static);
            Controls.Add(TextBox_EnterName);
            Controls.Add(EnterName_next_button);
            Controls.Add(EnterName_pictureBox);
            Name = "Game";
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)EnterName_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnterName_pictureBox_Static).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox EnterName_pictureBox;
        private System.Windows.Forms.Timer timer1;
        public WindowsFormsApp1.RJButton EnterName_next_button;
        public TextBox TextBox_EnterName;
        public PictureBox EnterName_pictureBox_Static;
    }
}