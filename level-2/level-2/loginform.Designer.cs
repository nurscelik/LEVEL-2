namespace level_2
{
    partial class loginform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.userpassword = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.upassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.logoutform = new System.Windows.Forms.Button();
            this.şifreyigöster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(43, 86);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(70, 16);
            this.username.TabIndex = 1;
            this.username.Text = "user name";
            // 
            // userpassword
            // 
            this.userpassword.AutoSize = true;
            this.userpassword.Location = new System.Drawing.Point(43, 130);
            this.userpassword.Name = "userpassword";
            this.userpassword.Size = new System.Drawing.Size(95, 16);
            this.userpassword.TabIndex = 2;
            this.userpassword.Text = "user password";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(156, 81);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(128, 22);
            this.uname.TabIndex = 3;
            // 
            // upassword
            // 
            this.upassword.Location = new System.Drawing.Point(155, 127);
            this.upassword.Name = "upassword";
            this.upassword.Size = new System.Drawing.Size(128, 22);
            this.upassword.TabIndex = 4;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.SeaGreen;
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(57, 196);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(97, 42);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logoutform
            // 
            this.logoutform.BackColor = System.Drawing.Color.SeaGreen;
            this.logoutform.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutform.Location = new System.Drawing.Point(187, 196);
            this.logoutform.Name = "logoutform";
            this.logoutform.Size = new System.Drawing.Size(97, 42);
            this.logoutform.TabIndex = 6;
            this.logoutform.Text = "logout";
            this.logoutform.UseVisualStyleBackColor = false;
            this.logoutform.Click += new System.EventHandler(this.button1_Click);
            // 
            // şifreyigöster
            // 
            this.şifreyigöster.AutoSize = true;
            this.şifreyigöster.Location = new System.Drawing.Point(312, 129);
            this.şifreyigöster.Name = "şifreyigöster";
            this.şifreyigöster.Size = new System.Drawing.Size(95, 20);
            this.şifreyigöster.TabIndex = 7;
            this.şifreyigöster.Text = "şifreyi gizle";
            this.şifreyigöster.UseVisualStyleBackColor = true;
            this.şifreyigöster.CheckedChanged += new System.EventHandler(this.şifreyigöster_CheckedChanged);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.şifreyigöster);
            this.Controls.Add(this.logoutform);
            this.Controls.Add(this.login);
            this.Controls.Add(this.upassword);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.username);
            this.Name = "loginform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label userpassword;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox upassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button logoutform;
        private System.Windows.Forms.CheckBox şifreyigöster;
    }
}

