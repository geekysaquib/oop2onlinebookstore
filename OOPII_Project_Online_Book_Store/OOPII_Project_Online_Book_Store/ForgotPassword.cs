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
    public partial class forgotPassword : Form
    {
        DataBase data = DataBase.database();
        Customer customer = null;
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void pbSendPassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == txtEmailConfirm.Text)
            {
                try
                {
                    customer = data.GetCustomer(txtEmail.Text);
                    EmailSender.SendEmail(customer);
                    MessageBox.Show("Your Password " + customer.Email + " sent to your mail adress", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("The user not exist have this email", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("E mail is not verified", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
