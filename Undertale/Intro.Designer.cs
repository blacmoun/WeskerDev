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
            pictureBox1 = new PictureBox();
            button_skip = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1910, 1100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            button_skip.Text = "Passer";
            button_skip.UseVisualStyleBackColor = false;
            button_skip.Click += button1_Click;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button_skip);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Intro";
            Size = new Size(1910, 1100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        public Button button_skip;
    }
}
