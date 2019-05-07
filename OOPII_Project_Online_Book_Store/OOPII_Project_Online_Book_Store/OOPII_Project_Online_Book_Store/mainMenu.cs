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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<Product> products = new List<Product>();
        DataBase Data = new DataBase();
        private void mainMenu_Load(object sender, EventArgs e)
        {
            Data.GetProduct(products);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sa");
        }
    }
}
