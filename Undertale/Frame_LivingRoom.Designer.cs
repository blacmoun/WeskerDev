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
            // Frame_LivingRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_ToKitchenFromLivingRoom);
            Name = "Frame_LivingRoom";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_ToKitchenFromLivingRoom;
    }
}
