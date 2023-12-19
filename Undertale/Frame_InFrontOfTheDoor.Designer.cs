namespace Undertale
{
    partial class Frame_InFrontOfTheDoor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_InFrontOfTheDoor));
            ButtonEnter_InFrontOfTheDoor = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // ButtonEnter_InFrontOfTheDoor
            // 
            ButtonEnter_InFrontOfTheDoor.BackColor = Color.Transparent;
            ButtonEnter_InFrontOfTheDoor.BackgroundColor = Color.Transparent;
            ButtonEnter_InFrontOfTheDoor.BorderColor = Color.PaleVioletRed;
            ButtonEnter_InFrontOfTheDoor.BorderRadius = 40;
            ButtonEnter_InFrontOfTheDoor.BorderSize = 0;
            ButtonEnter_InFrontOfTheDoor.FlatAppearance.BorderSize = 0;
            ButtonEnter_InFrontOfTheDoor.FlatStyle = FlatStyle.Flat;
            ButtonEnter_InFrontOfTheDoor.Font = new Font("Segoe UI", 19F);
            ButtonEnter_InFrontOfTheDoor.ForeColor = Color.White;
            ButtonEnter_InFrontOfTheDoor.Location = new Point(722, 545);
            ButtonEnter_InFrontOfTheDoor.Name = "ButtonEnter_InFrontOfTheDoor";
            ButtonEnter_InFrontOfTheDoor.Size = new Size(315, 78);
            ButtonEnter_InFrontOfTheDoor.TabIndex = 2;
            ButtonEnter_InFrontOfTheDoor.Text = "Entrer";
            ButtonEnter_InFrontOfTheDoor.TextColor = Color.White;
            ButtonEnter_InFrontOfTheDoor.UseVisualStyleBackColor = false;
            // 
            // Frame_InFrontOfTheDoor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(ButtonEnter_InFrontOfTheDoor);
            Name = "Frame_InFrontOfTheDoor";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton ButtonEnter_InFrontOfTheDoor;
    }
}
