namespace OOPII_Project_Online_Book_Store
{
    partial class AdminInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterfaceForm));
            this.tbAdminInterface = new System.Windows.Forms.TabControl();
            this.tbUser = new System.Windows.Forms.TabPage();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.tbBook = new System.Windows.Forms.TabPage();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookPage = new System.Windows.Forms.TextBox();
            this.lblBookPage = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.txtBookIssue = new System.Windows.Forms.TextBox();
            this.lblBookIssue = new System.Windows.Forms.Label();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookIsbn = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookIsbn = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.dtgBook = new System.Windows.Forms.DataGridView();
            this.tbMagazine = new System.Windows.Forms.TabPage();
            this.cmbMagazineTypes = new System.Windows.Forms.ComboBox();
            this.btnAddMagazine = new System.Windows.Forms.Button();
            this.btnDeleteMagazine = new System.Windows.Forms.Button();
            this.btnUpdateMagazine = new System.Windows.Forms.Button();
            this.txtMagazineIssue = new System.Windows.Forms.TextBox();
            this.lblMagazineIssue = new System.Windows.Forms.Label();
            this.txtMagazinePrice = new System.Windows.Forms.TextBox();
            this.txtMagazineName = new System.Windows.Forms.TextBox();
            this.lblMagazinePrice = new System.Windows.Forms.Label();
            this.lblMagazineType = new System.Windows.Forms.Label();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.dtgMagazine = new System.Windows.Forms.DataGridView();
            this.btnMusicAdd = new System.Windows.Forms.TabPage();
            this.txtMusicSinger = new System.Windows.Forms.TextBox();
            this.lblMusicSinger = new System.Windows.Forms.Label();
            this.cmbMusicType = new System.Windows.Forms.ComboBox();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnDeleteMusic = new System.Windows.Forms.Button();
            this.btnUpdateMusic = new System.Windows.Forms.Button();
            this.txtMusicIssue = new System.Windows.Forms.TextBox();
            this.lblMusicIssue = new System.Windows.Forms.Label();
            this.txtMusicPrice = new System.Windows.Forms.TextBox();
            this.txtMusicName = new System.Windows.Forms.TextBox();
            this.lblMusicPrice = new System.Windows.Forms.Label();
            this.lblMusicType = new System.Windows.Forms.Label();
            this.lblMusicName = new System.Windows.Forms.Label();
            this.dtgMusicCD = new System.Windows.Forms.DataGridView();
            this.btnaddusers = new System.Windows.Forms.Button();
            this.tbAdminInterface.SuspendLayout();
            this.tbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.tbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).BeginInit();
            this.tbMagazine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMagazine)).BeginInit();
            this.btnMusicAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusicCD)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdminInterface
            // 
            this.tbAdminInterface.Controls.Add(this.tbUser);
            this.tbAdminInterface.Controls.Add(this.tbBook);
            this.tbAdminInterface.Controls.Add(this.tbMagazine);
            this.tbAdminInterface.Controls.Add(this.btnMusicAdd);
            this.tbAdminInterface.Location = new System.Drawing.Point(12, 12);
            this.tbAdminInterface.Name = "tbAdminInterface";
            this.tbAdminInterface.SelectedIndex = 0;
            this.tbAdminInterface.Size = new System.Drawing.Size(1113, 577);
            this.tbAdminInterface.TabIndex = 44;
            // 
            // tbUser
            // 
            this.tbUser.Controls.Add(this.btnaddusers);
            this.tbUser.Controls.Add(this.cbIsAdmin);
            this.tbUser.Controls.Add(this.btnDelete);
            this.tbUser.Controls.Add(this.btnUpdate);
            this.tbUser.Controls.Add(this.txtAdress);
            this.tbUser.Controls.Add(this.lblAdress);
            this.tbUser.Controls.Add(this.txtEmail);
            this.tbUser.Controls.Add(this.txtPassword);
            this.tbUser.Controls.Add(this.txtUsername);
            this.tbUser.Controls.Add(this.txtName);
            this.tbUser.Controls.Add(this.lblMail);
            this.tbUser.Controls.Add(this.lblPassword);
            this.tbUser.Controls.Add(this.lblUsername);
            this.tbUser.Controls.Add(this.lblName);
            this.tbUser.Controls.Add(this.dtgUsers);
            this.tbUser.Location = new System.Drawing.Point(4, 22);
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbUser.Size = new System.Drawing.Size(1105, 551);
            this.tbUser.TabIndex = 0;
            this.tbUser.Text = "Users";
            this.tbUser.UseVisualStyleBackColor = true;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cbIsAdmin.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsAdmin.Location = new System.Drawing.Point(857, 279);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(66, 17);
            this.cbIsAdmin.TabIndex = 86;
            this.cbIsAdmin.Text = "Admin";
            this.cbIsAdmin.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(734, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 75);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(903, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 70);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(824, 168);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(172, 106);
            this.txtAdress.TabIndex = 82;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(742, 168);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(62, 17);
            this.lblAdress.TabIndex = 83;
            this.lblAdress.Text = "Adress";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(824, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 81;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(824, 113);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 79;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(824, 88);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 20);
            this.txtUsername.TabIndex = 77;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(824, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 20);
            this.txtName.TabIndex = 75;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(749, 144);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(55, 15);
            this.lblMail.TabIndex = 80;
            this.lblMail.Text = "E-Mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(733, 114);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 15);
            this.lblPassword.TabIndex = 78;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(731, 88);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 15);
            this.lblUsername.TabIndex = 76;
            this.lblUsername.Text = "Username";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(763, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 74;
            this.lblName.Text = "Name";
            // 
            // dtgUsers
            // 
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(3, 4);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.Size = new System.Drawing.Size(712, 541);
            this.dtgUsers.TabIndex = 0;
            this.dtgUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsers_CellClick);
            // 
            // tbBook
            // 
            this.tbBook.Controls.Add(this.cmbBookType);
            this.tbBook.Controls.Add(this.label1);
            this.tbBook.Controls.Add(this.txtBookPage);
            this.tbBook.Controls.Add(this.lblBookPage);
            this.tbBook.Controls.Add(this.btnAddBook);
            this.tbBook.Controls.Add(this.txtBookAuthor);
            this.tbBook.Controls.Add(this.lblBookAuthor);
            this.tbBook.Controls.Add(this.btnDeleteBook);
            this.tbBook.Controls.Add(this.btnUpdateBook);
            this.tbBook.Controls.Add(this.txtBookIssue);
            this.tbBook.Controls.Add(this.lblBookIssue);
            this.tbBook.Controls.Add(this.txtBookPublisher);
            this.tbBook.Controls.Add(this.txtBookPrice);
            this.tbBook.Controls.Add(this.txtBookIsbn);
            this.tbBook.Controls.Add(this.txtBookName);
            this.tbBook.Controls.Add(this.lblBookPublisher);
            this.tbBook.Controls.Add(this.lblBookPrice);
            this.tbBook.Controls.Add(this.lblBookIsbn);
            this.tbBook.Controls.Add(this.lblBookName);
            this.tbBook.Controls.Add(this.dtgBook);
            this.tbBook.Location = new System.Drawing.Point(4, 22);
            this.tbBook.Name = "tbBook";
            this.tbBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbBook.Size = new System.Drawing.Size(1105, 551);
            this.tbBook.TabIndex = 1;
            this.tbBook.Text = "Book";
            this.tbBook.UseVisualStyleBackColor = true;
            // 
            // cmbBookType
            // 
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Comics",
            "Fantasy",
            "Crime",
            "Horror"});
            this.cmbBookType.Location = new System.Drawing.Point(824, 207);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(172, 21);
            this.cmbBookType.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(763, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 116;
            this.label1.Text = "Type";
            // 
            // txtBookPage
            // 
            this.txtBookPage.Location = new System.Drawing.Point(824, 167);
            this.txtBookPage.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPage.Name = "txtBookPage";
            this.txtBookPage.Size = new System.Drawing.Size(172, 20);
            this.txtBookPage.TabIndex = 90;
            // 
            // lblBookPage
            // 
            this.lblBookPage.AutoSize = true;
            this.lblBookPage.BackColor = System.Drawing.Color.Transparent;
            this.lblBookPage.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPage.Location = new System.Drawing.Point(763, 167);
            this.lblBookPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookPage.Name = "lblBookPage";
            this.lblBookPage.Size = new System.Drawing.Size(39, 15);
            this.lblBookPage.TabIndex = 89;
            this.lblBookPage.Text = "Page";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(824, 390);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(110, 70);
            this.btnAddBook.TabIndex = 88;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(824, 69);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(172, 20);
            this.txtBookAuthor.TabIndex = 87;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblBookAuthor.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(749, 69);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(55, 15);
            this.lblBookAuthor.TabIndex = 86;
            this.lblBookAuthor.Text = "Author";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Image")));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(896, 468);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(114, 75);
            this.btnDeleteBook.TabIndex = 85;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBook.Image")));
            this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBook.Location = new System.Drawing.Point(728, 466);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(130, 78);
            this.btnUpdateBook.TabIndex = 84;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // txtBookIssue
            // 
            this.txtBookIssue.Location = new System.Drawing.Point(824, 247);
            this.txtBookIssue.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookIssue.Multiline = true;
            this.txtBookIssue.Name = "txtBookIssue";
            this.txtBookIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBookIssue.Size = new System.Drawing.Size(172, 105);
            this.txtBookIssue.TabIndex = 82;
            // 
            // lblBookIssue
            // 
            this.lblBookIssue.AutoSize = true;
            this.lblBookIssue.BackColor = System.Drawing.Color.Transparent;
            this.lblBookIssue.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIssue.Location = new System.Drawing.Point(749, 248);
            this.lblBookIssue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookIssue.Name = "lblBookIssue";
            this.lblBookIssue.Size = new System.Drawing.Size(53, 17);
            this.lblBookIssue.TabIndex = 83;
            this.lblBookIssue.Text = "Issue";
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(824, 129);
            this.txtBookPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(172, 20);
            this.txtBookPublisher.TabIndex = 81;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(824, 97);
            this.txtBookPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(172, 20);
            this.txtBookPrice.TabIndex = 79;
            // 
            // txtBookIsbn
            // 
            this.txtBookIsbn.Location = new System.Drawing.Point(824, 39);
            this.txtBookIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookIsbn.Name = "txtBookIsbn";
            this.txtBookIsbn.Size = new System.Drawing.Size(172, 20);
            this.txtBookIsbn.TabIndex = 77;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(824, 5);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(172, 20);
            this.txtBookName.TabIndex = 75;
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblBookPublisher.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPublisher.Location = new System.Drawing.Point(725, 129);
            this.lblBookPublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(79, 15);
            this.lblBookPublisher.TabIndex = 80;
            this.lblBookPublisher.Text = "Publisher";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBookPrice.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.Location = new System.Drawing.Point(755, 97);
            this.lblBookPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(47, 15);
            this.lblBookPrice.TabIndex = 78;
            this.lblBookPrice.Text = "Price";
            // 
            // lblBookIsbn
            // 
            this.lblBookIsbn.AutoSize = true;
            this.lblBookIsbn.BackColor = System.Drawing.Color.Transparent;
            this.lblBookIsbn.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIsbn.Location = new System.Drawing.Point(763, 40);
            this.lblBookIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookIsbn.Name = "lblBookIsbn";
            this.lblBookIsbn.Size = new System.Drawing.Size(39, 15);
            this.lblBookIsbn.TabIndex = 76;
            this.lblBookIsbn.Text = "Isbn";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(763, 10);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(39, 15);
            this.lblBookName.TabIndex = 74;
            this.lblBookName.Text = "Name";
            // 
            // dtgBook
            // 
            this.dtgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBook.Location = new System.Drawing.Point(6, 3);
            this.dtgBook.Name = "dtgBook";
            this.dtgBook.Size = new System.Drawing.Size(698, 541);
            this.dtgBook.TabIndex = 1;
            this.dtgBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBook_CellClick);
            // 
            // tbMagazine
            // 
            this.tbMagazine.Controls.Add(this.cmbMagazineTypes);
            this.tbMagazine.Controls.Add(this.btnAddMagazine);
            this.tbMagazine.Controls.Add(this.btnDeleteMagazine);
            this.tbMagazine.Controls.Add(this.btnUpdateMagazine);
            this.tbMagazine.Controls.Add(this.txtMagazineIssue);
            this.tbMagazine.Controls.Add(this.lblMagazineIssue);
            this.tbMagazine.Controls.Add(this.txtMagazinePrice);
            this.tbMagazine.Controls.Add(this.txtMagazineName);
            this.tbMagazine.Controls.Add(this.lblMagazinePrice);
            this.tbMagazine.Controls.Add(this.lblMagazineType);
            this.tbMagazine.Controls.Add(this.lblMagazineName);
            this.tbMagazine.Controls.Add(this.dtgMagazine);
            this.tbMagazine.Location = new System.Drawing.Point(4, 22);
            this.tbMagazine.Name = "tbMagazine";
            this.tbMagazine.Size = new System.Drawing.Size(1105, 551);
            this.tbMagazine.TabIndex = 2;
            this.tbMagazine.Text = "Magazine";
            this.tbMagazine.UseVisualStyleBackColor = true;
            // 
            // cmbMagazineTypes
            // 
            this.cmbMagazineTypes.FormattingEnabled = true;
            this.cmbMagazineTypes.Items.AddRange(new object[] {
            "Science",
            "News",
            "Sport",
            "Computer",
            "Technology"});
            this.cmbMagazineTypes.Location = new System.Drawing.Point(828, 49);
            this.cmbMagazineTypes.Name = "cmbMagazineTypes";
            this.cmbMagazineTypes.Size = new System.Drawing.Size(172, 21);
            this.cmbMagazineTypes.TabIndex = 104;
            // 
            // btnAddMagazine
            // 
            this.btnAddMagazine.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMagazine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMagazine.FlatAppearance.BorderSize = 0;
            this.btnAddMagazine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddMagazine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMagazine.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMagazine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMagazine.Image")));
            this.btnAddMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMagazine.Location = new System.Drawing.Point(828, 381);
            this.btnAddMagazine.Name = "btnAddMagazine";
            this.btnAddMagazine.Size = new System.Drawing.Size(110, 70);
            this.btnAddMagazine.TabIndex = 103;
            this.btnAddMagazine.Text = "Add";
            this.btnAddMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMagazine.UseVisualStyleBackColor = false;
            this.btnAddMagazine.Click += new System.EventHandler(this.btnAddMagazine_Click);
            // 
            // btnDeleteMagazine
            // 
            this.btnDeleteMagazine.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMagazine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMagazine.FlatAppearance.BorderSize = 0;
            this.btnDeleteMagazine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMagazine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMagazine.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMagazine.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMagazine.Image")));
            this.btnDeleteMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMagazine.Location = new System.Drawing.Point(904, 468);
            this.btnDeleteMagazine.Name = "btnDeleteMagazine";
            this.btnDeleteMagazine.Size = new System.Drawing.Size(114, 75);
            this.btnDeleteMagazine.TabIndex = 100;
            this.btnDeleteMagazine.Text = "Delete";
            this.btnDeleteMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMagazine.UseVisualStyleBackColor = false;
            this.btnDeleteMagazine.Click += new System.EventHandler(this.btnDeleteMagazine_Click);
            // 
            // btnUpdateMagazine
            // 
            this.btnUpdateMagazine.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMagazine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMagazine.FlatAppearance.BorderSize = 0;
            this.btnUpdateMagazine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMagazine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMagazine.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMagazine.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMagazine.Image")));
            this.btnUpdateMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMagazine.Location = new System.Drawing.Point(739, 470);
            this.btnUpdateMagazine.Name = "btnUpdateMagazine";
            this.btnUpdateMagazine.Size = new System.Drawing.Size(130, 78);
            this.btnUpdateMagazine.TabIndex = 99;
            this.btnUpdateMagazine.Text = "Update";
            this.btnUpdateMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMagazine.UseVisualStyleBackColor = false;
            this.btnUpdateMagazine.Click += new System.EventHandler(this.btnUpdateMagazine_Click);
            // 
            // txtMagazineIssue
            // 
            this.txtMagazineIssue.Location = new System.Drawing.Point(828, 129);
            this.txtMagazineIssue.Margin = new System.Windows.Forms.Padding(2);
            this.txtMagazineIssue.Multiline = true;
            this.txtMagazineIssue.Name = "txtMagazineIssue";
            this.txtMagazineIssue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMagazineIssue.Size = new System.Drawing.Size(172, 231);
            this.txtMagazineIssue.TabIndex = 97;
            // 
            // lblMagazineIssue
            // 
            this.lblMagazineIssue.AutoSize = true;
            this.lblMagazineIssue.BackColor = System.Drawing.Color.Transparent;
            this.lblMagazineIssue.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineIssue.Location = new System.Drawing.Point(753, 129);
            this.lblMagazineIssue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagazineIssue.Name = "lblMagazineIssue";
            this.lblMagazineIssue.Size = new System.Drawing.Size(53, 17);
            this.lblMagazineIssue.TabIndex = 98;
            this.lblMagazineIssue.Text = "Issue";
            // 
            // txtMagazinePrice
            // 
            this.txtMagazinePrice.Location = new System.Drawing.Point(828, 90);
            this.txtMagazinePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMagazinePrice.Name = "txtMagazinePrice";
            this.txtMagazinePrice.Size = new System.Drawing.Size(172, 20);
            this.txtMagazinePrice.TabIndex = 94;
            // 
            // txtMagazineName
            // 
            this.txtMagazineName.Location = new System.Drawing.Point(828, 15);
            this.txtMagazineName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMagazineName.Name = "txtMagazineName";
            this.txtMagazineName.Size = new System.Drawing.Size(172, 20);
            this.txtMagazineName.TabIndex = 90;
            // 
            // lblMagazinePrice
            // 
            this.lblMagazinePrice.AutoSize = true;
            this.lblMagazinePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblMagazinePrice.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazinePrice.Location = new System.Drawing.Point(759, 91);
            this.lblMagazinePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagazinePrice.Name = "lblMagazinePrice";
            this.lblMagazinePrice.Size = new System.Drawing.Size(47, 15);
            this.lblMagazinePrice.TabIndex = 93;
            this.lblMagazinePrice.Text = "Price";
            // 
            // lblMagazineType
            // 
            this.lblMagazineType.AutoSize = true;
            this.lblMagazineType.BackColor = System.Drawing.Color.Transparent;
            this.lblMagazineType.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineType.Location = new System.Drawing.Point(767, 50);
            this.lblMagazineType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagazineType.Name = "lblMagazineType";
            this.lblMagazineType.Size = new System.Drawing.Size(39, 15);
            this.lblMagazineType.TabIndex = 91;
            this.lblMagazineType.Text = "Type";
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.BackColor = System.Drawing.Color.Transparent;
            this.lblMagazineName.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineName.Location = new System.Drawing.Point(767, 20);
            this.lblMagazineName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(39, 15);
            this.lblMagazineName.TabIndex = 89;
            this.lblMagazineName.Text = "Name";
            // 
            // dtgMagazine
            // 
            this.dtgMagazine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMagazine.Location = new System.Drawing.Point(6, 5);
            this.dtgMagazine.Name = "dtgMagazine";
            this.dtgMagazine.Size = new System.Drawing.Size(708, 541);
            this.dtgMagazine.TabIndex = 1;
            this.dtgMagazine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMagazine_CellClick);
            // 
            // btnMusicAdd
            // 
            this.btnMusicAdd.Controls.Add(this.txtMusicSinger);
            this.btnMusicAdd.Controls.Add(this.lblMusicSinger);
            this.btnMusicAdd.Controls.Add(this.cmbMusicType);
            this.btnMusicAdd.Controls.Add(this.btnAddMusic);
            this.btnMusicAdd.Controls.Add(this.btnDeleteMusic);
            this.btnMusicAdd.Controls.Add(this.btnUpdateMusic);
            this.btnMusicAdd.Controls.Add(this.txtMusicIssue);
            this.btnMusicAdd.Controls.Add(this.lblMusicIssue);
            this.btnMusicAdd.Controls.Add(this.txtMusicPrice);
            this.btnMusicAdd.Controls.Add(this.txtMusicName);
            this.btnMusicAdd.Controls.Add(this.lblMusicPrice);
            this.btnMusicAdd.Controls.Add(this.lblMusicType);
            this.btnMusicAdd.Controls.Add(this.lblMusicName);
            this.btnMusicAdd.Controls.Add(this.dtgMusicCD);
            this.btnMusicAdd.Location = new System.Drawing.Point(4, 22);
            this.btnMusicAdd.Name = "btnMusicAdd";
            this.btnMusicAdd.Size = new System.Drawing.Size(1105, 551);
            this.btnMusicAdd.TabIndex = 3;
            this.btnMusicAdd.Text = "Music CD";
            this.btnMusicAdd.UseVisualStyleBackColor = true;
            // 
            // txtMusicSinger
            // 
            this.txtMusicSinger.Location = new System.Drawing.Point(830, 40);
            this.txtMusicSinger.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusicSinger.Name = "txtMusicSinger";
            this.txtMusicSinger.Size = new System.Drawing.Size(172, 20);
            this.txtMusicSinger.TabIndex = 117;
            // 
            // lblMusicSinger
            // 
            this.lblMusicSinger.AutoSize = true;
            this.lblMusicSinger.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicSinger.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicSinger.Location = new System.Drawing.Point(753, 41);
            this.lblMusicSinger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusicSinger.Name = "lblMusicSinger";
            this.lblMusicSinger.Size = new System.Drawing.Size(55, 15);
            this.lblMusicSinger.TabIndex = 116;
            this.lblMusicSinger.Text = "Singer";
            // 
            // cmbMusicType
            // 
            this.cmbMusicType.FormattingEnabled = true;
            this.cmbMusicType.Items.AddRange(new object[] {
            "Rap",
            "Rock",
            "Pop",
            "Metal"});
            this.cmbMusicType.Location = new System.Drawing.Point(830, 76);
            this.cmbMusicType.Name = "cmbMusicType";
            this.cmbMusicType.Size = new System.Drawing.Size(172, 21);
            this.cmbMusicType.TabIndex = 115;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMusic.FlatAppearance.BorderSize = 0;
            this.btnAddMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMusic.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMusic.Image")));
            this.btnAddMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMusic.Location = new System.Drawing.Point(841, 379);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(124, 70);
            this.btnAddMusic.TabIndex = 114;
            this.btnAddMusic.Text = "Add";
            this.btnAddMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMusic.UseVisualStyleBackColor = false;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusicCD_Click);
            // 
            // btnDeleteMusic
            // 
            this.btnDeleteMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMusic.FlatAppearance.BorderSize = 0;
            this.btnDeleteMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMusic.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMusic.Image")));
            this.btnDeleteMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMusic.Location = new System.Drawing.Point(919, 466);
            this.btnDeleteMusic.Name = "btnDeleteMusic";
            this.btnDeleteMusic.Size = new System.Drawing.Size(114, 75);
            this.btnDeleteMusic.TabIndex = 113;
            this.btnDeleteMusic.Text = "Delete";
            this.btnDeleteMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMusic.UseVisualStyleBackColor = false;
            this.btnDeleteMusic.Click += new System.EventHandler(this.btnDeleteMusic_Click);
            // 
            // btnUpdateMusic
            // 
            this.btnUpdateMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMusic.FlatAppearance.BorderSize = 0;
            this.btnUpdateMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMusic.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMusic.Image")));
            this.btnUpdateMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMusic.Location = new System.Drawing.Point(741, 466);
            this.btnUpdateMusic.Name = "btnUpdateMusic";
            this.btnUpdateMusic.Size = new System.Drawing.Size(130, 78);
            this.btnUpdateMusic.TabIndex = 112;
            this.btnUpdateMusic.Text = "Update";
            this.btnUpdateMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMusic.UseVisualStyleBackColor = false;
            this.btnUpdateMusic.Click += new System.EventHandler(this.btnUpdateMusic_Click);
            // 
            // txtMusicIssue
            // 
            this.txtMusicIssue.Location = new System.Drawing.Point(830, 142);
            this.txtMusicIssue.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusicIssue.Multiline = true;
            this.txtMusicIssue.Name = "txtMusicIssue";
            this.txtMusicIssue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMusicIssue.Size = new System.Drawing.Size(172, 201);
            this.txtMusicIssue.TabIndex = 110;
            // 
            // lblMusicIssue
            // 
            this.lblMusicIssue.AutoSize = true;
            this.lblMusicIssue.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicIssue.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicIssue.Location = new System.Drawing.Point(755, 142);
            this.lblMusicIssue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusicIssue.Name = "lblMusicIssue";
            this.lblMusicIssue.Size = new System.Drawing.Size(53, 17);
            this.lblMusicIssue.TabIndex = 111;
            this.lblMusicIssue.Text = "Issue";
            // 
            // txtMusicPrice
            // 
            this.txtMusicPrice.Location = new System.Drawing.Point(830, 110);
            this.txtMusicPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusicPrice.Name = "txtMusicPrice";
            this.txtMusicPrice.Size = new System.Drawing.Size(172, 20);
            this.txtMusicPrice.TabIndex = 109;
            // 
            // txtMusicName
            // 
            this.txtMusicName.Location = new System.Drawing.Point(830, 11);
            this.txtMusicName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusicName.Name = "txtMusicName";
            this.txtMusicName.Size = new System.Drawing.Size(172, 20);
            this.txtMusicName.TabIndex = 106;
            // 
            // lblMusicPrice
            // 
            this.lblMusicPrice.AutoSize = true;
            this.lblMusicPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicPrice.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicPrice.Location = new System.Drawing.Point(761, 110);
            this.lblMusicPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusicPrice.Name = "lblMusicPrice";
            this.lblMusicPrice.Size = new System.Drawing.Size(47, 15);
            this.lblMusicPrice.TabIndex = 108;
            this.lblMusicPrice.Text = "Price";
            // 
            // lblMusicType
            // 
            this.lblMusicType.AutoSize = true;
            this.lblMusicType.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicType.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicType.Location = new System.Drawing.Point(769, 76);
            this.lblMusicType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusicType.Name = "lblMusicType";
            this.lblMusicType.Size = new System.Drawing.Size(39, 15);
            this.lblMusicType.TabIndex = 107;
            this.lblMusicType.Text = "Type";
            // 
            // lblMusicName
            // 
            this.lblMusicName.AutoSize = true;
            this.lblMusicName.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicName.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicName.Location = new System.Drawing.Point(769, 12);
            this.lblMusicName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusicName.Name = "lblMusicName";
            this.lblMusicName.Size = new System.Drawing.Size(39, 15);
            this.lblMusicName.TabIndex = 105;
            this.lblMusicName.Text = "Name";
            // 
            // dtgMusicCD
            // 
            this.dtgMusicCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMusicCD.Location = new System.Drawing.Point(6, 5);
            this.dtgMusicCD.Name = "dtgMusicCD";
            this.dtgMusicCD.Size = new System.Drawing.Size(708, 541);
            this.dtgMusicCD.TabIndex = 1;
            this.dtgMusicCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusicCD_CellClick);
            // 
            // btnaddusers
            // 
            this.btnaddusers.BackColor = System.Drawing.Color.Transparent;
            this.btnaddusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddusers.FlatAppearance.BorderSize = 0;
            this.btnaddusers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnaddusers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnaddusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddusers.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddusers.Image = ((System.Drawing.Image)(resources.GetObject("btnaddusers.Image")));
            this.btnaddusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddusers.Location = new System.Drawing.Point(824, 334);
            this.btnaddusers.Name = "btnaddusers";
            this.btnaddusers.Size = new System.Drawing.Size(110, 70);
            this.btnaddusers.TabIndex = 89;
            this.btnaddusers.Text = "Add";
            this.btnaddusers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddusers.UseVisualStyleBackColor = false;
            this.btnaddusers.Click += new System.EventHandler(this.btnaddusers_Click);
            // 
            // AdminInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 601);
            this.Controls.Add(this.tbAdminInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminInterfaceForm";
            this.Text = "Admin Interface";
            this.Load += new System.EventHandler(this.AdminInterfaceForm_Load);
            this.tbAdminInterface.ResumeLayout(false);
            this.tbUser.ResumeLayout(false);
            this.tbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.tbBook.ResumeLayout(false);
            this.tbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).EndInit();
            this.tbMagazine.ResumeLayout(false);
            this.tbMagazine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMagazine)).EndInit();
            this.btnMusicAdd.ResumeLayout(false);
            this.btnMusicAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusicCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbAdminInterface;
        private System.Windows.Forms.TabPage tbUser;
        private System.Windows.Forms.TabPage tbBook;
        private System.Windows.Forms.TabPage tbMagazine;
        private System.Windows.Forms.TabPage btnMusicAdd;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.DataGridView dtgBook;
        private System.Windows.Forms.DataGridView dtgMagazine;
        private System.Windows.Forms.DataGridView dtgMusicCD;
        private System.Windows.Forms.CheckBox cbIsAdmin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.TextBox txtBookIssue;
        private System.Windows.Forms.Label lblBookIssue;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookIsbn;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookIsbn;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ComboBox cmbMagazineTypes;
        private System.Windows.Forms.Button btnAddMagazine;
        private System.Windows.Forms.Button btnDeleteMagazine;
        private System.Windows.Forms.Button btnUpdateMagazine;
        private System.Windows.Forms.TextBox txtMagazineIssue;
        private System.Windows.Forms.Label lblMagazineIssue;
        private System.Windows.Forms.TextBox txtMagazinePrice;
        private System.Windows.Forms.TextBox txtMagazineName;
        private System.Windows.Forms.Label lblMagazinePrice;
        private System.Windows.Forms.Label lblMagazineType;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.TextBox txtMusicSinger;
        private System.Windows.Forms.Label lblMusicSinger;
        private System.Windows.Forms.ComboBox cmbMusicType;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnDeleteMusic;
        private System.Windows.Forms.Button btnUpdateMusic;
        private System.Windows.Forms.TextBox txtMusicIssue;
        private System.Windows.Forms.Label lblMusicIssue;
        private System.Windows.Forms.TextBox txtMusicPrice;
        private System.Windows.Forms.TextBox txtMusicName;
        private System.Windows.Forms.Label lblMusicPrice;
        private System.Windows.Forms.Label lblMusicType;
        private System.Windows.Forms.Label lblMusicName;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookPage;
        private System.Windows.Forms.Label lblBookPage;
        private System.Windows.Forms.Button btnaddusers;
    }
}