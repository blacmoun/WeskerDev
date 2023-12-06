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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            userlbl = new Label();
            UserTxt = new TextBox();
            LoginButton = new Button();
            Settinglbl = new Label();
            SuspendLayout();
            // 
            // userlbl
            // 
            userlbl.AutoSize = true;
            userlbl.Location = new Point(12, 104);
            userlbl.Name = "userlbl";
            userlbl.Size = new Size(62, 15);
            userlbl.TabIndex = 0;
            userlbl.Text = "UserName";
            // 
            // UserTxt
            // 
            UserTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserTxt.Location = new Point(12, 91);
            UserTxt.Multiline = true;
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(269, 47);
            UserTxt.TabIndex = 2;
            UserTxt.TextChanged += UserTxt_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginButton.BackColor = SystemColors.ActiveBorder;
            LoginButton.BackgroundImage = (Image)resources.GetObject("LoginButton.BackgroundImage");
            LoginButton.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ButtonFace;
            LoginButton.Location = new Point(12, 144);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(269, 118);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click_1;
            // 
            // Settinglbl
            // 
            Settinglbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settinglbl.ForeColor = SystemColors.ActiveCaption;
            Settinglbl.Location = new Point(12, 9);
            Settinglbl.Name = "Settinglbl";
            Settinglbl.Size = new Size(269, 79);
            Settinglbl.TabIndex = 6;
            Settinglbl.Text = "Enter your Username";
            Settinglbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(293, 274);
            Controls.Add(Settinglbl);
            Controls.Add(LoginButton);
            Controls.Add(UserTxt);
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
        private Button LoginButton;
        private Label Settinglbl;
    }
}