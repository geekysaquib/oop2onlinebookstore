using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    class Book:Product
    {
        private String isbn;
        private String author;
        private String publisher;
        private int page;
        private String cover_page_picture;

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

        public string Cover_page_picture
        {
            get
            {
                return cover_page_picture;
            }

            set
            {
                cover_page_picture = value;
            }
        }

        public Book(String isbn,String author,String publisher,String cover_page_picture, int page, String name, int id, double price):base( name,  id,  price)
        {
            this.Isbn = isbn;
            this.Author = author;
            this.Publisher = publisher;
            this.Page = page;
            this.Cover_page_picture = cover_page_picture;
        }
        
        public Book(string name, int id, double price) : base(name, id, price)
        {
        }

        public override void printProperties()
        {
            
        }
    }
}
