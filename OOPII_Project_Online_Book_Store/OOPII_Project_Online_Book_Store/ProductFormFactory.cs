using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPII_Project_Online_Book_Store
{
    /*\class ProductFormFactory
* \brief Parametreye gore Form olusturan class
*/
    class ProductFormFactory
    {
        static Form ProductFormCreate(Product product)
        {
            Form form = null;
            if (product is Book)
            {
                form = new BookForm((Book)product);


            }
            else if (product is Magazine)
            {
                form = new MagazineForm((Magazine)product);
            }
            else if(product is MusicCD)
            {
                form = new MusicCDForm((MusicCD)product);
            }
            return form;
        }
    }
}
