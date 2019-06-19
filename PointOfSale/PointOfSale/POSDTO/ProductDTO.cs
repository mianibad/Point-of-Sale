using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.POSBLL;

namespace PointOfSale.POSDTO
{
    class ProductDTO
    {
        private Int64 pID;
        private string pName;
        private string pCode;
        private string pCompany;
        private string pStockUnit;
        private Int64 pBAdmin;
        private string pCategory;

        public ProductDTO(Int64 id, string name, string code, string company, string stUnit, Int64 pBA, string pCat )
        {
            ProductManagementBLL pBLL = new ProductManagementBLL();
            pID = id;  pName = name; pCode = code; pCompany = company; pStockUnit = stUnit; pBAdmin = pBA; pCategory = pCat ;
        }
        public ProductDTO(Int64 id)
        {
            pID = id;
        }
        public ProductDTO(Int64 id, string name)
        {
            pID = id; pName = name;
        }

        public Int64 PID
        {
            get { return pID; }
            set { pID = value; }
        }

        public string PNAME
        {
            get { return pName; }
            set { pName = value; }
        }

        public string PCODE
        {
            get { return pCode; }
            set { pCode = value; }
        }

        public string PCOMPANY
        {
            get { return pCompany; }
            set { pCompany = value; }
        }

        public string PSTOCKUNIT
        {
            get { return pStockUnit; }
            set { pStockUnit = value; }
        }

        public Int64 PBADMIN
        {
            get { return pBAdmin; }
            set { pBAdmin = value; }
        }

        public string PCATEGORY
        {
            get { return pCategory; }
            set { pCategory = value; }
        }
    }
}
