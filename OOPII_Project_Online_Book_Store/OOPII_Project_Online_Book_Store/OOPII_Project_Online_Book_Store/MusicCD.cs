using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    enum MusicCDType
    {
        Romance,
        HardRock,
        Country,
    }
    class MusicCD : Product
    {
        private String singer;
        private MusicCDType type;
        public MusicCD(String singer,MusicCDType type, String name, int id, double price) :base( name,  id,  price)
        {
            this.Singer = singer;
            this.Type = type;
        }
       

        public MusicCD(string name, int id, double price) : base(name, id, price)
        {
        }

        public string Singer
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

        public override void printProperties()
        {

        }

        static public MusicCDType getMusicCDType(String type)
        {
            switch (type)
            {

                case "Actual": return MusicCDType.Romance;
                case "News": return MusicCDType.HardRock;
                case "Sport": return MusicCDType.Country;
               
                default: return 0;
            }
        }
    }
}
