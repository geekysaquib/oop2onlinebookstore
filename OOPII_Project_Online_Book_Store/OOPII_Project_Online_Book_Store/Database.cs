using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace OOPII_Project_Online_Book_Store
{
    /*\class DataBase
* \brief Veritabaniyla iletisime gecen siniftir.
*
*/
    class DataBase
    {
        private static DataBase dataBase;
        private static string connectionString = " Data Source=den1.mssql7.gear.host;Initial Catalog = bookstore1; User Id=bookstore1; Password=admin123.";
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }


        }
        public static DataBase database()
        {
            if (dataBase == null)
            {
                dataBase = new DataBase();
            }
            return dataBase;
        }
        public int getcount(string countername)
        {
            int counter = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from info where countername ='" + countername + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                counter = Convert.ToInt32(dataReader["counter"]);
            }
            connection.Close(); 
            return counter;
            
        }
        public bool password_control(string user, string password)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where username ='" + user + "'and password ='" + password + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }
        public bool newsign(Customer customer)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where username ='" + customer.Username + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                command.ExecuteNonQuery();
                connection.Close();
                return false;

            }
            else
            {
                dataReader.Close();
                
                string sorgu = "Insert into customer (username,password,id,name,email,adress,isadmin) values (@username,@password,@id,@name,@email,@adress,@isadmin)";
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@username", customer.Username);
                komut.Parameters.AddWithValue("@password", customer.Password);
                komut.Parameters.AddWithValue("@id", customer.CustomerID);
                komut.Parameters.AddWithValue("@name", customer.Name);
                komut.Parameters.AddWithValue("@email", customer.Email);
                komut.Parameters.AddWithValue("@adress", customer.Adress);
                komut.Parameters.AddWithValue("@isadmin", customer.IsAdmin.ToString());
                komut.ExecuteNonQuery();
                connection.Close();
                return true;
            }


        }
        public bool email_control(string email)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where email ='" + email + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                command.ExecuteNonQuery();
                connection.Close();
                return false;
            }
            else
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }

        }
        public void GetProduct(List<Product> productList)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from product", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["type"].ToString().Trim() == "book")
                {

                    Book book = GetBook(Convert.ToInt32(reader["id"]));
                    productList.Add(book);


                }
                else if (reader["type"].ToString().Trim() == "musicCD")
                {
                    MusicCD musicCD = GetMusicCD(Convert.ToInt32(reader["id"]));
                    productList.Add(musicCD);
                }
                else if (reader["type"].ToString().Trim() == "magazine")
                {
                    Magazine magazine = GetMagazine(Convert.ToInt32(reader["id"]));
                    productList.Add(magazine);
                }
                else
                {
                    //invalid type.
                }


            }
            connection.Close();
        }
        public Book GetBook(int id)
        {
            Book book = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from book", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (id == Convert.ToInt32(reader["id"]))
                {
                    BookType type = Book.GetBookType(reader["type"].ToString().Trim());
                    book = new Book(type, reader["isbn"].ToString().Trim(), reader["author"].ToString().Trim(), reader["publisher"].ToString().Trim().Trim(), reader["picture"].ToString().Trim(), Convert.ToInt32(reader["page"]), reader["name"].ToString().Trim(), Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["price"]), reader["issue"].ToString());
                    book.Id = Convert.ToInt32(reader["id"]);
                    if (book.Id > Product.Idcount)
                        Product.Idcount = book.Id;
                }
            }
            connection.Close();
            return book;
        }
        public Magazine GetMagazine(int id)
        {
            Magazine magazine = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from magazine", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (id == Convert.ToInt32(reader["id"]))
                {
                    MagazineType type = Magazine.getmagazine(reader["type"].ToString().Trim());
                    magazine = new Magazine(type, reader["issue"].ToString(), reader["name"].ToString(), Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["price"]), reader["picture"].ToString());
                    magazine.Id = Convert.ToInt32(reader["id"]);
                    if (magazine.Id > Product.Idcount)
                        Product.Idcount = magazine.Id;
                }
            }
            connection.Close();
            return magazine;
        }
        public MusicCD GetMusicCD(int id)
        {
            MusicCD musicCD = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from musicCD", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (id == Convert.ToInt32(reader["id"]))
                {
                    MusicCDType type = MusicCD.getMusicCDType(reader["type"].ToString().Trim());
                    musicCD = new MusicCD(reader["singer"].ToString().Trim(), type, reader["name"].ToString(), Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["price"]), reader["demo"].ToString().Trim(), reader["picture"].ToString(), reader["issue"].ToString());
                    musicCD.Id = Convert.ToInt32(reader["id"]);
                    if (musicCD.Id > Product.Idcount)
                        Product.Idcount = musicCD.Id;
                }
            }
            connection.Close();
            return musicCD;
        }
        public Customer GetCustomer(string email)
        {
            Customer customer = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (email == reader["email"].ToString().Trim())
                {
                    customer = new Customer(reader["name"].ToString().Trim(), reader["adress"].ToString().Trim(),
                        reader["email"].ToString().Trim(), reader["username"].ToString().Trim(), reader["password"].ToString().Trim(), Convert.ToInt32(reader["id"]));


                }

            }
            connection.Close();
            return customer;
        }
        public Customer GetCustomerByUsername(string username)
        {
            Customer customer = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where username ='" + username + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["isadmin"]))
                {
                    customer = new AdminUser(reader["name"].ToString().Trim(), reader["adress"].ToString().Trim(),
                        reader["email"].ToString().Trim(), reader["username"].ToString().Trim(), reader["password"].ToString().Trim(), Convert.ToInt32(reader["id"]));
                }

                else if (username == reader["username"].ToString().Trim())
                {
                    customer = new Customer(reader["name"].ToString().Trim(), reader["adress"].ToString().Trim(),
                        reader["email"].ToString().Trim(), reader["username"].ToString().Trim(), reader["password"].ToString().Trim(), Convert.ToInt32(reader["id"]));


                }

            }
            connection.Close();
            return customer;
        }
        public Customer GetCustomerbyID(int id)
        {
            Customer customer = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where id ='" + id + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["isadmin"]))
                {
                    customer = new AdminUser(reader["name"].ToString().Trim(), reader["adress"].ToString().Trim(),
                        reader["email"].ToString().Trim(), reader["username"].ToString().Trim(), reader["password"].ToString().Trim(), Convert.ToInt32(reader["id"]));
                }

                else if (id == Convert.ToInt32(reader["id"]))
                {
                    customer = new Customer(reader["name"].ToString().Trim(), reader["adress"].ToString().Trim(),
                        reader["email"].ToString().Trim(), reader["username"].ToString().Trim(), reader["password"].ToString().Trim(), Convert.ToInt32(reader["id"]));


                }

            }
            connection.Close();
            return customer;
        }
        public void DeleteBook(int id)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from book where id =(" + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void Deletemagazine(int id)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from magazine where id =(" + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void DeletemusicCD(int id)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from musicCD where id =(" + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void addBook(Book book)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string sorgu = "Insert into book (id,isbn,name,price,author,publisher,page,type,picture,issue) values (@id,@isbn,@name,@price,@author,@publisher,@page,@type,@picture,@issue)";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@id", book.Id);
            komut.Parameters.AddWithValue("@isbn",book.Isbn );
            komut.Parameters.AddWithValue("@name", book.Name);
            komut.Parameters.AddWithValue("@price", book.Price);
            komut.Parameters.AddWithValue("@author", book.Author);
            komut.Parameters.AddWithValue("@publisher", book.Publisher);
            komut.Parameters.AddWithValue("@page", book.Page);
            komut.Parameters.AddWithValue("@type", book.Type.ToString());
            komut.Parameters.AddWithValue("@picture", book.Picture);
            komut.Parameters.AddWithValue("@issue", book.Issue);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            addProduct("book", book.Id);
            updateProductCount(book.Id);

        }
        public void addMagazine(Magazine magazine)
        {

            
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sorgu = "Insert into magazine (id,name,price,type,picture,issue) values (@id,@name,@price,@type,@picture,@issue)";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@id", magazine.Id);
            komut.Parameters.AddWithValue("@name", magazine.Name);
            komut.Parameters.AddWithValue("@price", magazine.Price);
            komut.Parameters.AddWithValue("@type", magazine.Type.ToString());
            komut.Parameters.AddWithValue("@picture", magazine.Picture);
            komut.Parameters.AddWithValue("@issue", magazine.Issue);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            addProduct("magazine", magazine.Id);
            updateProductCount(magazine.Id);
        }
        public void addmusicCD(MusicCD musicCD)
        {

            
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sorgu = "Insert into musicCD (id,name,price,type,picture,issue,singer,demo) values (@id,@name,@price,@type,@picture,@issue,@singer,@demo)";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@id", musicCD.Id);
            komut.Parameters.AddWithValue("@singer", musicCD.Singer);
            komut.Parameters.AddWithValue("@name", musicCD.Name);
            komut.Parameters.AddWithValue("@price", musicCD.Price);
            komut.Parameters.AddWithValue("@demo", musicCD.Name+".wav");
            komut.Parameters.AddWithValue("@type", musicCD.Type.ToString());
            komut.Parameters.AddWithValue("@picture", musicCD.Picture);
            komut.Parameters.AddWithValue("@issue", musicCD.Issue);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            addProduct("musicCD", musicCD.Id);
            updateProductCount(musicCD.Id);

        }
        public void addProduct(string type,int id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("insert into product(id,type) values('" +id +"','" +type + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteCustomer(int id)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From customer where id =(" + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        public bool usernameControl(Customer customer)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where username ='" + customer.Username + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                //command.ExecuteNonQuery();
                connection.Close();
                return false;

            }
            else
            {
                //command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
        }
        public void updateCustomerCount(int count)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update info set counter='" + count + "'where countername='" + "customer" + "'";
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void updateProductCount(int count)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update info set counter='" + count + "'where countername='" + "product" + "'";
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void updateCustomer(int id, string name, string username, string password, string email, string adress, string isadmin)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update customer set name=@name,username=@username,password=@password,email=@email,adress=@adress,isadmin=@isadmin where id=@id";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@name", name);
            komut.Parameters.AddWithValue("@username", username);
            komut.Parameters.AddWithValue("@password", password);
            komut.Parameters.AddWithValue("@email", email);
            komut.Parameters.AddWithValue("@adress", adress);
            komut.Parameters.AddWithValue("@isadmin", isadmin);
            komut.Parameters.AddWithValue("@id", id);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            connection.Close();
            MessageBox.Show("Update success.");

        }
        public void updateBook(int id, string name, string isbn, string author, string publisher, double price, int page, string type, string issue, string picture)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update book set name=@name,isbn=@isbn,picture=@picture,author=@author,publisher=@publisher,price=@price,page=@page,type=@type,issue=@issue where id=@id";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@name", name);
            komut.Parameters.AddWithValue("@isbn", isbn);
            komut.Parameters.AddWithValue("@author", author);
            komut.Parameters.AddWithValue("@publisher", publisher);
            komut.Parameters.AddWithValue("@price", price);
            komut.Parameters.AddWithValue("@page", page);
            komut.Parameters.AddWithValue("@type", type);
            komut.Parameters.AddWithValue("@issue", issue);
            komut.Parameters.AddWithValue("@picture", picture);
            komut.Parameters.AddWithValue("@id", id);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            connection.Close();
            MessageBox.Show("Update success.");
        }
        public void updatemagazine(int id, string name, double price, string type, string issue, string picture)
        {

            
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update magazine set name=@name,price=@price,picture=@picture,type=@type,issue=@issue where id=@id";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@name", name);
            komut.Parameters.AddWithValue("@price", price);
            komut.Parameters.AddWithValue("@picture", picture);
            komut.Parameters.AddWithValue("@type", type);
            komut.Parameters.AddWithValue("@issue", issue);
            komut.Parameters.AddWithValue("@id", id);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            connection.Close();
            MessageBox.Show("Update success.");
        }
        public void updatemusicCD(int id, string name, double price, string type, string issue, string picture, string demo, string singer)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update musicCD set name=@name,price=@price,singer=@singer,demo=@demo,picture=@picture,type=@type,issue=@issue where id=@id";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@name", name);
            komut.Parameters.AddWithValue("@price", price);
            komut.Parameters.AddWithValue("@picture", picture);
            komut.Parameters.AddWithValue("@type", type);
            komut.Parameters.AddWithValue("@issue", issue);
            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@singer", singer);
            komut.Parameters.AddWithValue("@demo", demo);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            connection.Close();
            MessageBox.Show("Update success.");

        }
        public DataTable datagrid(DataTable dt, string type)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            
                connection.Open();
           
                

            string kayit = "SELECT * from "+type;
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        public void DeleteProduct(int id)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from product where id =(" + id + ")", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void addOrder(int id,string orders,string quantity,string cancel,double price,string type,DateTime date)
        {


            SqlConnection connection = new SqlConnection(ConnectionString);
            string sorgu = "Insert into orders (id,orders,quantity,iscancel,price,type,date) values (@id,@orders,@quantity,@iscancel,@price,@type,@date)";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@orders",orders );
            komut.Parameters.AddWithValue("@quantity", quantity);
            komut.Parameters.AddWithValue("@iscancel", cancel);
            komut.Parameters.AddWithValue("@price", price);
            komut.Parameters.AddWithValue("@type", type);
            komut.Parameters.AddWithValue("@date", date);

            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();

        }
        public DataTable datagridOrder(DataTable dt, int id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();



            string kayit = "SELECT * from orders where id="+id+" and iscancel= 0";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        public void DeleteOrder(DateTime dt,int id)
        {


            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update orders set iscancel=@iscancel where date=@date and id=@id";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, connection);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@iscancel", "1");
            komut.Parameters.AddWithValue("@date", dt);
            komut.Parameters.AddWithValue("@id", id);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            connection.Close();
            MessageBox.Show("Update success.");
        }
    }
}
