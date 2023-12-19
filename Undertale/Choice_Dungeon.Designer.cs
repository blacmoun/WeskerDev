namespace Undertale
{
    partial class Choice_Dungeon
    {

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_Dungeon));
            ButtonEnterDungeon = new WindowsFormsApp1.RJButton();
            Button_exit_dungeon = new WindowsFormsApp1.RJButton();
            Script_superEndroitSTATIC = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Script_superEndroitSTATIC).BeginInit();
            SuspendLayout();
            // 
            // ButtonEnterDungeon
            // 
            ButtonEnterDungeon.BackColor = Color.Transparent;
            ButtonEnterDungeon.BackgroundColor = Color.Transparent;
            ButtonEnterDungeon.BorderColor = Color.PaleVioletRed;
            ButtonEnterDungeon.BorderRadius = 40;
            ButtonEnterDungeon.BorderSize = 0;
            ButtonEnterDungeon.FlatAppearance.BorderSize = 0;
            ButtonEnterDungeon.FlatStyle = FlatStyle.Flat;
            ButtonEnterDungeon.Font = new Font("Segoe UI", 19F);
            ButtonEnterDungeon.ForeColor = Color.White;
            ButtonEnterDungeon.Location = new Point(877, 314);
            ButtonEnterDungeon.Name = "ButtonEnterDungeon";
            ButtonEnterDungeon.Size = new Size(315, 78);
            ButtonEnterDungeon.TabIndex = 0;
            ButtonEnterDungeon.Text = "Entrer dans le donjon";
            ButtonEnterDungeon.TextColor = Color.White;
            ButtonEnterDungeon.UseVisualStyleBackColor = false;
            // 
            // Button_exit_dungeon
            // 
            Button_exit_dungeon.BackColor = Color.Transparent;
            Button_exit_dungeon.BackgroundColor = Color.Transparent;
            Button_exit_dungeon.BorderColor = Color.PaleVioletRed;
            Button_exit_dungeon.BorderRadius = 40;
            Button_exit_dungeon.BorderSize = 0;
            Button_exit_dungeon.FlatAppearance.BorderSize = 0;
            Button_exit_dungeon.FlatStyle = FlatStyle.Flat;
            Button_exit_dungeon.Font = new Font("Segoe UI", 19F);
            Button_exit_dungeon.ForeColor = Color.White;
            Button_exit_dungeon.Location = new Point(53, 536);
            Button_exit_dungeon.Name = "Button_exit_dungeon";
            Button_exit_dungeon.Size = new Size(315, 78);
            Button_exit_dungeon.TabIndex = 1;
            Button_exit_dungeon.Text = "Sortir";
            Button_exit_dungeon.TextColor = Color.White;
            Button_exit_dungeon.UseVisualStyleBackColor = false;
            // 
            // 

            // Script_superEndroitSTATIC
            Script_superEndroitSTATIC.BackgroundImageLayout = ImageLayout.Stretch;
            Script_superEndroitSTATIC.Image = (Image)resources.GetObject("Script_superEndroitSTATIC.Image");
            Script_superEndroitSTATIC.Size = new Size(886, 233);
            Script_superEndroitSTATIC.SizeMode = PictureBoxSizeMode.StretchImage;
            Script_superEndroitSTATIC.TabIndex = 3;
            Script_superEndroitSTATIC.TabStop = false;
            Script_superEndroitSTATIC.WaitOnLoad = true;
            // 
            // 
            // Choice_Dungeon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_exit_dungeon);
            Controls.Add(ButtonEnterDungeon);
            Controls.Add(Script_superEndroitSTATIC);
            Name = "Choice_Dungeon";
            Size = new Size(1910, 1100);
            ((System.ComponentModel.ISupportInitialize)Script_superEndroitSTATIC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton ButtonEnterDungeon;
        public WindowsFormsApp1.RJButton Button_exit_dungeon;
        public PictureBox Script_superEndroitSTATIC;
        private System.ComponentModel.IContainer components;
    }
}
