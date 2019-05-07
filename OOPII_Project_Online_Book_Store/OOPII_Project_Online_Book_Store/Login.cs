using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPII_Project_Online_Book_Store
{
    public partial class loginForm : Form
    {
        DataBase data = DataBase.database();
        string username;
        public loginForm()
        {
            InitializeComponent();
           
        }

        private void remindMeWrite(string username)
        {
            StreamWriter sw = new StreamWriter("remindME.txt");
            sw.WriteLine(username);
            sw.Flush();
            sw.Close();
         }
        private string remindMeRead(string username)
        {
            string temp;
            StreamReader sr = new StreamReader("remindME.txt");
            temp = sr.ReadLine();
            sr.Close();
            return temp;
        }
        private void lblSıgnUp_Click(object sender, EventArgs e)
        {
            signUp signUp = new signUp();
            signUp.ShowDialog();
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

            forgotPassword forgotPassword = new forgotPassword();
            forgotPassword.ShowDialog();
            forgotPassword.Dispose();
        }


        private void loginForm_Load(object sender, EventArgs e)
        {
            if (remindMeRead(username)!="")
            {
                txtUsername.Text = remindMeRead(username);
                cbRemind.Checked = true;
            }
            else
            {
                cbRemind.Checked = false;
            }
 
            try
            {
                int Customercount = data.getcount("customer");
                Customercount++;
                Customer.Customercount = Customercount;
            }
            catch (Exception)
            {

                loginForm_Load(sender,e);
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbRemind.Checked)
            {
                remindMeWrite(txtUsername.Text);
            }
            else
            {
                remindMeWrite("");
            }
            
            if (data.password_control(txtUsername.Text, txtPassword.Text))
            {
                Customer customer = data.GetCustomerByUsername(txtUsername.Text);
                MainForm mainMenu = new MainForm(customer);
                this.Hide();
                mainMenu.ShowDialog();
                mainMenu.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("This user not exist.Username or password not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
