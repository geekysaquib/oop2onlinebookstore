using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPII_Project_Online_Book_Store
{
    enum MagazineType
    {
        Actual,
        News,
        Sport,
        computer,
        technology,

    }
    class Magazine : Product
    {
        private String issue;
        private MagazineType type;
        public Magazine(MagazineType type,string issue, String name, int id, double price):base( name,  id,  price)
        {
            this.Issue = issue;
            this.Type = type;   
        }
       

        public Magazine(string name, int id, double price) : base(name, id, price)
        {
        }

        public string Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
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

                case "Actual":return MagazineType.Actual;
                case "News":return MagazineType.News;
                case "Sport":return MagazineType.Sport;
                case "computer":return MagazineType.computer;
                case "technology":return MagazineType.technology;
                default: return 0; 
            }
        }

        public override void printProperties()
        {
           
        }
    }
}
