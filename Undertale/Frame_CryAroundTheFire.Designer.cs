namespace Undertale
{
    partial class Frame_cryAroundTheFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_cryAroundTheFire));
            Button_ReturnAdventure = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_ReturnAdventure
            // 
            Button_ReturnAdventure.BackColor = Color.Transparent;
            Button_ReturnAdventure.BackgroundColor = Color.Transparent;
            Button_ReturnAdventure.BorderColor = Color.PaleVioletRed;
            Button_ReturnAdventure.BorderRadius = 40;
            Button_ReturnAdventure.BorderSize = 0;
            Button_ReturnAdventure.FlatAppearance.BorderSize = 0;
            Button_ReturnAdventure.FlatStyle = FlatStyle.Flat;
            Button_ReturnAdventure.Font = new Font("Segoe UI", 19F);
            Button_ReturnAdventure.ForeColor = Color.White;
            Button_ReturnAdventure.Location = new Point(1367, 477);
            Button_ReturnAdventure.Name = "Button_ReturnAdventure";
            Button_ReturnAdventure.Size = new Size(315, 82);
            Button_ReturnAdventure.TabIndex = 2;
            Button_ReturnAdventure.Text = "Retourner à l'aventure";
            Button_ReturnAdventure.TextColor = Color.White;
            Button_ReturnAdventure.UseVisualStyleBackColor = false;
            // 
            // Frame_cryAroundTheFire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_ReturnAdventure);
            Name = "Frame_cryAroundTheFire";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_ReturnAdventure;
    }
}
