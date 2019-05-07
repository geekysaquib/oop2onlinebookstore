namespace OOPII_Project_Online_Book_Store
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.picbxBookPicture = new System.Windows.Forms.PictureBox();
            this.nudPurchase = new System.Windows.Forms.NumericUpDown();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblpage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBookPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(32, 246);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(61, 12);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "BookName";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBookPrice.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.Location = new System.Drawing.Point(33, 380);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(75, 12);
            this.lblBookPrice.TabIndex = 1;
            this.lblBookPrice.Text = "BookPrice:";
            // 
            // picbxBookPicture
            // 
            this.picbxBookPicture.BackColor = System.Drawing.Color.Transparent;
            this.picbxBookPicture.Location = new System.Drawing.Point(34, 31);
            this.picbxBookPicture.Name = "picbxBookPicture";
            this.picbxBookPicture.Size = new System.Drawing.Size(200, 200);
            this.picbxBookPicture.TabIndex = 2;
            this.picbxBookPicture.TabStop = false;
            // 
            // nudPurchase
            // 
            this.nudPurchase.Location = new System.Drawing.Point(368, 262);
            this.nudPurchase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPurchase.Name = "nudPurchase";
            this.nudPurchase.Size = new System.Drawing.Size(120, 20);
            this.nudPurchase.TabIndex = 4;
            this.nudPurchase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssue.Location = new System.Drawing.Point(364, 24);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.Size = new System.Drawing.Size(485, 169);
            this.txtIssue.TabIndex = 5;
            this.txtIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(32, 268);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 12);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(32, 290);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(40, 12);
            this.lblISBN.TabIndex = 7;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(32, 314);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(75, 12);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblpage
            // 
            this.lblpage.AutoSize = true;
            this.lblpage.BackColor = System.Drawing.Color.Transparent;
            this.lblpage.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpage.Location = new System.Drawing.Point(32, 359);
            this.lblpage.Name = "lblpage";
            this.lblpage.Size = new System.Drawing.Size(40, 12);
            this.lblpage.TabIndex = 9;
            this.lblpage.Text = "Page:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(32, 336);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 12);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
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
            this.btnPurchase.Location = new System.Drawing.Point(352, 298);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(176, 84);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "Add to Cart";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblpage);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.nudPurchase);
            this.Controls.Add(this.picbxBookPicture);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.lblBookName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxBookPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.PictureBox picbxBookPicture;
        private System.Windows.Forms.NumericUpDown nudPurchase;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblpage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnPurchase;
    }
}