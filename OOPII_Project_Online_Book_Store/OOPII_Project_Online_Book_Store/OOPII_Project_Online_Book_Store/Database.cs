using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OOPII_Project_Online_Book_Store
{
    class DataBase
    {
        private static string connectionString = " Data Source=den1.mssql7.gear.host;Initial Catalog = bookstore1; User Id=bookstore1; Password=admin123.";
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }


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

        public bool newsign(string user, string password, int id, string name, string adress, string email)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from customer where username ='" + user + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                command.ExecuteNonQuery();
                connection.Close();
                return false;

            }
            else
            {
                SqlCommand commandinsert = new SqlCommand("insert into customer (username,password,id,name,adress,email) values('" + user + "','" + password + "','" + id + "','" + name + "','" + adress + "','" + email + "')", connection);
                command.ExecuteNonQuery();
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
                if (reader["type"].ToString().Trim() == "Book")
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
            SqlCommand command = new SqlCommand("select * from Book", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (id == Convert.ToInt32(reader["id"]))
                {
                    book = new Book(reader["isbn"].ToString().Trim(), reader["author"].ToString().Trim(), reader["publisher"].ToString().Trim().Trim(), reader["picture"].ToString().Trim(), Convert.ToInt32(reader["page"]), reader["name"].ToString().Trim(), Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["price"]));
                    book.Id = Convert.ToInt32(reader["id"]);
                    if (book.Id > Product.Idcount)
                        Product.Idcount = book.Id;
                }
            }
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
                    magazine = new Magazine(type, reader["issue"].ToString(), reader["name"].ToString(), Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["price"]));
                    magazine.Id = Convert.ToInt32(reader["id"]);
                    if (magazine.Id > Product.Idcount)
                        Product.Idcount = magazine.Id;
                }
            }
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
                    musicCD = new MusicCD(reader["singer"].ToString().Trim(),type, reader["name"].ToString(), Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["price"]));
                    musicCD.Id = Convert.ToInt32(reader["id"]);
                    if (musicCD.Id > Product.Idcount)
                        Product.Idcount = musicCD.Id;
                }
            }
            return musicCD;
        }
    }
}
