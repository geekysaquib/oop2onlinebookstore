using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace OOPII_Project_Online_Book_Store
{
    
    public partial class MusicCDForm : Form
    {
        MusicCD musicCD;
        public MusicCDForm(MusicCD musicCD)
        {
            this.musicCD = musicCD;
            InitializeComponent();
        }

        private void MusicCDForm_Load(object sender, EventArgs e)
        {
            lblname.Text += musicCD.Name;
            lblprice.Text += musicCD.Price.ToString()+" TL";
            lbltype.Text += musicCD.Type.ToString();
            txtIssue.Text = musicCD.Issue;
            try
            {
                pbmusicCD.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\musicCDs\" + musicCD.Picture);
            }
            catch
            {
                pbmusicCD.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            pbmusicCD.BackgroundImageLayout = ImageLayout.Zoom;
            
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private void btnPlayDemo_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.SoundLocation = Application.StartupPath + @"\resources\demos\" + musicCD.Demo;

                soundPlayer.Play();
            }
            catch
            {
                MessageBox.Show("demo not found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopDemo_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            ItemtoPurchase item = new ItemtoPurchase();
            item.Product = this.musicCD;
            item.Quantity = Convert.ToInt32(nudmussicCD.Value);
            MainForm.shoppingcart.addProduct(item);
            MessageBox.Show("Product/Products added to Shoppingcart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
