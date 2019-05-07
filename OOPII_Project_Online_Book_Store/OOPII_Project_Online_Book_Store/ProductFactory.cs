using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{

    /*\enum ProductNames
* \brief Urunlerin tipini belirlemeye yardimci enum.
*/
    enum ProductNames
    {
        All,
        Magazine,
        MusicCD,
        Book,
    }
    /*\class ProductFactory
* \brief Parametreye gore urun olusturan class
*/
    class ProductFactory
    {

        public static Product CreateProduct(ProductNames ProductName, String name, int id, double price,String picture,String issue)
        {
            Product product = null;
            switch (ProductName)
            {
                case ProductNames.Magazine:
                    product = new Magazine(name,id,price,picture,issue);
                    break;
                case ProductNames.MusicCD:
                    product = new MusicCD(name, id, price,picture, issue);
                    break;
                case ProductNames.Book:
                    product = new Book(name, id, price, picture,issue);
                    break;
                default:
                    break;
            }

            return product;
        }
    }
}
