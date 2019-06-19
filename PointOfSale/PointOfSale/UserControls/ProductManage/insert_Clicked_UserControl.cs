using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSBLL;
using PointOfSale.POSDAL;
using PointOfSale.POSDTO;

namespace PointOfSale.UserControls.ProductManage
{
    public partial class insert_Clicked_UserControl : UserControl
    {
        //ProductManagement pm;
        ProductManagementBLL productBLL;
        ProductCategoryBLL pCategoryBLL;

        public insert_Clicked_UserControl()
        {
            InitializeComponent();
            insert_PCategory_comboBox_Pop();
        }


        void insert_PCategory_comboBox_Pop()    // categories comboBox population method
        {
            pCategoryBLL = new ProductCategoryBLL();
            List<string> result = new List<string>();

            result = pCategoryBLL.productInsertComboPopu();

            for (int i = 0; i < result.Count; i++)
            {
                insert_PCategory_comboBox.Items.Add(result[i]);
            }
        }


        // ================================== textboxes clear method ===============

        void clearAllTextBoxes()
        {
            insert_PName_textBox.Text = "";
            insert_PCode_textBox.Text = "";
            insert_PCompany_textBox.Text = "";
            insert_PStockU_textBox.Text = "";
            insert_PCategory_comboBox.Text = "";
        }

        // ================================== end textboxes method ===============


        private void insert_Add_button_Click(object sender, EventArgs e)
        {
            //pm = new ProductManagement();
            productBLL = new ProductManagementBLL();


            string pName = insert_PName_textBox.Text;
            string pCode = insert_PCode_textBox.Text;
            string pComp = insert_PCompany_textBox.Text;
            string pStock = insert_PStockU_textBox.Text;
            string pPCat = insert_PCategory_comboBox.Text;

            if (pName!="" & pCode!="" & pComp!="" & pStock!="" & pPCat!="")
            {


                Int64 pBAdmin = 1;

                ProductDTO pDTO = new ProductDTO(0,pName, pCode, pComp, pStock, pBAdmin, pPCat);
                
                productBLL.insertRecord(pDTO);

                clearAllTextBoxes();
            }
            else
            {
                MessageBox.Show("Please Fill All The Fields!");
            }
        }
    }
}
