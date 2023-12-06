namespace Undertale
{
    partial class Choice_Dungeon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_Dungeon));
            rjButton1 = new WindowsFormsApp1.RJButton();
            Button_exit_dungeon = new WindowsFormsApp1.RJButton();
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
            // Choice_Dungeon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_exit_dungeon);
            Controls.Add(rjButton1);
            Name = "Choice_Dungeon";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        private WindowsFormsApp1.RJButton rjButton1;
        private WindowsFormsApp1.RJButton Button_exit_dungeon;
    }
}
