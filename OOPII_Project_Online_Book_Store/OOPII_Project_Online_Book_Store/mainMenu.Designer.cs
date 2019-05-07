namespace OOPII_Project_Online_Book_Store
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnAdminInterface = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.pnlType = new System.Windows.Forms.Panel();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu.SuspendLayout();
            this.pnlType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightCyan;
            this.pnlMenu.Controls.Add(this.lblID);
            this.pnlMenu.Controls.Add(this.lblemail);
            this.pnlMenu.Controls.Add(this.btnAdminInterface);
            this.pnlMenu.Controls.Add(this.lblusername);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnShoppingCart);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMenu.Location = new System.Drawing.Point(135, -8);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1002, 126);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(794, 87);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 18);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(793, 56);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 18);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "email";
            // 
            // btnAdminInterface
            // 
            this.btnAdminInterface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminInterface.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdminInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminInterface.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminInterface.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminInterface.Image")));
            this.btnAdminInterface.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminInterface.Location = new System.Drawing.Point(4, 0);
            this.btnAdminInterface.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdminInterface.Name = "btnAdminInterface";
            this.btnAdminInterface.Size = new System.Drawing.Size(154, 126);
            this.btnAdminInterface.TabIndex = 4;
            this.btnAdminInterface.Text = "Admin";
            this.btnAdminInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminInterface.UseVisualStyleBackColor = true;
            this.btnAdminInterface.Click += new System.EventHandler(this.btnAdminInterface_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(793, 18);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(124, 25);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "username";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(616, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(159, 126);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(393, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(231, 126);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "User Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoppingCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoppingCart.Image = ((System.Drawing.Image)(resources.GetObject("btnShoppingCart.Image")));
            this.btnShoppingCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingCart.Location = new System.Drawing.Point(151, -11);
            this.btnShoppingCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(244, 137);
            this.btnShoppingCart.TabIndex = 2;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // pnlType
            // 
            this.pnlType.BackColor = System.Drawing.Color.LightCyan;
            this.pnlType.Controls.Add(this.btnOrderHistory);
            this.pnlType.Controls.Add(this.cmbCategory);
            this.pnlType.Controls.Add(this.lblCategory);
            this.pnlType.Controls.Add(this.pbLogo);
            this.pnlType.Controls.Add(this.cmbProductType);
            this.pnlType.Controls.Add(this.lblProductType);
            this.pnlType.Location = new System.Drawing.Point(4, 0);
            this.pnlType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(136, 751);
            this.pnlType.TabIndex = 1;
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderHistory.Image")));
            this.btnOrderHistory.Location = new System.Drawing.Point(-3, 391);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(140, 117);
            this.btnOrderHistory.TabIndex = 4;
            this.btnOrderHistory.Text = "Purchases";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(8, 298);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 25);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged_1);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(19, 268);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 18);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(11, 13);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(108, 118);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "All products",
            "Book",
            "Magazine",
            "Music CD"});
            this.cmbProductType.Location = new System.Drawing.Point(8, 197);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(121, 25);
            this.cmbProductType.TabIndex = 0;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(5, 176);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(128, 18);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type";
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.BackColor = System.Drawing.Color.Transparent;
            this.flPanel.Location = new System.Drawing.Point(147, 134);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(975, 455);
            this.flPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 618);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlType);
            this.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Bookstore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAdminInterface;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnOrderHistory;
    }
}