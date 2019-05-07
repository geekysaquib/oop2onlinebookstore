namespace OOPII_Project_Online_Book_Store
{
    partial class MusicCDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicCDForm));
            this.pbmusicCD = new System.Windows.Forms.PictureBox();
            this.nudmussicCD = new System.Windows.Forms.NumericUpDown();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.btnPlayDemo = new System.Windows.Forms.Button();
            this.btnStopDemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbmusicCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmussicCD)).BeginInit();
            this.SuspendLayout();
            // 
            // pbmusicCD
            // 
            this.pbmusicCD.BackColor = System.Drawing.Color.Transparent;
            this.pbmusicCD.Location = new System.Drawing.Point(10, 34);
            this.pbmusicCD.Name = "pbmusicCD";
            this.pbmusicCD.Size = new System.Drawing.Size(148, 184);
            this.pbmusicCD.TabIndex = 0;
            this.pbmusicCD.TabStop = false;
            // 
            // nudmussicCD
            // 
            this.nudmussicCD.Location = new System.Drawing.Point(580, 267);
            this.nudmussicCD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudmussicCD.Name = "nudmussicCD";
            this.nudmussicCD.Size = new System.Drawing.Size(64, 20);
            this.nudmussicCD.TabIndex = 1;
            this.nudmussicCD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnpurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpurchase.FlatAppearance.BorderSize = 0;
            this.btnpurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchase.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnpurchase.Image")));
            this.btnpurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpurchase.Location = new System.Drawing.Point(516, 292);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(175, 75);
            this.btnpurchase.TabIndex = 2;
            this.btnpurchase.Text = "Add to Cart";
            this.btnpurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpurchase.UseVisualStyleBackColor = false;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(8, 258);
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
            this.lbltype.Location = new System.Drawing.Point(8, 292);
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
            this.lblprice.Location = new System.Drawing.Point(8, 327);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(63, 15);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price: ";
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssue.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssue.Location = new System.Drawing.Point(219, 212);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIssue.Size = new System.Drawing.Size(291, 274);
            this.txtIssue.TabIndex = 6;
            // 
            // btnPlayDemo
            // 
            this.btnPlayDemo.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayDemo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayDemo.BackgroundImage")));
            this.btnPlayDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayDemo.FlatAppearance.BorderSize = 0;
            this.btnPlayDemo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayDemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayDemo.Location = new System.Drawing.Point(544, 396);
            this.btnPlayDemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlayDemo.Name = "btnPlayDemo";
            this.btnPlayDemo.Size = new System.Drawing.Size(33, 33);
            this.btnPlayDemo.TabIndex = 7;
            this.btnPlayDemo.UseVisualStyleBackColor = false;
            this.btnPlayDemo.Click += new System.EventHandler(this.btnPlayDemo_Click);
            // 
            // btnStopDemo
            // 
            this.btnStopDemo.BackColor = System.Drawing.Color.Transparent;
            this.btnStopDemo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopDemo.BackgroundImage")));
            this.btnStopDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopDemo.FlatAppearance.BorderSize = 0;
            this.btnStopDemo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStopDemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStopDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopDemo.Location = new System.Drawing.Point(611, 396);
            this.btnStopDemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStopDemo.Name = "btnStopDemo";
            this.btnStopDemo.Size = new System.Drawing.Size(33, 33);
            this.btnStopDemo.TabIndex = 8;
            this.btnStopDemo.UseVisualStyleBackColor = false;
            this.btnStopDemo.Click += new System.EventHandler(this.btnStopDemo_Click);
            // 
            // MusicCDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 489);
            this.Controls.Add(this.btnStopDemo);
            this.Controls.Add(this.btnPlayDemo);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.nudmussicCD);
            this.Controls.Add(this.pbmusicCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicCDForm";
            this.Text = "MusicCDForm";
            this.Load += new System.EventHandler(this.MusicCDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbmusicCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmussicCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbmusicCD;
        private System.Windows.Forms.NumericUpDown nudmussicCD;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Button btnPlayDemo;
        private System.Windows.Forms.Button btnStopDemo;
    }
}