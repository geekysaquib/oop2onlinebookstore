using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOPII_Project_Online_Book_Store
{
    /*\class ShoppingCartPanel
 * \brief Panel sinifindan kalitilan ShoppingCartPanel sinifidir.Ozelliklerini barindirir.
 */
    public class ShoppingCartPanel:Panel
    {
        Label lblProductName;
        Label lblPrice;
        Button btnRemove;
        ShoppingCartForm shopping;
        NumericUpDown nudQuantity;
        PictureBox pbProduct;
        public ItemtoPurchase item;
        public ShoppingCartPanel(ItemtoPurchase item, ShoppingCartForm  shopping)
        {
            this.item = item;
            this.shopping = shopping;
            this.Size = new Size(470, 85);
            this.BorderStyle = BorderStyle.FixedSingle;
            //NAME
            lblProductName = new Label();
            lblProductName.AutoSize = false;
            lblProductName.Size = new Size(200, 20);
            lblProductName.Text = item.Product.Name;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("OCR A", (float)11.25);
            this.Controls.Add(lblProductName);

            //Price
            lblPrice = new Label(); 
            lblPrice.AutoSize = false;
            lblPrice.Size = new Size(200, 20);
            lblPrice.Text = (item.Quantity* item.Product.Price).ToString()+" TL";
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("OCR A", (float)11.25);
            this.Controls.Add(lblPrice);

            //quantity
            
            nudQuantity = new NumericUpDown();
            nudQuantity.Value = item.Quantity;
            nudQuantity.Minimum = 1;
            nudQuantity.Size = new Size(85, 20);
            nudQuantity.ValueChanged += new EventHandler(nudQuantityChanged);

            this.Controls.Add(nudQuantity);

            //remove
            btnRemove = new Button();
            btnRemove.Text = "X";
            btnRemove.TextAlign = ContentAlignment.MiddleCenter;
            btnRemove.Size = new Size(25, 25);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRemove.BackColor = Color.Transparent;
            btnRemove.Click += new EventHandler(btnRemoveClick);
          //  btnRemove.Image = Properties.Resources.removeitem;
            //btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(btnRemove);

            pbProduct = new PictureBox();
            pbProduct.Size = new Size(48, 48);
            try
            {
                pbProduct.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\" + item.Product.Picture);
            }
            catch
            {
                pbProduct.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            pbProduct.BackgroundImageLayout = ImageLayout.Zoom;
            this.Controls.Add(pbProduct);





            this.Controls[0].Location = new Point(63, 24);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(63, 54);// Price label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(366, 26);//nud
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(392, 58);//tutton
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(16, 16);// image 
            this.Controls[4].BringToFront();


        }

        private void nudQuantityChanged(object sender, EventArgs e)
        {
            lblPrice.Text = (Convert.ToDouble(nudQuantity.Value) * item.Product.Price).ToString();
            this.item.Quantity =Convert.ToInt32(nudQuantity.Value);
        }

        private void btnRemoveClick(object sender, EventArgs e)
        {
            MainForm.shoppingcart.itemstoPurchase.Remove(this.item);
            shopping.fillPanel();
        }
    }
}
