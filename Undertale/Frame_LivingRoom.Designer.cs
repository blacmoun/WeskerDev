namespace Undertale
{
    partial class Frame_LivingRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_LivingRoom));
            Button_ToKitchenFromLivingRoom = new WindowsFormsApp1.RJButton();
            Button_backToHall = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_ToKitchenFromLivingRoom
            // 
            Button_ToKitchenFromLivingRoom.BackColor = Color.Transparent;
            Button_ToKitchenFromLivingRoom.BackgroundColor = Color.Transparent;
            Button_ToKitchenFromLivingRoom.BorderColor = Color.PaleVioletRed;
            Button_ToKitchenFromLivingRoom.BorderRadius = 40;
            Button_ToKitchenFromLivingRoom.BorderSize = 0;
            Button_ToKitchenFromLivingRoom.FlatAppearance.BorderSize = 0;
            Button_ToKitchenFromLivingRoom.FlatStyle = FlatStyle.Flat;
            Button_ToKitchenFromLivingRoom.Font = new Font("Segoe UI", 19F);
            Button_ToKitchenFromLivingRoom.ForeColor = Color.White;
            Button_ToKitchenFromLivingRoom.Location = new Point(1249, 372);
            Button_ToKitchenFromLivingRoom.Name = "Button_ToKitchenFromLivingRoom";
            Button_ToKitchenFromLivingRoom.Size = new Size(315, 78);
            Button_ToKitchenFromLivingRoom.TabIndex = 3;
            Button_ToKitchenFromLivingRoom.Text = "Aller dans la cuisine";
            Button_ToKitchenFromLivingRoom.TextColor = Color.White;
            Button_ToKitchenFromLivingRoom.UseVisualStyleBackColor = false;
            // 
            // Button_backToHall
            // 
            Button_backToHall.BackColor = Color.Transparent;
            Button_backToHall.BackgroundColor = Color.Transparent;
            Button_backToHall.BorderColor = Color.PaleVioletRed;
            Button_backToHall.BorderRadius = 40;
            Button_backToHall.BorderSize = 0;
            Button_backToHall.FlatAppearance.BorderSize = 0;
            Button_backToHall.FlatStyle = FlatStyle.Flat;
            Button_backToHall.Font = new Font("Segoe UI", 19F);
            Button_backToHall.ForeColor = Color.White;
            Button_backToHall.Location = new Point(142, 372);
            Button_backToHall.Name = "Button_backToHall";
            Button_backToHall.Size = new Size(315, 78);
            Button_backToHall.TabIndex = 4;
            Button_backToHall.Text = "Revenir au Hall";
            Button_backToHall.TextColor = Color.White;
            Button_backToHall.UseVisualStyleBackColor = false;
            // 
            // Frame_LivingRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_backToHall);
            Controls.Add(Button_ToKitchenFromLivingRoom);
            Name = "Frame_LivingRoom";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_ToKitchenFromLivingRoom;
        public WindowsFormsApp1.RJButton Button_backToHall;
    }
}
