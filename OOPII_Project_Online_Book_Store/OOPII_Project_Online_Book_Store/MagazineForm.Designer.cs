namespace OOPII_Project_Online_Book_Store
{
    partial class MagazineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineForm));
            this.pbmagazine = new System.Windows.Forms.PictureBox();
            this.nudMagazine = new System.Windows.Forms.NumericUpDown();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbmagazine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagazine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbmagazine
            // 
            this.pbmagazine.BackColor = System.Drawing.Color.Transparent;
            this.pbmagazine.Location = new System.Drawing.Point(21, 41);
            this.pbmagazine.Name = "pbmagazine";
            this.pbmagazine.Size = new System.Drawing.Size(117, 180);
            this.pbmagazine.TabIndex = 0;
            this.pbmagazine.TabStop = false;
            // 
            // nudMagazine
            // 
            this.nudMagazine.Location = new System.Drawing.Point(358, 283);
            this.nudMagazine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMagazine.Name = "nudMagazine";
            this.nudMagazine.Size = new System.Drawing.Size(92, 20);
            this.nudMagazine.TabIndex = 1;
            this.nudMagazine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(32, 262);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 15);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name: ";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Transparent;
            this.lbltype.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(32, 288);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(55, 15);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Type: ";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(32, 314);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(63, 15);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price: ";
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssue.Location = new System.Drawing.Point(185, 41);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.Size = new System.Drawing.Size(329, 180);
            this.txtIssue.TabIndex = 7;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(315, 307);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(175, 75);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Add to Cart";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // MagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 447);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.nudMagazine);
            this.Controls.Add(this.pbmagazine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazineForm";
            this.Text = "MagazineForm";
            this.Load += new System.EventHandler(this.MagazineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbmagazine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagazine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbmagazine;
        private System.Windows.Forms.NumericUpDown nudMagazine;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Button btnPurchase;
    }
}