namespace OOPII_Project_Online_Book_Store
{
    partial class BillingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingsForm));
            this.btnSendMail = new System.Windows.Forms.Button();
            this.dtgorder = new System.Windows.Forms.DataGridView();
            this.txtbilling = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgorder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSendMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMail.Image")));
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(238, 516);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(205, 107);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Send Me";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // dtgorder
            // 
            this.dtgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgorder.Location = new System.Drawing.Point(16, 30);
            this.dtgorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgorder.Name = "dtgorder";
            this.dtgorder.Size = new System.Drawing.Size(556, 383);
            this.dtgorder.TabIndex = 2;
            this.dtgorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgorder_CellClick);
            // 
            // txtbilling
            // 
            this.txtbilling.Location = new System.Drawing.Point(619, 30);
            this.txtbilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbilling.Multiline = true;
            this.txtbilling.Name = "txtbilling";
            this.txtbilling.ReadOnly = true;
            this.txtbilling.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbilling.Size = new System.Drawing.Size(419, 382);
            this.txtbilling.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(619, 516);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(205, 107);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // BillingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 655);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtbilling);
            this.Controls.Add(this.dtgorder);
            this.Controls.Add(this.btnSendMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BillingsForm";
            this.Text = "Purchase History";
            this.Load += new System.EventHandler(this.BillingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.DataGridView dtgorder;
        private System.Windows.Forms.TextBox txtbilling;
        private System.Windows.Forms.Button btncancel;
    }
}