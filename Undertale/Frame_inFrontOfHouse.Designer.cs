namespace Undertale
{
    partial class Frame_inFrontOfHouse
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_inFrontOfHouse));
            ButtonGoToDoor = new WindowsFormsApp1.RJButton();
            Script_InfrontOfHouse_STATIC = new PictureBox();
            Script_InfrontOfHouse = new PictureBox();
            Timer_InFrontOfHouse = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Script_InfrontOfHouse_STATIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Script_InfrontOfHouse).BeginInit();
            SuspendLayout();
            // 
            // ButtonGoToDoor
            // 
            ButtonGoToDoor.BackColor = Color.Transparent;
            ButtonGoToDoor.BackgroundColor = Color.Transparent;
            ButtonGoToDoor.BorderColor = Color.PaleVioletRed;
            ButtonGoToDoor.BorderRadius = 40;
            ButtonGoToDoor.BorderSize = 0;
            ButtonGoToDoor.FlatAppearance.BorderSize = 0;
            ButtonGoToDoor.FlatStyle = FlatStyle.Flat;
            ButtonGoToDoor.Font = new Font("Segoe UI", 19F);
            ButtonGoToDoor.ForeColor = Color.White;
            ButtonGoToDoor.Location = new Point(1539, 913);
            ButtonGoToDoor.Name = "ButtonGoToDoor";
            ButtonGoToDoor.Size = new Size(315, 78);
            ButtonGoToDoor.TabIndex = 1;
            ButtonGoToDoor.Text = "Suivant";
            ButtonGoToDoor.TextColor = Color.White;
            ButtonGoToDoor.UseVisualStyleBackColor = false;
            ButtonGoToDoor.Click += ButtonEnterDungeon_Click;
            // 
            // Script_InfrontOfHouse_STATIC
            // 
            Script_InfrontOfHouse_STATIC.BackgroundImageLayout = ImageLayout.Stretch;
            Script_InfrontOfHouse_STATIC.Image = (Image)resources.GetObject("Script_InfrontOfHouse_STATIC.Image");
            Script_InfrontOfHouse_STATIC.Location = new Point(603, 43);
            Script_InfrontOfHouse_STATIC.Name = "Script_InfrontOfHouse_STATIC";
            Script_InfrontOfHouse_STATIC.Size = new Size(877, 233);
            Script_InfrontOfHouse_STATIC.SizeMode = PictureBoxSizeMode.StretchImage;
            Script_InfrontOfHouse_STATIC.TabIndex = 5;
            Script_InfrontOfHouse_STATIC.TabStop = false;
            // 
            // Script_InfrontOfHouse
            // 
            Script_InfrontOfHouse.BackgroundImageLayout = ImageLayout.Stretch;
            Script_InfrontOfHouse.Image = (Image)resources.GetObject("Script_InfrontOfHouse.Image");
            Script_InfrontOfHouse.Location = new Point(603, 43);
            Script_InfrontOfHouse.Name = "Script_InfrontOfHouse";
            Script_InfrontOfHouse.Size = new Size(877, 233);
            Script_InfrontOfHouse.SizeMode = PictureBoxSizeMode.StretchImage;
            Script_InfrontOfHouse.TabIndex = 6;
            Script_InfrontOfHouse.TabStop = false;
            // 
            // Frame_inFrontOfHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Script_InfrontOfHouse);
            Controls.Add(ButtonGoToDoor);
            Controls.Add(Script_InfrontOfHouse_STATIC);
            Name = "Frame_inFrontOfHouse";
            Size = new Size(1910, 1100);
            ((System.ComponentModel.ISupportInitialize)Script_InfrontOfHouse_STATIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)Script_InfrontOfHouse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton ButtonGoToDoor;
        public PictureBox Script_InfrontOfHouse_STATIC;
        public PictureBox Script_InfrontOfHouse;
        public System.Windows.Forms.Timer Timer_InFrontOfHouse;
    }
}
