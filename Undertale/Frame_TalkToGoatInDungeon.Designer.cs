﻿namespace Undertale
{
    partial class Frame_TalkToGoatInDungeon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_TalkToGoatInDungeon));
            Button_nextTalkToGoat = new WindowsFormsApp1.RJButton();
            SuspendLayout();
            // 
            // Button_nextTalkToGoat
            // 
            Button_nextTalkToGoat.BackColor = Color.Transparent;
            Button_nextTalkToGoat.BackgroundColor = Color.Transparent;
            Button_nextTalkToGoat.BorderColor = Color.PaleVioletRed;
            Button_nextTalkToGoat.BorderRadius = 40;
            Button_nextTalkToGoat.BorderSize = 0;
            Button_nextTalkToGoat.FlatAppearance.BorderSize = 0;
            Button_nextTalkToGoat.FlatStyle = FlatStyle.Flat;
            Button_nextTalkToGoat.Font = new Font("Segoe UI", 19F);
            Button_nextTalkToGoat.ForeColor = Color.White;
            Button_nextTalkToGoat.Location = new Point(1502, 869);
            Button_nextTalkToGoat.Name = "Button_nextTalkToGoat";
            Button_nextTalkToGoat.Size = new Size(315, 78);
            Button_nextTalkToGoat.TabIndex = 0;
            Button_nextTalkToGoat.Text = "Next";
            Button_nextTalkToGoat.TextColor = Color.White;
            Button_nextTalkToGoat.UseVisualStyleBackColor = false;
            Button_nextTalkToGoat.Click += Button_nextTalkToGoat_Click;
            // 
            // Frame_TalkToGoatInDungeon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Button_nextTalkToGoat);
            Name = "Frame_TalkToGoatInDungeon";
            Size = new Size(1910, 1100);
            ResumeLayout(false);
        }

        #endregion

        public WindowsFormsApp1.RJButton Button_nextTalkToGoat;
    }
}
