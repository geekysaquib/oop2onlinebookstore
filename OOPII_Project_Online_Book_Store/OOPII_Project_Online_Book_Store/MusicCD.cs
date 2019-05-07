using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    /*\enum MusicCDType
    * \brief Icinde MusicCD turlerini barindirir.
    *
    */
    public enum MusicCDType
    {
        Rap,
        Rock,
        Pop,
        Metal,
    }
    /*\class MusicCD
* \brief Product sinifindan kalitilan MusicCD sinifidir.Ozelliklerini barindirir.
*/
    public class MusicCD : Product
    {
        private String singer;
        private MusicCDType type;
        private String demo;
        public MusicCD(String singer, MusicCDType type, String name, int id, double price, String demo, String picture, String issue) : base(name, id, price, picture, issue)
        {
            this.Singer = singer;
            this.Type = type;
            this.Demo = demo;
        }


        public MusicCD(String name, int id, double price, String picture, String issue) : base(name, id, price, picture, issue)
        {
        }

        public String Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
            }
        }

        internal MusicCDType Type
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

        public String Demo { get { return demo; } set { demo = value; } }

        public override void printProperties()
        {
            MusicCDForm music = new MusicCDForm(this);
            music.ShowDialog();
            music.Dispose();
        }

        static public MusicCDType getMusicCDType(String type)
        {
            switch (type)
            {

                case "Rap": return MusicCDType.Rap;
                case "Rock": return MusicCDType.Rock;
                case "Pop": return MusicCDType.Pop;
                case "Metal": return MusicCDType.Metal;

                default: return 0;
            }
        }
    }
}
