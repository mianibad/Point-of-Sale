using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.POSDTO;
using PointOfSale.POSDAL;
using System.Collections;

namespace PointOfSale.POSBLL
{
    class ProductVariantsBLL
    {
        public void addVariant(ProductVariantsDTO pvDTO)
        {
            ProductVariantsDAL pvDAL = new ProductVariantsDAL();
            pvDAL.addVariants(pvDTO);
        }

        public ArrayList searchAllVariant(Int64 productID)
        {
            ProductVariantsDAL pvDAL = new ProductVariantsDAL();
            ArrayList arr = pvDAL.searchAllVariant(productID);
            return arr;
        }

        public void deleteVariant(Int64 pvID)
        {
            ProductVariantsDAL pvDAL = new ProductVariantsDAL();
            pvDAL.deleteVariant(pvID);
        }

        public void updateVariant(ProductVariantsDTO pvDTO)
        {
            ProductVariantsDAL pvDAL = new ProductVariantsDAL();
            pvDAL.updateVariants(pvDTO);
        }
    }
}
