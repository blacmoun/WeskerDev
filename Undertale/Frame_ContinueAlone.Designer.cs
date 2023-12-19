namespace Undertale
{
    partial class Frame_ContinueAlone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_ContinueAlone));
            Button_CryArroundTheFire = new WindowsFormsApp1.RJButton();
            Button_ContinueToTheEnd = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_CryArroundTheFire
            // 
            Button_CryArroundTheFire.BackColor = Color.Transparent;
            Button_CryArroundTheFire.BackgroundColor = Color.Transparent;
            Button_CryArroundTheFire.BorderColor = Color.PaleVioletRed;
            Button_CryArroundTheFire.BorderRadius = 40;
            Button_CryArroundTheFire.BorderSize = 0;
            Button_CryArroundTheFire.FlatAppearance.BorderSize = 0;
            Button_CryArroundTheFire.FlatStyle = FlatStyle.Flat;
            Button_CryArroundTheFire.Font = new Font("Segoe UI", 19F);
            Button_CryArroundTheFire.ForeColor = Color.White;
            Button_CryArroundTheFire.Location = new Point(1172, 509);
            Button_CryArroundTheFire.Name = "Button_CryArroundTheFire";
            Button_CryArroundTheFire.Size = new Size(315, 82);
            Button_CryArroundTheFire.TabIndex = 1;
            Button_CryArroundTheFire.Text = "Faire un feu et pleurer autour";
            Button_CryArroundTheFire.TextColor = Color.White;
            Button_CryArroundTheFire.UseVisualStyleBackColor = false;
            // 
            // Button_ContinueToTheEnd
            // 
            Button_ContinueToTheEnd.BackColor = Color.Transparent;
            Button_ContinueToTheEnd.BackgroundColor = Color.Transparent;
            Button_ContinueToTheEnd.BorderColor = Color.PaleVioletRed;
            Button_ContinueToTheEnd.BorderRadius = 40;
            Button_ContinueToTheEnd.BorderSize = 0;
            Button_ContinueToTheEnd.FlatAppearance.BorderSize = 0;
            Button_ContinueToTheEnd.FlatStyle = FlatStyle.Flat;
            Button_ContinueToTheEnd.Font = new Font("Segoe UI", 19F);
            Button_ContinueToTheEnd.ForeColor = Color.White;
            Button_ContinueToTheEnd.Location = new Point(1172, 662);
            Button_ContinueToTheEnd.Name = "Button_ContinueToTheEnd";
            Button_ContinueToTheEnd.Size = new Size(315, 82);
            Button_ContinueToTheEnd.TabIndex = 2;
            Button_ContinueToTheEnd.Text = "Continuer jusqu'au bout du chemin";
            Button_ContinueToTheEnd.TextColor = Color.White;
            Button_ContinueToTheEnd.UseVisualStyleBackColor = false;
            // 
            // Frame_ContinueAlone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_ContinueToTheEnd);
            Controls.Add(Button_CryArroundTheFire);
            Name = "Frame_ContinueAlone";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_CryArroundTheFire;
        public WindowsFormsApp1.RJButton Button_ContinueToTheEnd;
    }
}
