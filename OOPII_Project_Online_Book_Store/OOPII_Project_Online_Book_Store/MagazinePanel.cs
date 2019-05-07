using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOPII_Project_Online_Book_Store
{
    /*\class MagazinePanel
* \brief ProductPanel sinifindan kalitilan MagazinePanel sinifidir.Ozelliklerini barindirir.
*/
    class MagazinePanel : ProductPanel
    {
        public Label NameOfMagazine;
        public Label Issue;
        public Label Price;

        public Magazine magazine;
        public MagazinePanel(Magazine item)
        {
            magazine = item;
            this.BackColor = Color.Transparent;
            this.Size = new Size(400, 200);
            this.BorderStyle = BorderStyle.FixedSingle;

            
            picBox = new PictureBox();
            picBox.Size = new Size(105, 160);
            try
            {
                picBox.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\magazines\" + item.Picture);
            }
            catch
            {
                picBox.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            picBox.BackgroundImageLayout = ImageLayout.Zoom;

            show = new Button();
            show.Size = new Size(64, 64);
            show.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\show.png");
            show.BackgroundImageLayout = ImageLayout.Zoom;
            show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            show.FlatAppearance.BorderSize = 0;
            show.BackColor = Color.Transparent;
            show.FlatAppearance.MouseDownBackColor = Color.Transparent;
            show.FlatAppearance.MouseOverBackColor = Color.Transparent;
            show.Cursor = Cursors.Hand;
            show.Click += new EventHandler(showClick);

            purchase = new Button();
            purchase.Size = new Size(64, 64);
            purchase.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\purchase.png");
            purchase.BackgroundImageLayout = ImageLayout.Zoom;
            purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            purchase.FlatAppearance.BorderSize = 0;
            purchase.BackColor = Color.Transparent;
            purchase.FlatAppearance.MouseDownBackColor = Color.Transparent;
            purchase.FlatAppearance.MouseOverBackColor = Color.Transparent;
            purchase.Cursor = Cursors.Hand;
            purchase.Click += new EventHandler(purchaseClick);

           



            NameOfMagazine = new Label();
            NameOfMagazine.AutoSize = true;
            NameOfMagazine.Text = item.Name;
            NameOfMagazine.Font = new Font("OCR A", (float)10, FontStyle.Bold);
            this.Controls.Add(NameOfMagazine);

            Issue = new Label();
            Issue.AutoSize = true;
            Issue.Text = item.Type.ToString();
            Issue.Font = new Font("OCR A", (float)8.25);
            Issue.ForeColor = Color.Black;
            this.Controls.Add(Issue);

            Price = new Label();
            Price.AutoSize = true;
            Price.Text = magazine.Price.ToString()+" TL";
            Price.Font = new Font("OCR A", (float)11.25, FontStyle.Bold);
            Price.ForeColor = Color.Black;
            this.Controls.Add(Price);



            this.Controls[0].Location = new Point(125, 20);//name
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 50);//category
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 80);//price
            this.Controls[2].BringToFront();
            this.Controls.Add(picBox);
            this.Controls[3].Location = new Point(10, 15); //Item image
            this.Controls.Add(show);
            this.Controls[4].Location = new Point(170, 140);
            this.Controls.Add(purchase);
            this.Controls[5].Location = new Point(240, 140);


        }

        private void purchaseClick(object sender, EventArgs e)
        {
            ItemtoPurchase item = new ItemtoPurchase();
            item.Product = this.magazine;
            item.Quantity = 1;
            MainForm.shoppingcart.addProduct(item);
            MessageBox.Show("Product/Products added to Shoppingcart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showClick(object sender, EventArgs e)
        {
            magazine.printProperties();
        }
    }
}
