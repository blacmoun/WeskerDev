namespace Undertale
{
    partial class Frame_ToTheEndOfTheWay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_ToTheEndOfTheWay));
            Button_EnterInTheMarket = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_EnterInTheMarket
            // 
            Button_EnterInTheMarket.BackColor = Color.Transparent;
            Button_EnterInTheMarket.BackgroundColor = Color.Transparent;
            Button_EnterInTheMarket.BorderColor = Color.PaleVioletRed;
            Button_EnterInTheMarket.BorderRadius = 40;
            Button_EnterInTheMarket.BorderSize = 0;
            Button_EnterInTheMarket.FlatAppearance.BorderSize = 0;
            Button_EnterInTheMarket.FlatStyle = FlatStyle.Flat;
            Button_EnterInTheMarket.Font = new Font("Segoe UI", 19F);
            Button_EnterInTheMarket.ForeColor = Color.White;
            Button_EnterInTheMarket.Location = new Point(551, 638);
            Button_EnterInTheMarket.Name = "Button_EnterInTheMarket";
            Button_EnterInTheMarket.Size = new Size(315, 82);
            Button_EnterInTheMarket.TabIndex = 2;
            Button_EnterInTheMarket.Text = "Entrer";
            Button_EnterInTheMarket.TextColor = Color.White;
            Button_EnterInTheMarket.UseVisualStyleBackColor = false;
            Button_EnterInTheMarket.Click += Button_EnterInTheMarket_Click;
            // 
            // Frame_ToTheEndOfTheWay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_EnterInTheMarket);
            Name = "Frame_ToTheEndOfTheWay";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_EnterInTheMarket;
    }
}
