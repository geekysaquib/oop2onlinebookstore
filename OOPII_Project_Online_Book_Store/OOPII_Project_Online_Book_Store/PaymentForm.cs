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
    public partial class PaymentForm : Form
    {
        ShoppingCart shopping = new ShoppingCart();
        public PaymentForm(ShoppingCart shopping)
        {
            this.shopping = shopping;
            
            InitializeComponent();
        }

        
    }
}
