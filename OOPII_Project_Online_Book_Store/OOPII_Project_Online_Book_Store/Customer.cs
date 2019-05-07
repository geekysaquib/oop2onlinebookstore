using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\class Customer
* \brief Musteriler icin base bilgiler tutan siniftir.
*
*/
    public class Customer
    {
        static int customercount;
        private int customerID;
        private Boolean isAdmin;
        private String name;
        private String adress;
        private String email;
        private String username;
        private String password;
        private Boolean adminConfirm;

        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }

            set
            {
                isAdmin = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool AdminConfirm
        {
            get
            {
                return adminConfirm;
            }

            set
            {
                adminConfirm = value;
            }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public static int Customercount { get { return customercount; } set { customercount = value; } }

        public void printCustomerDetails() {
            userSettings userSettings = new userSettings(this);
            userSettings.ShowDialog();
            userSettings.Dispose();
        }
        public void SaveCustomer() {
            DataBase data = DataBase.database();
            data.newsign(this);

        }
        public void printCustomerPurchases()
        {
            BillingsForm billingsForm = new BillingsForm(this);
            billingsForm.ShowDialog();
        }
        public Customer(String name, String adress, String email, String username, String password, int id)
        {
            this.Name = name;
            this.Adress = adress;
            this.Email = email;
            this.Username = username;
            this.Password = password;

            if (Customercount == id)
            {
                Customercount++;
                this.CustomerID = id;
            }
            else
            {
                this.CustomerID = id;
            }
            IsAdmin = false;
            AdminConfirm = false;
        }
    }
}