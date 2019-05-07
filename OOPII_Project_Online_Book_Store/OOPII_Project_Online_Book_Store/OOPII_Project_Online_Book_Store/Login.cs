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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
           
        }

        private void lbSıgnUp_Click(object sender, EventArgs e)
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

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            forgotPassword forgotPassword = new forgotPassword();
            forgotPassword.ShowDialog();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            MainForm mainMenu = new MainForm();
            this.Hide();
            mainMenu.ShowDialog();
            
        }
    }
}
