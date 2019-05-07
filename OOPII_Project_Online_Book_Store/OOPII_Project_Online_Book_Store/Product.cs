using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\class Product
* \brief Temel urun bilgilerinin belirlendigi urunlerin kalitildigi base class.
*/
    public abstract class Product
    {

        private String name;
        private int id;
        static int idcount = 1;
        private double price;
        private String picture;
        private String issue;
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

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
        }

        public Product(String name, int id, double price, string picture, String issue)
        {
            this.Name = name;

            Idcount++;
            this.Id = Idcount;
            this.Price = price;
            this.Picture = picture;
            this.issue = issue;
        }



        public abstract void printProperties();
    }
}
