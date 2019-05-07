using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\enum PaymentType
    * \brief Icinde Payment turlerini barindirir.
    *
    */
    public enum PaymentType
    {
        Unassigned,
        Cash,
        Creditcard,
    }
    /*\class ShoppingCart
* \brief Musterinin alinmaya hazir urunlerini barindiran ve buna bagli fonksiyonlari gercekleyen class
*/
    public class ShoppingCart
    {
        DataBase data = DataBase.database();
        private int customerID;
        private List<ItemtoPurchase> ItemstoPurchase = new List<ItemtoPurchase>();
        private double paymentAmount = 0.0;
        PaymentType paymentType;

        public int CustomerID { get { return customerID; } set { customerID = value; } }
        public List<ItemtoPurchase> itemstoPurchase { get { return ItemstoPurchase; } set { ItemstoPurchase = value; } }

        public double PaymentAmount { get { return paymentAmount; } set { paymentAmount = value; } }

        public void printProducts() {
            ShoppingCartForm shoppingcartform = new ShoppingCartForm(this);
            shoppingcartform.ShowDialog();
            shoppingcartform.Dispose();
        }
        public void addProduct(ItemtoPurchase itemtopurchase)
        {
            PaymentAmount += itemtopurchase.Product.Price * itemtopurchase.Quantity;
            itemstoPurchase.Add(itemtopurchase);
        }
        public void deleteProduct(ItemtoPurchase itemtopurchase)
        {
            PaymentAmount -= itemtopurchase.Product.Price * itemtopurchase.Quantity;
            itemstoPurchase.Remove(itemtopurchase);
        }
        public void placeOrder(PaymentType PaymentType)
        {
            string orders = "";
            string quantity = "";
            foreach (ItemtoPurchase item in itemstoPurchase)
            {
                orders += item.Product.Name+ ",";
                quantity += item.Quantity.ToString() + ",";
            }
            this.paymentType = PaymentType;

            string temp = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            DateTime dt = DateTime.Parse(temp);
            data.addOrder(this.customerID, orders, quantity, "0", this.paymentAmount, this.paymentType.ToString(),dt);
            

           
            sendInvoidcebyEmail();
        }
        public void cancelOrder()
        {
            paymentType = PaymentType.Unassigned;
            paymentAmount = 0.0;
            itemstoPurchase.Clear();

        }
        public void sendInvoidcebyEmail()
        {

            EmailSender.SendEmail(data.GetCustomerbyID(this.CustomerID), this);

        }
        public static PaymentType GetPaymentType(string Type)
        {
            switch (Type)
            {
                case "Cash": return PaymentType.Cash;
                case "CreditCard": return PaymentType.Creditcard;
                default: return PaymentType.Unassigned;

            }
        }
    }
}
