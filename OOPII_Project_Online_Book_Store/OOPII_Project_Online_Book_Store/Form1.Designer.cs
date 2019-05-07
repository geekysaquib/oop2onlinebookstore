namespace OOPII_Project_Online_Book_Store
{
    partial class Zoom
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnpurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(234, 46);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 13);
            this.lblinfo.TabIndex = 1;
            // 
            // btnpurchase
            // 
            this.btnpurchase.Location = new System.Drawing.Point(228, 276);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(75, 23);
            this.btnpurchase.TabIndex = 2;
            this.btnpurchase.Text = "purchase";
            this.btnpurchase.UseVisualStyleBackColor = true;
            // 
            // Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 338);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Zoom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Zoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnpurchase;
    }
}