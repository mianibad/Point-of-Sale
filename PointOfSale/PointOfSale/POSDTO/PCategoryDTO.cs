using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.POSDTO
{
    class PCategoryDTO
    {
        private Int64 catID; 
        private string catName;
        private Int64 catBAdmin;

        public PCategoryDTO(string name, Int64 admin)
        {
            catName = name; catBAdmin = admin;
        }

        public PCategoryDTO(Int64 id, string name, Int64 admin)
        {
            catID = id;  catName = name; catBAdmin = admin;
        }

        public Int64 CATID
        {
            get
            {
                return catID;
            }
            set
            {
                catID = value;
            }
            
        }

        public string CATNAME
        {
            get
            {
                return catName;
            }
            set
            {
                catName = value;
            }
            
        }


        public Int64 CATBADMIN
        {
            get
            {
                return catBAdmin;
            }
            set
            {
                catBAdmin = value;
            }
            
        }
    }
}
