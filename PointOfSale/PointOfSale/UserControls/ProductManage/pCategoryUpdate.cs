using PointOfSale.POSBLL;
using PointOfSale.POSDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UserControls.ProductManage
{
    public partial class pCategoryUpdate : Form
    {
        Int64 pCID, bCAdmin;
        string pCName;

        ProductCategoryBLL pCategoryBLL;

        public pCategoryUpdate(Int64 cID, string cName, Int64 bAdmin)
        {
            InitializeComponent();
            pCName = cName; pCID = cID; bCAdmin = bAdmin;
        }

        private void pCategoryUpdate_Load(object sender, EventArgs e)
        {
            txtCtName.Text = pCName; cmbCtBAdmin.Text = bCAdmin.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to update record?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pCategoryBLL = new ProductCategoryBLL();

                
                string catName = txtCtName.Text;
                Int64 catAdmin = Int64.Parse(cmbCtBAdmin.Text);

                PCategoryDTO DTO = new PCategoryDTO(pCID, catName, catAdmin);
                pCategoryBLL.updateCatRecord(DTO);
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
