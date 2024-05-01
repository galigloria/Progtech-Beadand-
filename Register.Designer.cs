namespace Lego
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_signup = new System.Windows.Forms.Button();
            this.register_username = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_mpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register_login = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.register_showpassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(-134, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(578, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "Üdvözöljük a Lego Áruház oldalán!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(1, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(1, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Jelszó";
            // 
            // register_signup
            // 
            this.register_signup.BackColor = System.Drawing.Color.LemonChiffon;
            this.register_signup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.register_signup.Location = new System.Drawing.Point(181, 384);
            this.register_signup.Name = "register_signup";
            this.register_signup.Size = new System.Drawing.Size(185, 45);
            this.register_signup.TabIndex = 15;
            this.register_signup.Text = "REGISZTRÁLÁS";
            this.register_signup.UseVisualStyleBackColor = false;
            this.register_signup.Click += new System.EventHandler(this.register_signup_Click);
            // 
            // register_username
            // 
            this.register_username.BackColor = System.Drawing.SystemColors.Info;
            this.register_username.Location = new System.Drawing.Point(186, 251);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(177, 22);
            this.register_username.TabIndex = 16;
            // 
            // register_password
            // 
            this.register_password.BackColor = System.Drawing.SystemColors.Info;
            this.register_password.Location = new System.Drawing.Point(186, 115);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(177, 22);
            this.register_password.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(97, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lego Áruház ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // register_mpassword
            // 
            this.register_mpassword.BackColor = System.Drawing.SystemColors.Info;
            this.register_mpassword.Location = new System.Drawing.Point(186, 192);
            this.register_mpassword.Name = "register_mpassword";
            this.register_mpassword.PasswordChar = '*';
            this.register_mpassword.Size = new System.Drawing.Size(177, 22);
            this.register_mpassword.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(1, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Jelszó megerősítése";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(131, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ön már rendelkezik fiókkal?";
            // 
            // register_login
            // 
            this.register_login.BackColor = System.Drawing.Color.White;
            this.register_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.register_login.Location = new System.Drawing.Point(135, 286);
            this.register_login.Name = "register_login";
            this.register_login.Size = new System.Drawing.Size(192, 45);
            this.register_login.TabIndex = 22;
            this.register_login.Text = "BEJELENTKEZÉS";
            this.register_login.UseVisualStyleBackColor = false;
            this.register_login.Click += new System.EventHandler(this.register_login_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.close.Font = new System.Drawing.Font("Arial monospaced for SAP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(-1, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 34);
            this.close.TabIndex = 23;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // register_showpassword
            // 
            this.register_showpassword.AutoSize = true;
            this.register_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_showpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.register_showpassword.Location = new System.Drawing.Point(186, 285);
            this.register_showpassword.Name = "register_showpassword";
            this.register_showpassword.Size = new System.Drawing.Size(180, 20);
            this.register_showpassword.TabIndex = 24;
            this.register_showpassword.Text = "Jelszó megjelenítése ";
            this.register_showpassword.UseVisualStyleBackColor = true;
            this.register_showpassword.CheckedChanged += new System.EventHandler(this.register_showpassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-350, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 186);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.register_login);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(417, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 458);
            this.panel1.TabIndex = 25;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_showpassword);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_mpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.register_signup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_signup;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_mpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button register_login;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.CheckBox register_showpassword;
        private System.Windows.Forms.Panel panel1;
    }
}