namespace Undertale
{
    partial class Frame_EntrenceMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_EntrenceMarket));
            Button_GoArroud = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_GoArroud
            // 
            Button_GoArroud.BackColor = Color.Transparent;
            Button_GoArroud.BackgroundColor = Color.Transparent;
            Button_GoArroud.BorderColor = Color.PaleVioletRed;
            Button_GoArroud.BorderRadius = 40;
            Button_GoArroud.BorderSize = 0;
            Button_GoArroud.FlatAppearance.BorderSize = 0;
            Button_GoArroud.FlatStyle = FlatStyle.Flat;
            Button_GoArroud.Font = new Font("Segoe UI", 19F);
            Button_GoArroud.ForeColor = Color.White;
            Button_GoArroud.Location = new Point(692, 678);
            Button_GoArroud.Name = "Button_GoArroud";
            Button_GoArroud.Size = new Size(315, 82);
            Button_GoArroud.TabIndex = 2;
            Button_GoArroud.Text = "Visiter le marché";
            Button_GoArroud.TextColor = Color.White;
            Button_GoArroud.UseVisualStyleBackColor = false;
            Button_GoArroud.Click += Button_GoArroud_Click;
            // 
            // Frame_EntrenceMarket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_GoArroud);
            Name = "Frame_EntrenceMarket";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_GoArroud;
    }
}
