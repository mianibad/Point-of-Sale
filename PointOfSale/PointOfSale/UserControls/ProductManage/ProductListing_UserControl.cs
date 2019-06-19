using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDAL;
using PointOfSale.POSBLL;
using PointOfSale.POSDTO;
using System.Collections;

namespace PointOfSale.UserControls.ProductManage
{
    public partial class ProductListing_UserControl : UserControl
    {
        ProductCategoryBLL pCategoryBLL;
        PCategoryDTO cDTO;

        public ProductListing_UserControl()
        {
            InitializeComponent();
        }

        private void ProductListing_UserControl_Load(object sender, EventArgs e)
        {
            cmb_PL_PCategories_Pop();
        }

        void cmb_PL_PCategories_Pop()     // categories comboBox population method
        {
            pCategoryBLL = new ProductCategoryBLL();
            List<string> result = new List<string>();
            result = pCategoryBLL.productInsertComboPopu();

            for (int i = 0; i < result.Count; i++)
            {
                cmb_PL_PCategories.Items.Add(result[i]);
            }
        }

        

        public void SearchRecordByCategory()            // method to be called on search button click
        {
            string pCat = cmb_PL_PCategories.Text;

            if (pCat != "")
            {
                int BAdmin = 1;
                cDTO = new PCategoryDTO(pCat, BAdmin);

                pCategoryBLL = new ProductCategoryBLL();
                ArrayList arr = pCategoryBLL.pListingSearch(cDTO);

                lv_ProductListing.Items.Clear();
                foreach (object O in arr)
                {
                    ProductDTO DTO = (ProductDTO)O;
                    string[] row = { DTO.PID + "", DTO.PNAME, DTO.PCODE, DTO.PCOMPANY, DTO.PSTOCKUNIT, DTO.PCATEGORY };
                    ListViewItem item = new ListViewItem(row);
                    lv_ProductListing.Items.Add(item);
                }


            }
            else
            {
                MessageBox.Show("Please Select Category to Search", "Error");
            }
        }

        private void lv_ProductListing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Int64 pID = Int64.Parse(lv_ProductListing.SelectedItems[0].SubItems[0].Text);
            string pName = lv_ProductListing.SelectedItems[0].SubItems[1].Text;
            string pCode = lv_ProductListing.SelectedItems[0].SubItems[2].Text;
            string pCompany = lv_ProductListing.SelectedItems[0].SubItems[3].Text;
            string pStock = lv_ProductListing.SelectedItems[0].SubItems[4].Text;
            string pCategory = lv_ProductListing.SelectedItems[0].SubItems[5].Text;

            ListViewClicked lv = new ListViewClicked(pID, pName, pCode, pCompany, pStock, pCategory);
            lv.Show();
        }

        private void lv_ProductListing_MouseClick(object sender, MouseEventArgs e)
        {
            Int64 pID = Int64.Parse(lv_ProductListing.SelectedItems[0].SubItems[0].Text);
            string pName = lv_ProductListing.SelectedItems[0].SubItems[1].Text;
            string pCode = lv_ProductListing.SelectedItems[0].SubItems[2].Text;
            string pCompany = lv_ProductListing.SelectedItems[0].SubItems[3].Text;
            string pStock = lv_ProductListing.SelectedItems[0].SubItems[4].Text;
            string pCategory = lv_ProductListing.SelectedItems[0].SubItems[5].Text;

            ListViewClicked lv = new ListViewClicked(pID, pName, pCode, pCompany, pStock, pCategory);
            lv.Show();
        }

        private void cmb_PL_PCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchRecordByCategory();
        }

        
    }
}
