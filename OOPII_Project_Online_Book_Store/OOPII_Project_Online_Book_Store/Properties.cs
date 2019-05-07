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
    public partial class Properties : Form
    {
        MusicCD cD = null;
        Book book = null;
        Magazine magazine = null;

        public Properties()
        {
            InitializeComponent();
        }

        public Magazine Magazine { get => magazine; set => magazine = value; }
        public Book Book { get => book; set => book = value; }
        public MusicCD CD { get => cD; set => cD = value; }

        private void Properties_Load(object sender, EventArgs e)
        {

        }
    }
}
