using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.POSDTO
{
    class OrderDTO
    {
        private Int64 orderID;
        private string orderTitle;
        private DateTime orderDate;
        private string orderStatus;
        private Int64 bAdmin;

        public OrderDTO(Int64 ID)
        {
            orderID = ID;
        }
        public OrderDTO(Int64 ID, string title, DateTime date, string status, Int64 admin)
        {
            orderID = ID; orderTitle = title; orderDate = date; orderStatus = status; bAdmin = admin;
        }

        public Int64 ORDERID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string ORDERTITLE
        {
            get { return orderTitle; }
            set { orderTitle = value; }
        }

        public DateTime ORDERDATE
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public string ORDERSTATUS
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public Int64 ORDERADMIN
        {
            get { return bAdmin; }
            set { bAdmin = value; }
        }
    }
}
