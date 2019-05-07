using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\enum MagazineType
  * \brief Icinde Magazine turlerini barindirir.
  *
  */
    public enum MagazineType
    {
        Science,
        News,
        Sport,
        Computer,
        Technology,

    }
    /*\class Magazine
  * \brief Product sinifindan kalitilan Magazine sinifidir.Ozelliklerini barindirir.
  */
    public class Magazine : Product
    {

        private MagazineType type;
        public Magazine(MagazineType type, string issue, String name, int id, double price, String picture) : base(name, id, price, picture, issue)
        {

            this.Type = type;
        }


        public Magazine(string name, int id, double price, String picture, String issue) : base(name, id, price, picture, issue)
        {
        }



        internal MagazineType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        static public MagazineType getmagazine(String type)
        {
            switch (type)
            {

                case "Science": return MagazineType.Science;
                case "News": return MagazineType.News;
                case "Sport": return MagazineType.Sport;
                case "Computer": return MagazineType.Computer;
                case "Technology": return MagazineType.Technology;
                default: return 0;
            }
        }

        public override void printProperties()
        {
            MagazineForm magazine = new MagazineForm(this);
            magazine.ShowDialog();
            magazine.Dispose();
        }
    }
}
