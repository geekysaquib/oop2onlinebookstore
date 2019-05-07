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
    public partial class ShoppingCartForm : Form
    {
        ShoppingCart shoppingCart;
       
        
        double price=0;
        public ShoppingCartForm(ShoppingCart shoppingCart)
        {

            this.shoppingCart = shoppingCart;
            InitializeComponent();
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {

            fillPanel();
        }
        public void fillPanel()
        {
            
            flPanelShopping.Controls.Clear();
            if (shoppingCart.itemstoPurchase.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add something.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            foreach (ItemtoPurchase item in shoppingCart.itemstoPurchase)
            {
                
                ShoppingCartPanel cartPanel = new ShoppingCartPanel(item, this);
                flPanelShopping.Controls.Add(cartPanel);
            }
           
            MainForm.shoppingcart.PaymentAmount = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order information sended to your mail adress", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string paymenttype="";
            if (rbCash.Checked)
                paymenttype = "Cash";
            else
                paymenttype = "CreditCard";
            shoppingCart.placeOrder(ShoppingCart.GetPaymentType(paymenttype));
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            pnlPaymentCard.Visible = true;
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            pnlPaymentCard.Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            
            double price = 0.0;
            tabControl.SelectedIndex = 1;
            foreach (ItemtoPurchase item in shoppingCart.itemstoPurchase)
            {
                price += item.Quantity * item.Product.Price;
            }
            shoppingCart.PaymentAmount = price;
            lblPrice.Text = "";
            lblPrice.Text += price.ToString()+" TL";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
