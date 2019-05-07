using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\class ProductPanelCreator
* \brief Parametreye gore ProductPanel olusturan class.
*/
    class ProductPanelCreator
    {
       static  public ProductPanel CreatePanel(Product p)
        {
            ProductPanel panel = null;

            if (p is Book)
            {
                panel = new BookPanel((Book)p);
            }
            else if (p is Magazine)
            {
                panel = new MagazinePanel((Magazine)p);
            }
            else
            {
                panel = new MusicCDPanel((MusicCD)p);
            }

            return panel;
        }
    }
}
