 private void InitializeComponent()
        {
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_login = new System.Windows.Forms.Button();
            this.user_showpassword = new System.Windows.Forms.CheckBox();
            this.user_signup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.SystemColors.Info;
            this.user_name.Location = new System.Drawing.Point(165, 249);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(177, 22);
            this.user_name.TabIndex = 0;
           
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.SystemColors.Info;
            this.user_password.Location = new System.Drawing.Point(165, 304);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(177, 22);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(-4, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(3, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
            // 
            // user_login
            // 
            this.user_login.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.user_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.user_login.Location = new System.Drawing.Point(150, 409);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(211, 45);
            this.user_login.TabIndex = 4;
            this.user_login.Text = "BEJELENTKEZÉS";
            this.user_login.UseVisualStyleBackColor = false;
            this.user_login.Click += new System.EventHandler(this.user_login_Click);
            // 
            // user_showpassword
            // 
            this.user_showpassword.AutoSize = true;
            this.user_showpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.user_showpassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.user_showpassword.Location = new System.Drawing.Point(165, 353);
            this.user_showpassword.Name = "user_showpassword";
            this.user_showpassword.Size = new System.Drawing.Size(178, 23);
            this.user_showpassword.TabIndex = 6;
            this.user_showpassword.Text = "jelszó megjelenítése";
            this.user_showpassword.UseVisualStyleBackColor = false;
            this.user_showpassword.CheckedChanged += new System.EventHandler(this.user_showpassword_CheckedChanged);
            // 
            // user_signup
            // 
            this.user_signup.BackColor = System.Drawing.Color.LemonChiffon;
            this.user_signup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.user_signup.Location = new System.Drawing.Point(103, 321);
            this.user_signup.Name = "user_signup";
            this.user_signup.Size = new System.Drawing.Size(185, 45);
            this.user_signup.TabIndex = 8;
            this.user_signup.Text = "REGISZTRCIÓ";
            this.user_signup.UseVisualStyleBackColor = false;
            this.user_signup.Click += new System.EventHandler(this.user_signup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(83, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ön még nem rendelkezik fiókkal?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(109, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lego Áruház";
            
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.close.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(-7, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 35);
            this.close.TabIndex = 24;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-11, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 223);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.user_showpassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.user_password);
            this.panel1.Controls.Add(this.user_login);
            this.panel1.Location = new System.Drawing.Point(434, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 496);
            this.panel1.TabIndex = 26;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_signup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
