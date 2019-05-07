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
    
    public partial class userSettings : Form
    {
        Customer customer;
        DataBase data = DataBase.database();
        public userSettings(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void userSettings_Load(object sender, EventArgs e)
        {
            customer=data.GetCustomerbyID(customer.CustomerID);
            txtName.Text = customer.Name;
            txtEmail.Text = customer.Email;
            txtAdress.Text = customer.Adress;
            txtUsername.Text = customer.Username;
            txtPassword.Text = customer.Password;
            
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            Customer newc = new Customer(txtName.Text, txtAdress.Text, customer.Email, txtUsername.Text, txtPassword.Text, customer.CustomerID);
            if (txtAdress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                if (customer.Username != newc.Username)
                {
                    if (data.usernameControl(newc))
                    {
                        data.updateCustomer(customer.CustomerID, newc.Name, newc.Username, newc.Password, newc.Email, newc.Adress, customer.IsAdmin.ToString());
                        MessageBox.Show("Update Succeed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    data.updateCustomer(customer.CustomerID, newc.Name, newc.Username, newc.Password, newc.Email, newc.Adress, customer.IsAdmin.ToString());
                    MessageBox.Show("Update Succeed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Texts can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
