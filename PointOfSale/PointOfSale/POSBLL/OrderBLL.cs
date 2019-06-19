using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.POSDTO;
using PointOfSale.POSDAL;

namespace PointOfSale.POSBLL
{
    class OrderBLL
    {
        OrderDAL orderDAL;
        public OrderBLL()
        {

        }

        public void InsertOrder(OrderDTO dto)
        {
            orderDAL = new OrderDAL();
            orderDAL.InsertRecordOrder(dto);
        }

        public ArrayList SearchOrder(OrderDTO dto)
        {
            orderDAL = new OrderDAL();
            ArrayList arr = orderDAL.SearchRecordOrder(dto);
            return arr;
        }

        public void DeleteOrder(OrderDTO dto)
        {
            orderDAL = new OrderDAL();
            orderDAL.DeleteRecord(dto);
        }

        public void UpdateOrder(OrderDTO dto)
        {
            orderDAL = new OrderDAL();
            orderDAL.UpdateRecord(dto);
        }


        public ArrayList searchByTyping(string getText)
        {   // order search textbox's text change event handling method
            orderDAL = new OrderDAL();
            ArrayList arr = orderDAL.searchByTyping(getText);
            return arr;
        }
    }
}
