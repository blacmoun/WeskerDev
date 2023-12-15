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
            ButtonGoToDoor = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // ButtonGoToDoor
            // 
            ButtonGoToDoor.BackColor = Color.Transparent;
            ButtonGoToDoor.BackgroundColor = Color.Transparent;
            ButtonGoToDoor.BorderColor = Color.PaleVioletRed;
            ButtonGoToDoor.BorderRadius = 40;
            ButtonGoToDoor.BorderSize = 0;
            ButtonGoToDoor.FlatAppearance.BorderSize = 0;
            ButtonGoToDoor.FlatStyle = FlatStyle.Flat;
            ButtonGoToDoor.Font = new Font("Segoe UI", 19F);
            ButtonGoToDoor.ForeColor = Color.White;
            ButtonGoToDoor.Location = new Point(1539, 913);
            ButtonGoToDoor.Name = "ButtonGoToDoor";
            ButtonGoToDoor.Size = new Size(315, 78);
            ButtonGoToDoor.TabIndex = 1;
            ButtonGoToDoor.Text = "Suivant";
            ButtonGoToDoor.TextColor = Color.White;
            ButtonGoToDoor.UseVisualStyleBackColor = false;
            ButtonGoToDoor.Click += ButtonEnterDungeon_Click;
            // 
            // Frame_inFrontOfHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(ButtonGoToDoor);
            Name = "Frame_inFrontOfHouse";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton ButtonGoToDoor;
    }
}
