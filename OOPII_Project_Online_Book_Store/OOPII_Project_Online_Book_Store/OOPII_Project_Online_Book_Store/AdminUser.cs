using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    class AdminUser : Customer
    {
        public AdminUser(String name, String adress, String email, String username, String password) : base(name, adress, email, username, password)
        {
            IsAdmin = true;
            AdminConfirm = true;
        }
        public void addCustomer(Customer customer)
        {

            customer.AdminConfirm = true;
        }
        public Book addNewBook(String isbn, String author, String publisher, String cover_page_picture, int page, String name, int id, double price)
        {
            Book book = (Book)ProductFactory.CreateProduct(ProductName.Book, name, id, price);
            if (book is Book)
            {
                book.Isbn = isbn;
                book.Author = author;
                book.Publisher = publisher;
                book.Cover_page_picture = cover_page_picture;
                book.Page = page;


            }
            return book;

        }
        public Magazine addNewMagazine(MagazineType type, string issue, String name, int id, double price)
        {
            Magazine magazine = (Magazine)ProductFactory.CreateProduct(ProductName.Magazine, name, id, price);

            if (magazine is Magazine)
            {
                magazine.Type = type;
                magazine.Issue = issue;
            }
            return magazine;

        }
        public MusicCD addNewMusicCD(String singer, MusicCDType type, String name, int id, double price)
        {
            MusicCD musicCD = (MusicCD)ProductFactory.CreateProduct(ProductName.MusicCD, name, id, price);

            if (musicCD is MusicCD)
            {
                musicCD.Type = type;
                musicCD.Singer = singer;
            }
            return musicCD;

        }
    }
}
