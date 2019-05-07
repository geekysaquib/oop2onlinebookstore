/*\class AdminUser
 * \brief Customer sinifindan kalitilan bir siniftir.Kullanicinin urunleri ve musterileri, degistirip, ekleme ve silme islemleri yapan siniftir.
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    public class AdminUser : Customer
    {
        DataBase data = DataBase.database();

        public AdminUser(string name, string adress, string email, string username, string password, int id) : base(name, adress, email, username, password, id)
        {
            IsAdmin = true;
            AdminConfirm = true;
        }

        public void addCustomer(Customer customer)
        {

            data.newsign(customer);
        }
        public void addNewBook(String isbn, String author, String publisher, String picture, int page, String name, int id, double price,String issue,BookType type)
        {
            Book book = (Book)ProductFactory.CreateProduct(ProductNames.Book, name, id, price,picture,issue);
            if (book is Book)
            {
                book.Isbn = isbn;
                book.Author = author;
                book.Publisher = publisher;
                book.Type = type;
                book.Page = page;


            }
            data.addBook(book);

        }
        public void addNewMagazine(MagazineType type, string issue, String name, int id, double price,String picture)
        {
            Magazine magazine = (Magazine)ProductFactory.CreateProduct(ProductNames.Magazine, name, id, price,picture, issue);

            if (magazine is Magazine)
            {
                magazine.Type = type;
               
            }
            data.addMagazine(magazine);

        }
        public void addNewMusicCD(String singer, MusicCDType type, String name, int id, double price, String picture, String issue)
        {
            MusicCD musicCD = (MusicCD)ProductFactory.CreateProduct(ProductNames.MusicCD, name, id, price,picture,issue);

            if (musicCD is MusicCD)
            {
                musicCD.Type = type;
                musicCD.Singer = singer;
            }
            data.addmusicCD(musicCD);

        }
    }
}
