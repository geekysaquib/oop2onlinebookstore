using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    class ItemtoPurchase
    {
        private Product product;
        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        internal Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }
    }
}
