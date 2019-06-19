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
    class OrderProductBLL
    {
        OrderProductDAL oproductDAL;
        public OrderProductBLL()
        {

        }

        public void insert(OrderProductDTO dto)
        {
            oproductDAL = new OrderProductDAL();
            oproductDAL.insert(dto);
        }

        public ArrayList search(OrderProductDTO dto)
        {
            oproductDAL = new OrderProductDAL();
            ArrayList arr = oproductDAL.search(dto);
            return arr;
        }

        public void delete(OrderProductDTO dto)
        {
            oproductDAL = new OrderProductDAL();
            oproductDAL.delete(dto);
        }
    }
}
