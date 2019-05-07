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
    public partial class signUp : Form
    {
        DataBase data = DataBase.database();
        public signUp()
        {
            InitializeComponent();
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';

        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPassword.Text != "" && txtSurname.Text != "" && txtUsername.Text != "" && txtEmail.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    try
                    {
                        Customer customer = new Customer(txtName.Text, txtAdress.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text,Customer.Customercount);
                        customer.SaveCustomer();
                       
                        MessageBox.Show("Successful", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Not Successful", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password dont match ", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Texts can not be empty!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            data.updateCustomerCount(Customer.Customercount);
            this.Hide();

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAdress_Click(object sender, EventArgs e)
        {

        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMail_Click(object sender, EventArgs e)
        {

        }

        private void lbPasswordSingUp_Click(object sender, EventArgs e)
        {

        }

        private void lbUsernameSignUp_Click(object sender, EventArgs e)
        {

        }

        private void lbSurname_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }
    }
}
