using System.Windows.Forms;

namespace OOPII_Project_Online_Book_Store
{
    /*\class ProductPanel
* \brief Panel sinifindan kalitilan ProductPanel sinifidir.Ozelliklerini barindirir.
*/
    public abstract class ProductPanel : Panel
    {
        public Label name;
        public PictureBox picBox;
        public Button purchase;
        public Button show;
    }
}

