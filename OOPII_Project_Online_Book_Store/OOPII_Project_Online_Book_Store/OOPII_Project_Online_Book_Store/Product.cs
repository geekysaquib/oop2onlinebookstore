using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    abstract class Product
    {
       
        private String name;
        private int id;
        static int idcount = 1;
        private double price;

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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public static int Idcount { get { return idcount; } set { idcount = value; } }


        public Product(String name, int id, double price)
        {
            this.Name = name;
            this.Id = Idcount;
            Idcount++;
            this.Price = price;

        }
        public abstract void printProperties();
    }
}
