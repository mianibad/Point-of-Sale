using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.POSDTO
{
    class OrderProductDTO
    {
        private Int64 orderID, productID;
        private string quantity, size; 
        public OrderProductDTO(Int64 oid, Int64 pid, string quant, string siz)
        {
            orderID = oid; productID = pid; quantity = quant; size = siz;
        }
        public OrderProductDTO(Int64 oid)
        {
            orderID = oid;
        }
        public OrderProductDTO(Int64 oid, Int64 pid)
        {
            orderID = oid; productID = pid;
        }

        public Int64 ORDERID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public Int64 PRODUCTID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string SIZE
        {
            get { return size; }
            set { size = value; }
        }
    }
}
