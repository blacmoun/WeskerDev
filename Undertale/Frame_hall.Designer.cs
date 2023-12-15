namespace Undertale
{
    partial class Frame_hall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_hall));
            Button_livingRoom = new WindowsFormsApp1.RJButton();
            Button_Bathroom = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_livingRoom
            // 
            Button_livingRoom.BackColor = Color.Transparent;
            Button_livingRoom.BackgroundColor = Color.Transparent;
            Button_livingRoom.BorderColor = Color.PaleVioletRed;
            Button_livingRoom.BorderRadius = 40;
            Button_livingRoom.BorderSize = 0;
            Button_livingRoom.FlatAppearance.BorderSize = 0;
            Button_livingRoom.FlatStyle = FlatStyle.Flat;
            Button_livingRoom.Font = new Font("Segoe UI", 19F);
            Button_livingRoom.ForeColor = Color.White;
            Button_livingRoom.Location = new Point(1051, 496);
            Button_livingRoom.Name = "Button_livingRoom";
            Button_livingRoom.Size = new Size(315, 78);
            Button_livingRoom.TabIndex = 2;
            Button_livingRoom.Text = "Aller au salon";
            Button_livingRoom.TextColor = Color.White;
            Button_livingRoom.UseVisualStyleBackColor = false;
            Button_livingRoom.Click += Button_livingRoom_Click;
            // 
            // Button_Bathroom
            // 
            Button_Bathroom.BackColor = Color.Transparent;
            Button_Bathroom.BackgroundColor = Color.Transparent;
            Button_Bathroom.BorderColor = Color.PaleVioletRed;
            Button_Bathroom.BorderRadius = 40;
            Button_Bathroom.BorderSize = 0;
            Button_Bathroom.FlatAppearance.BorderSize = 0;
            Button_Bathroom.FlatStyle = FlatStyle.Flat;
            Button_Bathroom.Font = new Font("Segoe UI", 19F);
            Button_Bathroom.ForeColor = Color.White;
            Button_Bathroom.Location = new Point(43, 496);
            Button_Bathroom.Name = "Button_Bathroom";
            Button_Bathroom.Size = new Size(315, 78);
            Button_Bathroom.TabIndex = 3;
            Button_Bathroom.Text = "Aller dans la salle de bain";
            Button_Bathroom.TextColor = Color.White;
            Button_Bathroom.UseVisualStyleBackColor = false;
            Button_Bathroom.Click += Button_Bathroom_Click;
            // 
            // Frame_hall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_Bathroom);
            Controls.Add(Button_livingRoom);
            Name = "Frame_hall";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_livingRoom;
        public WindowsFormsApp1.RJButton Button_Bathroom;
    }
}
