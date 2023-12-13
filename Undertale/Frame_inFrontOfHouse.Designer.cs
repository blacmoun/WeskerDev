namespace Undertale
{
    partial class Frame_inFrontOfHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_inFrontOfHouse));
            ButtonEnterDungeon = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // ButtonEnterDungeon
            // 
            ButtonEnterDungeon.BackColor = Color.Transparent;
            ButtonEnterDungeon.BackgroundColor = Color.Transparent;
            ButtonEnterDungeon.BorderColor = Color.PaleVioletRed;
            ButtonEnterDungeon.BorderRadius = 40;
            ButtonEnterDungeon.BorderSize = 0;
            ButtonEnterDungeon.FlatAppearance.BorderSize = 0;
            ButtonEnterDungeon.FlatStyle = FlatStyle.Flat;
            ButtonEnterDungeon.Font = new Font("Segoe UI", 19F);
            ButtonEnterDungeon.ForeColor = Color.White;
            ButtonEnterDungeon.Location = new Point(1554, 997);
            ButtonEnterDungeon.Name = "ButtonEnterDungeon";
            ButtonEnterDungeon.Size = new Size(315, 78);
            ButtonEnterDungeon.TabIndex = 1;
            ButtonEnterDungeon.Text = "Suivant";
            ButtonEnterDungeon.TextColor = Color.White;
            ButtonEnterDungeon.UseVisualStyleBackColor = false;
            ButtonEnterDungeon.Click += ButtonEnterDungeon_Click;
            // 
            // Frame_inFrontOfHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(ButtonEnterDungeon);
            Name = "Frame_inFrontOfHouse";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton ButtonEnterDungeon;
    }
}
