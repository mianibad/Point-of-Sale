using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSBLL;
using PointOfSale.POSDTO;
using PointOfSale.POSDAL;

namespace PointOfSale
{
    public partial class ListViewClicked : Form
    {
        private Int64 pid;
        private string pName;
        private string pCode;
        private string pCompany;
        private string pStockUnit;
        private string pCategory;

        ProductCategoryBLL pCategoryBLL;
        ProductManagementBLL productBLL;
        public ListViewClicked(Int64 id, string name, string code, string company, string stockUnit, string category)
        {
            InitializeComponent();
            TopMost = true;
            pid = id; pName = name; pCode = code; pCompany = company; pStockUnit = stockUnit; pCategory = category;
            
        }

        private void ListViewClicked_Load(object sender, EventArgs e)
        {
            CategoryCMBpopulation();

            txt_PName.Text = pName;
            txt_PCode.Text = pCode;
            txt_PCompany.Text = pCompany;
            txt_PStock.Text = pStockUnit;
            cmbCategory.Text = pCategory;
        }

        void CategoryCMBpopulation()
        {
            pCategoryBLL = new ProductCategoryBLL();
            List<string> result = new List<string>();
            result = pCategoryBLL.productInsertComboPopu();

            for (int i = 0; i < result.Count; i++)
            {
                 cmbCategory.Items.Add(result[i]);
            }
        }

        void clearAllFields()
        {
            txt_PName.Text = "";
            txt_PCode.Text = "";
            txt_PCompany.Text = "";
            txt_PStock.Text = "";
            cmbCategory.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to update record?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                productBLL = new ProductManagementBLL();

                string NAME = txt_PName.Text;
                string CODE = txt_PCode.Text;
                string COMPANY = txt_PCompany.Text;
                string STOCKU = txt_PStock.Text;
                string CATEGORY = cmbCategory.Text;

                int pAdmin = 1;

                ProductDTO DTO = new ProductDTO(pid, NAME, CODE, COMPANY, STOCKU, pAdmin, CATEGORY);
                
                productBLL.updateRecord(DTO);
                clearAllFields();
                this.Hide();
              
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete record?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                productBLL = new ProductManagementBLL();

                ProductDTO DTO = new ProductDTO(pid, "", "", "", "", 0, "");

                productBLL.deleteRecord(DTO);

                clearAllFields();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
