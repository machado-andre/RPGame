namespace RPGame
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            linkLabelStartGame = new LinkLabel();
            labelSubtitles = new Label();
            buttonNext = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 61);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(15, 93);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(78, 58);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(100, 23);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(78, 90);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(65, 143);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabelStartGame
            // 
            linkLabelStartGame.ActiveLinkColor = SystemColors.ActiveCaptionText;
            linkLabelStartGame.AutoSize = true;
            linkLabelStartGame.LinkColor = SystemColors.ActiveCaptionText;
            linkLabelStartGame.Location = new Point(410, 259);
            linkLabelStartGame.Name = "linkLabelStartGame";
            linkLabelStartGame.Size = new Size(65, 15);
            linkLabelStartGame.TabIndex = 6;
            linkLabelStartGame.TabStop = true;
            linkLabelStartGame.Text = "Start Game";
            linkLabelStartGame.VisitedLinkColor = SystemColors.ActiveCaptionText;
            linkLabelStartGame.LinkClicked += linkLabelStartGame_LinkClicked;
            // 
            // labelSubtitles
            // 
            labelSubtitles.AutoSize = true;
            labelSubtitles.BackColor = Color.Transparent;
            labelSubtitles.ForeColor = SystemColors.Control;
            labelSubtitles.Location = new Point(15, 488);
            labelSubtitles.Name = "labelSubtitles";
            labelSubtitles.Size = new Size(0, 15);
            labelSubtitles.TabIndex = 7;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(702, 480);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 8;
            buttonNext.Text = "next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 535);
            Controls.Add(buttonNext);
            Controls.Add(labelSubtitles);
            Controls.Add(linkLabelStartGame);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private LinkLabel linkLabelStartGame;
        private Label labelSubtitles;
        private Button buttonNext;
    }
}
