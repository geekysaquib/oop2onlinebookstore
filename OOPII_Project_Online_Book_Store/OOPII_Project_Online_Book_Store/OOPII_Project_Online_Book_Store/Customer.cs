using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    class Customer
    {
        static int customercount=0;
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

        public void printCustomerDetails() { }
        public void SaveCustomer() { }
        public void printCustomerPurchases() { }
        public Customer(String name, String adress, String email, String username, String password)
        {
            this.Name = name;
            this.Adress = adress;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.customerID = customercount;
            customercount++;
            IsAdmin = false;
            AdminConfirm = false;
    }
    }
}
