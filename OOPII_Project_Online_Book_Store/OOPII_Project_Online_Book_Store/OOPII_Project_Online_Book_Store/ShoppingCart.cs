using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    enum PaymentType
    {
        cash,
        creditcard,
    }
    class ShoppingCart
    {
        private int customerID;
        private List<ItemtoPurchase> ItemstoPurchase;
        private double paymentAmount;
        PaymentType paymentType;
        public void printProducts() { }
        public void addProduct(ItemtoPurchase itemtopurchase)
        {
            ItemstoPurchase.Add(itemtopurchase);
        }
        public void deleteProduct(ItemtoPurchase itemtopurchase)
        {
            ItemstoPurchase.Remove(itemtopurchase);
        }
        public void placeOrder() { }
        public void cancelOrder() { }
        public void sendInvoidcebyEmail() { }

    }
}
