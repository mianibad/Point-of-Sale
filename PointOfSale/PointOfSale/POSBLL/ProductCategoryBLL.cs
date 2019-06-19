using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDAL;
using PointOfSale.POSDTO;

namespace PointOfSale.POSBLL
{
    class ProductCategoryBLL
    {
        ProductCategoryDAL pCategoryDAL;

        // ============================== PRODUCT CATEGORY UPDATE DELETE SEARCH INSERT METHODS ==============================

        // ====================================== category insertion in database ============================================
        public  void insertCatRecord(PCategoryDTO DTO)
        {
            pCategoryDAL = new ProductCategoryDAL();
            pCategoryDAL.insertCatToDatabase(DTO);
        }

        
        public ArrayList searchAll()
        {
            pCategoryDAL = new ProductCategoryDAL();
            ArrayList arr = pCategoryDAL.searchAll();
            return arr;
        }

        // ====================================== end of insertion in database ============================================

        // ====================================== search in database ============================================

        public void searchCatRecord(PCategoryDTO DTO)
        {
            pCategoryDAL = new ProductCategoryDAL();
            pCategoryDAL.searchCatInDatabase(DTO);
            
        }

        // ====================================== end of search in database ============================================


        // ====================================== update in database ============================================

        public void updateCatRecord(PCategoryDTO DTO)
        {
            pCategoryDAL = new ProductCategoryDAL();
            pCategoryDAL.updateCatToDatabase(DTO);
            
        }

        // ====================================== end of update in database ============================================


        // ====================================== delete in database ============================================

        public void deleteCatRecord(PCategoryDTO DTO)
        {
            pCategoryDAL = new ProductCategoryDAL();
            pCategoryDAL.deleteCatToDatabase(DTO);
        }

        // ====================================== end of delete in database ============================================



        // ============================== END OF PRODUCT CATEGORY UPDATE DELETE SEARCH INSERT METHODS ==============================







        // ========================================== Product population in comboBox method ========================================

        public List<string> productInsertComboPopu()
        {
            pCategoryDAL = new ProductCategoryDAL();
            List<string> result = new List<string>();
            result = pCategoryDAL.productComboPoping();
            return result;
        }




        // ======================================== End of Product population in comboBox method ====================================




        // ======================================== ProductListing  method ====================================
        public ArrayList pListingSearch(PCategoryDTO DTO)
        {
            pCategoryDAL = new ProductCategoryDAL();
            ArrayList arr = pCategoryDAL.pListingSearch(DTO);
            return arr;
        }
        // ======================================== End of ProductListing method ====================================
    }
}
