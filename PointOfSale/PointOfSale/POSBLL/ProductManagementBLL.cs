using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDAL;
using PointOfSale.POSDTO;

namespace PointOfSale.POSBLL
{
    class ProductManagementBLL
    {
        ProductManagementDAL productDAL;



        public ArrayList getAllProducts()
        {
            productDAL = new ProductManagementDAL();
            ArrayList arr = productDAL.getAllProducts();
            return arr;
        }


        // ============================== PRODUCT UPDATE DELETE SEARCH INSERT METHODS ==============================


        // ====================================== insertion in database ============================================
        public void insertRecord(ProductDTO dto)
        {
            productDAL = new ProductManagementDAL();
            productDAL.insertToDatabase(dto);
        }

        // ====================================== end of insertion in database ============================================



        // ====================================== search in database ============================================

        public ArrayList searchRecord(string a, string b)
        {
            productDAL = new ProductManagementDAL();
            ArrayList arr = productDAL.searchInDatabase(a,b);
            return arr;
        }

        // ====================================== end of search in database ============================================



        // ====================================== update in database ============================================

        public void updateRecord(ProductDTO DTO)
        {
            productDAL = new ProductManagementDAL();
            

            productDAL.updateToDatabase(DTO);

            
        }

        // ====================================== end of update in database ============================================


        // ====================================== delete in database ============================================

        public void deleteRecord(ProductDTO DTO)
        {
            productDAL = new ProductManagementDAL();

            productDAL.deleteToDatabase(DTO);
        }

        // ====================================== end of delete in database ============================================


        // ============================= END OF PRODUCT UPDATE DELETE SEARCH INSERT METHODS =============================



        public ArrayList searchProdOfCategory(ProductDTO dto)
        {
            productDAL = new ProductManagementDAL();
            ArrayList arr = productDAL.searchProdOfCategory(dto);
            return arr;
        }

        public Int64 prodNameToID(ProductDTO dto)
        {
            productDAL = new ProductManagementDAL();
            Int64 result = productDAL.prodNameToID(dto);
            return result;
        }


        public string prodIdToName(ProductDTO dto)
        {
            productDAL = new ProductManagementDAL();
            string result = productDAL.prodIDToName(dto);
            return result;
        }




    }
}
