using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPII_Project_Online_Book_Store
{
    public partial class AdminInterfaceForm : Form
    {
        AdminUser adminUser = null;
        DataBase data = DataBase.database();
        public AdminInterfaceForm(AdminUser adminUser)
        {
            this.adminUser = adminUser;
            Product.Idcount = data.getcount("product");
            InitializeComponent();
        }

        public DataTable DataTable { get; private set; }

        private void AdminInterfaceForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "customer");
            dtgUsers.DataSource = DataTable;
            DataTable BookdataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "book");
            dtgBook.DataSource = DataTable;
            DataTable magazinedataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "magazine");
            dtgMagazine.DataSource = DataTable;
            DataTable musicCDdataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "musicCD");
            dtgMusicCD.DataSource = DataTable;
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dtgUsers.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtAdress.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            cbIsAdmin.Checked = Convert.ToBoolean(dtgUsers.CurrentRow.Cells[6].Value);

        }

        

       

        private void dtgBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookIsbn.Text = dtgBook.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dtgBook.CurrentRow.Cells[1].Value.ToString();
            txtBookPrice.Text = dtgBook.CurrentRow.Cells[3].Value.ToString();
            txtBookAuthor.Text = dtgBook.CurrentRow.Cells[4].Value.ToString();
            txtBookPublisher.Text = dtgBook.CurrentRow.Cells[5].Value.ToString();
            txtBookPage.Text = dtgBook.CurrentRow.Cells[6].Value.ToString();
            string Typeindex=dtgBook.CurrentRow.Cells[7].Value.ToString();

            cmbBookType.SelectedIndex = cmbBookType.Items.IndexOf(Typeindex.Trim());
            txtBookIssue.Text = dtgBook.CurrentRow.Cells[9].Value.ToString();
        }

        private void dtgMagazine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMagazineName.Text = dtgMagazine.CurrentRow.Cells[1].Value.ToString();
            txtMagazinePrice.Text = dtgMagazine.CurrentRow.Cells[2].Value.ToString();

            txtMagazineIssue.Text = dtgMagazine.CurrentRow.Cells[4].Value.ToString();
            string Typeindex = dtgMagazine.CurrentRow.Cells[3].Value.ToString();

            cmbMagazineTypes.SelectedIndex = cmbMagazineTypes.Items.IndexOf(Typeindex.Trim());

        }

        private void dtgMusicCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusicPrice.Text = dtgMusicCD.CurrentRow.Cells[1].Value.ToString();
            txtMusicName.Text = dtgMusicCD.CurrentRow.Cells[2].Value.ToString();
            string Typeindex = dtgMusicCD.CurrentRow.Cells[3].Value.ToString();

            cmbMusicType.SelectedIndex = cmbMusicType.Items.IndexOf(Typeindex.Trim());
            txtMusicSinger.Text = dtgMusicCD.CurrentRow.Cells[4].Value.ToString();
            txtMusicIssue.Text = dtgMusicCD.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            data.DeleteBook(Convert.ToInt32(dtgBook.CurrentRow.Cells[2].Value));
            data.DeleteProduct(Convert.ToInt32(dtgBook.CurrentRow.Cells[2].Value));
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "book");
            dtgBook.DataSource = DataTable;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            //BookType bookType = Book.GetBookType(cmbBookType.SelectedText);
            data.updateBook(Convert.ToInt32(dtgBook.CurrentRow.Cells[2].Value), txtBookName.Text.Trim(), txtBookIsbn.Text.Trim(), txtBookAuthor.Text.Trim(), txtBookPublisher.Text.Trim(), Convert.ToDouble(txtBookPrice.Text), Convert.ToInt32(txtBookPage.Text),cmbBookType.SelectedItem.ToString(), txtBookIssue.Text.Trim(), dtgBook.CurrentRow.Cells[8].Value.ToString());
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "book");
            dtgBook.DataSource = DataTable;
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer newcustomer = null;
            if (cbIsAdmin.Checked)
            {
                newcustomer = new AdminUser(txtName.Text, txtAdress.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, Convert.ToInt32(dtgUsers.CurrentRow.Cells[2].Value));

            }

            else
            {
                newcustomer = new Customer(txtName.Text, txtAdress.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, Convert.ToInt32(dtgUsers.CurrentRow.Cells[2].Value));
            }
            int row =Convert.ToInt32( dtgUsers.CurrentRow.Cells[2].Value )- 1;

            if (txtAdress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                if (dtgUsers.CurrentRow.Cells[0].Value.ToString() != newcustomer.Username)
                {
                    if (data.usernameControl(newcustomer))
                    {
                        data.updateCustomer(newcustomer.CustomerID, newcustomer.Name, newcustomer.Username, newcustomer.Password, newcustomer.Email, newcustomer.Adress, newcustomer.IsAdmin.ToString());
                        MessageBox.Show("Update succeed","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    data.updateCustomer(newcustomer.CustomerID, newcustomer.Name, newcustomer.Username, newcustomer.Password, newcustomer.Email, newcustomer.Adress, newcustomer.IsAdmin.ToString());
                    MessageBox.Show("Update succeed", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Texts can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "customer");
            dtgUsers.DataSource = DataTable;
            txtAdress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            data.DeleteCustomer(Convert.ToInt32(dtgUsers.CurrentRow.Cells[2].Value));
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "customer");
            dtgUsers.DataSource = DataTable;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
            BookType type = Book.GetBookType(cmbBookType.SelectedItem.ToString());
            adminUser.addNewBook(txtBookIsbn.Text, txtBookAuthor.Text, txtBookPublisher.Text, txtBookName.Text.Trim() + ".jpg", Convert.ToInt32(txtBookPage.Text), txtBookName.Text, Book.Idcount, Convert.ToDouble(txtBookPrice.Text.Trim()), txtBookIssue.Text,type);
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "book");
            dtgBook.DataSource = DataTable;
        }

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            
            MagazineType type = Magazine.getmagazine(cmbMagazineTypes.SelectedItem.ToString());
            adminUser.addNewMagazine(type, txtMagazineIssue.Text, txtMagazineName.Text, Product.Idcount, Convert.ToDouble(txtMagazinePrice.Text.Trim()), txtMagazineName.Text.Trim() + ".jpg");
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "magazine");
            dtgMagazine.DataSource = DataTable;
        }

        private void btnAddMusicCD_Click(object sender, EventArgs e)
        {
           ;
            MusicCDType type = MusicCD.getMusicCDType(cmbMusicType.SelectedItem.ToString());
            adminUser.addNewMusicCD(txtMusicSinger.Text, type, txtMusicName.Text, Product.Idcount, Convert.ToDouble(txtMusicPrice.Text.Trim()), txtMusicName.Text.Trim() + ".jpg", txtMusicIssue.Text);
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "musicCD");
            dtgMusicCD.DataSource = DataTable;
        }

        private void btnUpdateMagazine_Click(object sender, EventArgs e)
        {
            
            data.updatemagazine(Convert.ToInt32(dtgMagazine.CurrentRow.Cells[0].Value), txtMagazineName.Text, Convert.ToDouble(txtMagazinePrice.Text), cmbMagazineTypes.SelectedItem.ToString(), txtMagazineIssue.Text, dtgMagazine.CurrentRow.Cells[5].Value.ToString());
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "magazine");
            dtgMagazine.DataSource = DataTable;
        }

        private void btnDeleteMagazine_Click(object sender, EventArgs e)
        {
            data.Deletemagazine(Convert.ToInt32(dtgMagazine.CurrentRow.Cells[0].Value));
            data.DeleteProduct(Convert.ToInt32(dtgMagazine.CurrentRow.Cells[0].Value));
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "magazine");
            dtgMagazine.DataSource = DataTable;
        }

        private void btnUpdateMusic_Click(object sender, EventArgs e)
        {
            
            data.updatemusicCD(Convert.ToInt32(dtgMusicCD.CurrentRow.Cells[0].Value), txtMusicName.Text, Convert.ToDouble(txtMusicPrice.Text), cmbMusicType.SelectedItem.ToString(), txtMusicIssue.Text, dtgMusicCD.CurrentRow.Cells[5].Value.ToString(),txtMusicName.Text.Trim()+".wav",txtMusicSinger.Text);
            DataTable dataTable = new DataTable();
            DataTable = data.datagrid(dataTable, "musicCD");
            dtgMusicCD.DataSource = DataTable;
        }

        private void btnDeleteMusic_Click(object sender, EventArgs e)
        {
            data.DeletemusicCD(Convert.ToInt32(dtgMusicCD.CurrentRow.Cells[0].Value));
            data.DeleteProduct(Convert.ToInt32(dtgMusicCD.CurrentRow.Cells[0].Value));
            DataTable dataTable = new DataTable();
            dataTable = data.datagrid(dataTable, "musicCD");
            dtgMusicCD.DataSource = dataTable;
        }

        private void btnaddusers_Click(object sender, EventArgs e)
        {
            Customer newcustomer = null;
            if (txtAdress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                if (cbIsAdmin.Checked)
                {
                    newcustomer = new AdminUser(txtName.Text, txtAdress.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, Convert.ToInt32(dtgUsers.CurrentRow.Cells[2].Value));

                }

                else
                {
                    newcustomer = new Customer(txtName.Text, txtAdress.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, Convert.ToInt32(dtgUsers.CurrentRow.Cells[2].Value));
                }

                adminUser.addCustomer(newcustomer);
            }
        }
    }
}
