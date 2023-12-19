namespace Undertale
{
    partial class Frame_Bathroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_Bathroom));
            Button_backToLivingRoom = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_backToLivingRoom
            // 
            Button_backToLivingRoom.BackColor = Color.Transparent;
            Button_backToLivingRoom.BackgroundColor = Color.Transparent;
            Button_backToLivingRoom.BorderColor = Color.PaleVioletRed;
            Button_backToLivingRoom.BorderRadius = 40;
            Button_backToLivingRoom.BorderSize = 0;
            Button_backToLivingRoom.FlatAppearance.BorderSize = 0;
            Button_backToLivingRoom.FlatStyle = FlatStyle.Flat;
            Button_backToLivingRoom.Font = new Font("Segoe UI", 19F);
            Button_backToLivingRoom.ForeColor = Color.White;
            Button_backToLivingRoom.Location = new Point(1166, 525);
            Button_backToLivingRoom.Name = "Button_backToLivingRoom";
            Button_backToLivingRoom.Size = new Size(315, 78);
            Button_backToLivingRoom.TabIndex = 6;
            Button_backToLivingRoom.Text = "Revenir au Hall";
            Button_backToLivingRoom.TextColor = Color.White;
            Button_backToLivingRoom.UseVisualStyleBackColor = false;
            // 
            // Frame_Bathroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_backToLivingRoom);
            Name = "Frame_Bathroom";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_backToLivingRoom;
    }
}
