namespace OOPII_Project_Online_Book_Store
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbRemind = new System.Windows.Forms.CheckBox();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.lbSıgnUp = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(65, 120);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 20);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(65, 159);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(97, 20);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(167, 120);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 158);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // cbRemind
            // 
            this.cbRemind.AutoSize = true;
            this.cbRemind.BackColor = System.Drawing.Color.Transparent;
            this.cbRemind.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemind.Location = new System.Drawing.Point(69, 189);
            this.cbRemind.Margin = new System.Windows.Forms.Padding(4);
            this.cbRemind.Name = "cbRemind";
            this.cbRemind.Size = new System.Drawing.Size(120, 21);
            this.cbRemind.TabIndex = 6;
            this.cbRemind.Text = "Remind Me?";
            this.cbRemind.UseVisualStyleBackColor = false;
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.Image = ((System.Drawing.Image)(resources.GetObject("pbBook.Image")));
            this.pbBook.Location = new System.Drawing.Point(112, 25);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(115, 73);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 8;
            this.pbBook.TabStop = false;
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.Location = new System.Drawing.Point(83, 345);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(168, 18);
            this.lbForgotPassword.TabIndex = 9;
            this.lbForgotPassword.Text = "Forgot Password?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // lbSıgnUp
            // 
            this.lbSıgnUp.AutoSize = true;
            this.lbSıgnUp.BackColor = System.Drawing.Color.Transparent;
            this.lbSıgnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSıgnUp.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSıgnUp.Location = new System.Drawing.Point(123, 298);
            this.lbSıgnUp.Name = "lbSıgnUp";
            this.lbSıgnUp.Size = new System.Drawing.Size(86, 20);
            this.lbSıgnUp.TabIndex = 10;
            this.lbSıgnUp.Text = "SIGN UP";
            this.lbSıgnUp.Click += new System.EventHandler(this.lbSıgnUp_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(133, 229);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(56, 50);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 11;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPassword.Image")));
            this.pbShowPassword.Location = new System.Drawing.Point(273, 158);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(36, 22);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowPassword.TabIndex = 12;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 414);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.lbSıgnUp);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.pbBook);
            this.Controls.Add(this.cbRemind);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbRemind;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.Label lbSıgnUp;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbShowPassword;
    }
}

