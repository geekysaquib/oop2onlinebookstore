using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    enum ProductName
    {
        Magazine,
        MusicCD,
        Book,
    }
    class ProductFactory
    {

        public static Product CreateProduct(ProductName ProductName, String name, int id, double price)
        {
            Product product = null;
            switch (ProductName)
            {
                case ProductName.Magazine:
                    product = new Magazine(name,id,price);
                    break;
                case ProductName.MusicCD:
                    product = new MusicCD(name, id, price);
                    break;
                case ProductName.Book:
                    product = new Book(name, id, price);
                    break;
                default:
                    break;
            }

            return product;
        }
    }
}
