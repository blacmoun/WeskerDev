namespace Undertale
{
    partial class Intro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            button_skip = new Button();
            Background_Intro = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Background_Intro).BeginInit();
            SuspendLayout();
            // 
            // button_skip
            // 
            button_skip.BackColor = SystemColors.ActiveCaptionText;
            button_skip.Font = new Font("Forte", 27.75F);
            button_skip.ForeColor = SystemColors.ButtonFace;
            button_skip.Location = new Point(1524, 918);
            button_skip.Name = "button_skip";
            button_skip.Size = new Size(224, 85);
            button_skip.TabIndex = 0;
            button_skip.Text = "Commencer";
            button_skip.UseVisualStyleBackColor = false;
            button_skip.Click += button_skip_Click;
            // 
            // Background_Intro
            // 
            Background_Intro.BackColor = SystemColors.ActiveCaptionText;
            Background_Intro.BackgroundImageLayout = ImageLayout.Stretch;
            Background_Intro.Image = (Image)resources.GetObject("Background_Intro.Image");
            Background_Intro.Location = new Point(799, 282);
            Background_Intro.Name = "Background_Intro";
            Background_Intro.Size = new Size(292, 498);
            Background_Intro.SizeMode = PictureBoxSizeMode.StretchImage;
            Background_Intro.TabIndex = 0;
            Background_Intro.TabStop = false;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button_skip);
            Controls.Add(Background_Intro);
            DoubleBuffered = true;
            Name = "Intro";
            Size = new Size(1910, 1100);
            ((System.ComponentModel.ISupportInitialize)Background_Intro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button button_skip;
        public PictureBox Background_Intro;
    }
}
