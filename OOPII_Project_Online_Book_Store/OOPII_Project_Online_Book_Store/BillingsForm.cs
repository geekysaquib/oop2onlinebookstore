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
    public partial class BillingsForm : Form
    {
        DataBase data = DataBase.database();
        Customer customer = null;
        public BillingsForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            
        }
        
        private void BillingsForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = data.datagridOrder(dataTable,customer.CustomerID );
            dtgorder.DataSource = dataTable;

        }

        private void dtgorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbilling.Clear();
            string[] Parcalanmisdesen;
            string mydesen = dtgorder.CurrentRow.Cells[1].Value.ToString();
            Parcalanmisdesen = mydesen.Split(',');
            string[] Parcalanmisdesen2;
            string mydesen2 = dtgorder.CurrentRow.Cells[2].Value.ToString();
            Parcalanmisdesen2 = mydesen2.Split(',');
            string text = "";
            for(int i = 0; i < Parcalanmisdesen.Length-1; i++)
            {
                text += Parcalanmisdesen[i].Trim() + " adlı üründen " + Parcalanmisdesen2[i].Trim() + " adet sipariş verilmiştir. \n";
            }
            text += "toplam tutar " + dtgorder.CurrentRow.Cells[4].Value.ToString() + " TL dir.\n";
            text += "tarih: " + dtgorder.CurrentRow.Cells[6].Value.ToString() + "\n";
            text += "işletme: OnlineBookStore.";
            txtbilling.Text = text;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = dtgorder.CurrentRow.Cells[6].Value.ToString();
                DateTime dt = DateTime.Parse(temp);
                data.DeleteOrder(dt, customer.CustomerID);
                this.BillingsForm_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("there is no order to cancel", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            EmailSender.SendEmail(customer, txtbilling.Text);
        }
    }
}
