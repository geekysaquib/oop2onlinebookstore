namespace OOPII_Project_Online_Book_Store
{
    partial class forgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassword));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfirmEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmailConfirm = new System.Windows.Forms.TextBox();
            this.pbSendPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(100, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // lblConfirmEmail
            // 
            this.lblConfirmEmail.AutoSize = true;
            this.lblConfirmEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmEmail.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmEmail.Location = new System.Drawing.Point(12, 110);
            this.lblConfirmEmail.Name = "lblConfirmEmail";
            this.lblConfirmEmail.Size = new System.Drawing.Size(163, 20);
            this.lblConfirmEmail.TabIndex = 1;
            this.lblConfirmEmail.Text = "Confirm E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 71);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtEmailConfirm
            // 
            this.txtEmailConfirm.Location = new System.Drawing.Point(203, 110);
            this.txtEmailConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailConfirm.Name = "txtEmailConfirm";
            this.txtEmailConfirm.Size = new System.Drawing.Size(180, 22);
            this.txtEmailConfirm.TabIndex = 3;
            // 
            // pbSendPassword
            // 
            this.pbSendPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSendPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbSendPassword.Image")));
            this.pbSendPassword.Location = new System.Drawing.Point(104, 178);
            this.pbSendPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSendPassword.Name = "pbSendPassword";
            this.pbSendPassword.Size = new System.Drawing.Size(259, 42);
            this.pbSendPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSendPassword.TabIndex = 4;
            this.pbSendPassword.TabStop = false;
            this.pbSendPassword.Click += new System.EventHandler(this.pbSendPassword_Click);
            // 
            // forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 284);
            this.Controls.Add(this.pbSendPassword);
            this.Controls.Add(this.txtEmailConfirm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblConfirmEmail);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "forgotPassword";
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.pbSendPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConfirmEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmailConfirm;
        private System.Windows.Forms.PictureBox pbSendPassword;
    }
}