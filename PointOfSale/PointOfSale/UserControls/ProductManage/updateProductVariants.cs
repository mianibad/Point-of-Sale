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
    public partial class updateProductVariants : Form
    {
        private Int64 pvID, productID;
        private string Price, Flavor, Size;
        public updateProductVariants(Int64 id, string pric, string flavr, string siz, Int64 pID)
        {
            InitializeComponent();
            pvID = id; Price = pric; Flavor = flavr; Size = siz; productID = pID;
        }

        private void updateProductVariants_Load(object sender, EventArgs e)
        {
            txtFlavor.Text = Flavor;
            txtPrice.Text = Price;
            txtSize.Text = Size;
        }

        void clearAllFields()
        {
            txtFlavor.Text = "";
            txtPrice.Text = "";
            txtSize.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string flavor = txtFlavor.Text;
            string price = txtPrice.Text;
            string size = txtSize.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure want to Update record?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ProductVariantsDTO pvDTO = new ProductVariantsDTO(pvID, price, flavor, size, productID);
                ProductVariantsBLL pvBLL = new ProductVariantsBLL();
                pvBLL.updateVariant(pvDTO);
                clearAllFields();
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
