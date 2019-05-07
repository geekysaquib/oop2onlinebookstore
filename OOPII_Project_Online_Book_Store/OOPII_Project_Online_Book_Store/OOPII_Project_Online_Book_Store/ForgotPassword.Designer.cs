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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbConfirmEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbSendPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(100, 74);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(75, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "E-mail";
            // 
            // lbConfirmEmail
            // 
            this.lbConfirmEmail.AutoSize = true;
            this.lbConfirmEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirmEmail.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmEmail.Location = new System.Drawing.Point(12, 110);
            this.lbConfirmEmail.Name = "lbConfirmEmail";
            this.lbConfirmEmail.Size = new System.Drawing.Size(163, 20);
            this.lbConfirmEmail.TabIndex = 1;
            this.lbConfirmEmail.Text = "Confirm E-mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 3;
            // 
            // pbSendPassword
            // 
            this.pbSendPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSendPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbSendPassword.Image")));
            this.pbSendPassword.Location = new System.Drawing.Point(104, 178);
            this.pbSendPassword.Name = "pbSendPassword";
            this.pbSendPassword.Size = new System.Drawing.Size(259, 42);
            this.pbSendPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSendPassword.TabIndex = 4;
            this.pbSendPassword.TabStop = false;
            // 
            // forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 284);
            this.Controls.Add(this.pbSendPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbConfirmEmail);
            this.Controls.Add(this.lbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "forgotPassword";
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.pbSendPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbConfirmEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbSendPassword;
    }
}