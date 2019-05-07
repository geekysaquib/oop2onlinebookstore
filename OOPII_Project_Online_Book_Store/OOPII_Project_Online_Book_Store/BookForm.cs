using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPII_Project_Online_Book_Store
{
    public partial class BookForm : Form
    {
        Book book;

        public BookForm(Book book):base()
        {
            this.book = book;
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            txtIssue.Text= book.Issue;
            lblBookName.Text = book.Name;
            lblBookPrice.Text+= book.Price.ToString() + " TL"; 
            lblAuthor.Text += book.Author;
            lblISBN.Text += book.Isbn;
            lblpage.Text += book.Page;
            lblPublisher.Text += book.Publisher;
            lblType.Text += book.Type.ToString();
            
            try
            {
                picbxBookPicture.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\books\" + book.Picture);
            }
            catch
            {
                picbxBookPicture.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            picbxBookPicture.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ItemtoPurchase item = new ItemtoPurchase();
            item.Product = this.book;
            item.Quantity =Convert.ToInt32(nudPurchase.Value);
            MainForm.shoppingcart.addProduct(item);
            MessageBox.Show("ürün listeniize eklendi", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
