namespace Undertale
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            rjButton1 = new WindowsFormsApp1.RJButton();
            rjButton2 = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Transparent;
            rjButton1.BackgroundColor = Color.Transparent;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 40;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 19F);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(877, 314);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(315, 78);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Entrer dans le donjon";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Transparent;
            rjButton2.BackgroundColor = Color.Transparent;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 40;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 19F);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(53, 536);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(315, 78);
            rjButton2.TabIndex = 1;
            rjButton2.Text = "Sortir";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Name = "UserControl1";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        private WindowsFormsApp1.RJButton rjButton1;
        private WindowsFormsApp1.RJButton rjButton2;
    }
}
