/*\class Book
 * \brief 
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\enum BookType
 * \brief Icinde kitap turlerini barindirir.
 *
 */
    public enum BookType
    {
        Comics,
        Fantasy,
        Crime,
        Horror,

    }
    /*\class Book
 * \brief Product sinifindan kalitilan kitap sinifidir.Ozelliklerini barindirir.
 *
 */
    public class Book:Product
    {
        private String isbn;
        private String author;
        private String publisher;
        private int page;
        BookType type;
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        internal BookType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Book(BookType type,String isbn,String author,String publisher,String picture, int page, String name, int id, double price,String issue) :base( name,  id,  price,picture,issue)
        {
            this.Isbn = isbn;
            this.Author = author;
            this.Publisher = publisher;
            this.Page = page;
            this.Type = type;
        }
        
        public Book(string name, int id, double price, string picture,String issue) : base(name, id, price,picture,issue)
        {
        }

        public override void printProperties()
        {
            BookForm BookForm = new BookForm(this);
            BookForm.ShowDialog();
            BookForm.Dispose();
        }
        static public BookType GetBookType(String type)
        {
            switch (type)
            {
                case "Comics": return BookType.Comics;
                case "Fantasy": return BookType.Fantasy;
                case "Crime": return BookType.Crime;
                case "Horror": return BookType.Horror;
                default: return 0;
            }
        }

        
           
       
    }
}
