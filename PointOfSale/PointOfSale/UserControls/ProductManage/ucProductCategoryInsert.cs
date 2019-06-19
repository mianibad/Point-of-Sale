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
using PointOfSale.POSDTO;

namespace PointOfSale.UserControls.ProductManage
{
    public partial class ucProductCategoryInsert : UserControl
    {

        ProductManagement pm;
        ProductCategoryBLL pCategoryBLL;

        public ucProductCategoryInsert()
        {
            InitializeComponent();
        }

        void clearAllFields()
        {
            insert_CATName_textBox.Text = "";
        }


        private void insert_CATAdd_button_Click(object sender, EventArgs e)
        {
            pCategoryBLL = new ProductCategoryBLL();

            string catName = insert_CATName_textBox.Text;
            int catAdmin = 1;

            if (catName != "")
            {
                PCategoryDTO DTO = new PCategoryDTO(catName, catAdmin);
                pCategoryBLL.insertCatRecord(DTO);
                clearAllFields();
            }
            else
            {
                MessageBox.Show("Please Fill All The Fields!");
            }
        }
    }
}
