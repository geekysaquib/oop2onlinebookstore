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
    public partial class MainForm : Form
    {
        Customer customer;
        public static ShoppingCart shoppingcart;
        public MainForm(Customer customer)
        {
            this.customer = customer;
            shoppingcart = new ShoppingCart();
            shoppingcart.CustomerID = customer.CustomerID;
            InitializeComponent();
        }
        
        List<Product> products = new List<Product>();
        List<Product> currentProducts = new List<Product>();
        DataBase Data = DataBase.database();

        private void mainMenu_Load(object sender, EventArgs e)
        {
            shoppingcart.CustomerID = customer.CustomerID;
            ProductPanelCreator panelcreator = new ProductPanelCreator();
            Data.GetProduct(products);
            if (customer.IsAdmin)
            {
                btnAdminInterface.Visible = true;
            }
            if (customer.IsAdmin == false)
            {
                btnAdminInterface.Visible = false;
            }
            cmbProductType.SelectedIndex = 0;
            lblusername.Text = customer.Username;
            lblemail.Text = customer.Email;
            lblID.Text = customer.CustomerID.ToString();




        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            cmbCategory.Items.Clear();

            switch (cmbProductType.SelectedIndex)
            {
                case 0:

                    LoadProduct(ProductNames.All, "All");
                    cmbCategory.Hide();
                    lblCategory.Hide();

                    break;
                case 1:

                    cmbCategory.Show();
                    lblCategory.Show();

                    string[] bookCategory = new string[] { "All Books", "Comics", "Fantasy", "Crime", "Horror" };
                    cmbCategory.Items.AddRange(bookCategory);
                    cmbCategory.SelectedIndex = 0;
                    break;
                case 2:
                    cmbCategory.Show();
                    lblCategory.Show();

                    string[] magazineCategory = new string[] { "All Magazines", "Science", "News", "Sport", "Computer", "Technology" };
                    cmbCategory.Items.AddRange(magazineCategory);
                    cmbCategory.SelectedIndex = 0;
                    break;
                case 3:
                    cmbCategory.Show();
                    lblCategory.Show();

                    string[] musicCategory = new string[] { "All MusicCDs", "Rap", "Rock", "Pop", "Metal" };
                    cmbCategory.Items.AddRange(musicCategory);
                    cmbCategory.SelectedIndex = 0;
                    break;
                default:
                    break;

            }

        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            flPanel.Controls.Clear();
            currentProducts.Clear();


            if (cmbProductType.SelectedIndex == 1)
            {
                switch (cmbCategory.SelectedIndex)
                {
                    case 0:
                        LoadProduct(ProductNames.Book, "All");
                        break;
                    case 1:
                        LoadProduct(ProductNames.Book, "Comics");
                        break;
                    case 2:
                        LoadProduct(ProductNames.Book, "Fantasy");
                        break;
                    case 3:
                        LoadProduct(ProductNames.Book, "Crime");
                        break;
                    case 4:
                        LoadProduct(ProductNames.Book, "Horror");
                        break;

                    default:
                        break;
                }
            }
            else if (cmbProductType.SelectedIndex == 2)
            {
                switch (cmbCategory.SelectedIndex)
                {
                    case 0:
                        LoadProduct(ProductNames.Magazine, "All");
                        break;
                    case 1:
                        LoadProduct(ProductNames.Magazine, "Science");
                        break;
                    case 2:
                        LoadProduct(ProductNames.Magazine, "News");
                        break;
                    case 3:
                        LoadProduct(ProductNames.Magazine, "Sport");
                        break;
                    case 4:
                        LoadProduct(ProductNames.Magazine, "Computer");
                        break;
                    case 5:
                        LoadProduct(ProductNames.Magazine, "Technology");
                        break;
                    default:
                        break;
                }

            }
            else if (cmbProductType.SelectedIndex == 3)
            {

                switch (cmbCategory.SelectedIndex)
                {
                    case 0:
                        LoadProduct(ProductNames.MusicCD, "All");
                        break;
                    case 1:
                        LoadProduct(ProductNames.MusicCD, "Rap");
                        break;
                    case 2:
                        LoadProduct(ProductNames.MusicCD, "Rock");
                        break;
                    case 3:
                        LoadProduct(ProductNames.MusicCD, "Pop");
                        break;
                    case 4:
                        LoadProduct(ProductNames.MusicCD, "Metal");
                        break;

                    default:
                        break;
                }


            }
        }
        private void LoadProduct(ProductNames ProductName, string category)
        {
            switch (ProductName)
            {
                case ProductNames.All:
                    foreach (Product item in products)
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                    break;
                case ProductNames.Magazine:
                    if (category == "All")
                    {
                        foreach (Product item in products)
                        {
                            if (item is Magazine)
                            {
                                currentProducts.Add(item);
                                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                                flPanel.Controls.Add(productPanel);

                            }
                        }
                    }
                    else
                        LoadMagazine(category);
                    break;
                case ProductNames.MusicCD:
                    if (category == "All")
                    {
                        foreach (Product item in products)
                        {
                            if (item is MusicCD)
                            {
                                currentProducts.Add(item);
                                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                                flPanel.Controls.Add(productPanel);
                            }
                        }
                    }
                    else
                        LoadMusicCD(category);
                    break;
                case ProductNames.Book:
                    if (category == "All")
                    {
                        foreach (Product item in products)
                        {
                            if (item is Book)
                            {
                                currentProducts.Add(item);
                                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                                flPanel.Controls.Add(productPanel);
                            }
                        }
                    }
                    else
                        LoadBooks(category);
                    break;
                default:
                    break;
            }
        }
        void LoadMagazine(String category)
        {

            foreach (Product item in products)
            {
                if (item is Magazine)
                {
                    Magazine magazine = (Magazine)item;
                    if (category == magazine.Type.ToString())
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                }
            }
        }
        void LoadMusicCD(String category)
        {
            foreach (Product item in products)
            {
                if (item is MusicCD)
                {
                    MusicCD musicCD = (MusicCD)item;

                    if (category == musicCD.Type.ToString())
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                }
            }
        }
        void LoadBooks(String category)
        {
            foreach (Product item in products)
            {
                if (item is Book)
                {
                    Book book = (Book)item;
                    if (category == book.Type.ToString())
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                }
            }
        }

        private void pnlProductShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            shoppingcart.printProducts();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            customer.printCustomerDetails();
            
        }

        private void btnAdminInterface_Click(object sender, EventArgs e)
        {
            AdminInterfaceForm adminInterface = new AdminInterfaceForm((AdminUser)customer);
            adminInterface.ShowDialog();
            adminInterface.Dispose();
            products.Clear();
            Data.GetProduct(products);

            cmbProductType_SelectedIndexChanged(sender, e);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Dispose();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
            
        }

        private void btnBillings_Click(object sender, EventArgs e)
        {
            customer.printCustomerPurchases();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillingsForm billingsForm = new BillingsForm(customer);
            billingsForm.ShowDialog();
        }
    }


}

