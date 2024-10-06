namespace BUS_ORGANIZATION
{
    partial class Form1
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
            ltpasswd = new TextBox();
            ltlogin = new TextBox();
            lllogin = new Label();
            llpasswd = new Label();
            logpanel = new Panel();
            registration = new Button();
            logIn = new Button();
            regpanel = new Panel();
            goback = new Button();
            registeracc = new Button();
            rlpasswdconf = new Label();
            rtpasswdconf = new TextBox();
            rtpasswd = new TextBox();
            rlpasswd = new Label();
            rtlogin = new TextBox();
            rllogin = new Label();
            logpanel.SuspendLayout();
            regpanel.SuspendLayout();
            SuspendLayout();
            // 
            // ltpasswd
            // 
            ltpasswd.Location = new Point(58, 47);
            ltpasswd.Name = "ltpasswd";
            ltpasswd.PasswordChar = '*';
            ltpasswd.Size = new Size(100, 23);
            ltpasswd.TabIndex = 0;
            // 
            // ltlogin
            // 
            ltlogin.Location = new Point(58, 3);
            ltlogin.Name = "ltlogin";
            ltlogin.Size = new Size(100, 23);
            ltlogin.TabIndex = 1;
            // 
            // lllogin
            // 
            lllogin.AutoSize = true;
            lllogin.Location = new Point(11, 6);
            lllogin.Name = "lllogin";
            lllogin.Size = new Size(44, 15);
            lllogin.TabIndex = 2;
            lllogin.Text = "Логин:";
            // 
            // llpasswd
            // 
            llpasswd.AutoSize = true;
            llpasswd.Location = new Point(3, 50);
            llpasswd.Name = "llpasswd";
            llpasswd.Size = new Size(52, 15);
            llpasswd.TabIndex = 3;
            llpasswd.Text = "Пароль:";
            llpasswd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logpanel
            // 
            logpanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logpanel.Controls.Add(registration);
            logpanel.Controls.Add(logIn);
            logpanel.Controls.Add(lllogin);
            logpanel.Controls.Add(ltlogin);
            logpanel.Controls.Add(llpasswd);
            logpanel.Controls.Add(ltpasswd);
            logpanel.Location = new Point(60, 60);
            logpanel.Name = "logpanel";
            logpanel.Size = new Size(166, 169);
            logpanel.TabIndex = 5;
            // 
            // registration
            // 
            registration.Location = new Point(58, 138);
            registration.Name = "registration";
            registration.Size = new Size(100, 23);
            registration.TabIndex = 5;
            registration.Text = "Регистрация";
            registration.UseVisualStyleBackColor = true;
            registration.Click += registration_Click;
            // 
            // logIn
            // 
            logIn.Location = new Point(59, 94);
            logIn.Name = "logIn";
            logIn.Size = new Size(99, 23);
            logIn.TabIndex = 4;
            logIn.Text = "Войти";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += logIn_Click;
            // 
            // regpanel
            // 
            regpanel.Controls.Add(goback);
            regpanel.Controls.Add(registeracc);
            regpanel.Controls.Add(rlpasswdconf);
            regpanel.Controls.Add(rtpasswdconf);
            regpanel.Controls.Add(rtpasswd);
            regpanel.Controls.Add(rlpasswd);
            regpanel.Controls.Add(rtlogin);
            regpanel.Controls.Add(rllogin);
            regpanel.Location = new Point(12, 12);
            regpanel.Name = "regpanel";
            regpanel.Size = new Size(259, 245);
            regpanel.TabIndex = 7;
            regpanel.Visible = false;
            // 
            // goback
            // 
            goback.Location = new Point(91, 202);
            goback.Name = "goback";
            goback.Size = new Size(75, 23);
            goback.TabIndex = 11;
            goback.Text = "Вернуться";
            goback.UseVisualStyleBackColor = true;
            goback.Click += goback_Click;
            // 
            // registeracc
            // 
            registeracc.Location = new Point(67, 158);
            registeracc.Name = "registeracc";
            registeracc.Size = new Size(128, 23);
            registeracc.TabIndex = 10;
            registeracc.Text = "Зарегистрироваться";
            registeracc.UseVisualStyleBackColor = true;
            registeracc.Click += registeracc_Click;
            // 
            // rlpasswdconf
            // 
            rlpasswdconf.AutoSize = true;
            rlpasswdconf.Location = new Point(3, 84);
            rlpasswdconf.Name = "rlpasswdconf";
            rlpasswdconf.Size = new Size(140, 15);
            rlpasswdconf.TabIndex = 9;
            rlpasswdconf.Text = "Подтверждение пароля:";
            rlpasswdconf.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtpasswdconf
            // 
            rtpasswdconf.Location = new Point(156, 81);
            rtpasswdconf.Name = "rtpasswdconf";
            rtpasswdconf.PasswordChar = '*';
            rtpasswdconf.Size = new Size(100, 23);
            rtpasswdconf.TabIndex = 9;
            // 
            // rtpasswd
            // 
            rtpasswd.Location = new Point(156, 48);
            rtpasswd.Name = "rtpasswd";
            rtpasswd.PasswordChar = '*';
            rtpasswd.Size = new Size(100, 23);
            rtpasswd.TabIndex = 8;
            // 
            // rlpasswd
            // 
            rlpasswd.AutoSize = true;
            rlpasswd.Location = new Point(91, 48);
            rlpasswd.Name = "rlpasswd";
            rlpasswd.Size = new Size(52, 15);
            rlpasswd.TabIndex = 8;
            rlpasswd.Text = "Пароль:";
            rlpasswd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtlogin
            // 
            rtlogin.Location = new Point(156, 12);
            rtlogin.Name = "rtlogin";
            rtlogin.Size = new Size(100, 23);
            rtlogin.TabIndex = 8;
            // 
            // rllogin
            // 
            rllogin.AutoSize = true;
            rllogin.Location = new Point(99, 12);
            rllogin.Name = "rllogin";
            rllogin.Size = new Size(44, 15);
            rllogin.TabIndex = 8;
            rllogin.Text = "Логин:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 268);
            Controls.Add(logpanel);
            Controls.Add(regpanel);
            Name = "Form1";
            Text = "Form1";
            logpanel.ResumeLayout(false);
            logpanel.PerformLayout();
            regpanel.ResumeLayout(false);
            regpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox ltpasswd;
        private TextBox ltlogin;
        private Label lllogin;
        private Label llpasswd;
        private Panel logpanel;
        private Button registration;
        private Button logIn;
        private Panel regpanel;
        private Label rlpasswdconf;
        private TextBox rtpasswdconf;
        private TextBox rtpasswd;
        private Label rlpasswd;
        private TextBox rtlogin;
        private Label rllogin;
        private Button registeracc;
        private Button goback;
    }
}
