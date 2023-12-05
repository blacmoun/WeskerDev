namespace Undertale
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userlbl = new Label();
            passlbl = new Label();
            UserTxt = new TextBox();
            PassTxt = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // userlbl
            // 
            userlbl.AutoSize = true;
            userlbl.Location = new Point(37, 32);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(62, 15);
            userlbl.TabIndex = 0;
            userlbl.Text = "UserName";
            // 
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.Location = new Point(37, 101);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(57, 15);
            passlbl.TabIndex = 1;
            passlbl.Text = "Password";
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(105, 29);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(241, 23);
            UserTxt.TabIndex = 2;
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(105, 98);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(241, 23);
            PassTxt.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(105, 174);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(119, 46);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(431, 277);
            Controls.Add(loginButton);
            Controls.Add(PassTxt);
            Controls.Add(UserTxt);
            Controls.Add(passlbl);
            Controls.Add(userlbl);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userlbl;
        private Label passlbl;
        private TextBox UserTxt;
        private TextBox PassTxt;
        private Button loginButton;
    }
}