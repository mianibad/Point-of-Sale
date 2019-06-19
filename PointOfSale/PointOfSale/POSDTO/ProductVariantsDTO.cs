using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.POSDTO
{
    class ProductVariantsDTO
    {
        private Int64 pvID, productID;
        private string Price, Flavor, Size;


        public ProductVariantsDTO(string pric, string flavr, string siz, Int64 pID)
        {
            Price = pric; Flavor = flavr; Size = siz; productID = pID;
        }
        public ProductVariantsDTO(Int64 id, string pric, string flavr, string siz)
        {
            pvID = id; Price = pric; Flavor = flavr; Size = siz;
        }

        public ProductVariantsDTO(Int64 id, string pric, string flavr, string siz, Int64 pID)
        {
            pvID = id; Price = pric; Flavor = flavr; Size = siz; productID = pID;
        }




        public Int64 PRODVARID
        {
            get { return pvID; }
            set { pvID = value; }
        }

        public string PRICE
        {
            get { return Price; }
            set { Price = value; }
        }

        public string FLAVOR
        {
            get { return Flavor; }
            set { Flavor = value; }
        }

        public string SIZE
        {
            get { return Size; }
            set { Size = value; }
        }

        public Int64 PRODUCTID
        {
            get { return productID; }
            set { productID = value; }
        }
    }
}
