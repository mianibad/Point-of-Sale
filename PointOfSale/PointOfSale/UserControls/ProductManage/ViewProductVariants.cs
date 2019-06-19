using PointOfSale.POSBLL;
using PointOfSale.POSDTO;
using System;
using System.Collections;
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
    public partial class ViewProductVariants : Form
    {
        private Int64 productID;
        public ViewProductVariants(Int64 pID)
        {
            InitializeComponent();
            productID = pID;
        }

        private void ViewProductVariants_Load(object sender, EventArgs e)
        {
            searchAll();
        }

        void searchAll()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            ProductVariantsBLL pvBLL = new ProductVariantsBLL();
            ArrayList arr = pvBLL.searchAllVariant(productID);

            foreach (object o in arr)
            {
                ProductVariantsDTO dto = (ProductVariantsDTO)o;

                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = dto.PRODVARID;
                dataGridView.Rows[a].Cells[1].Value = dto.FLAVOR;
                dataGridView.Rows[a].Cells[2].Value = dto.PRICE;
                dataGridView.Rows[a].Cells[3].Value = dto.SIZE;
            }
        }

        void clearAllFields()
        {
            txtFlavor.Text = "";
            txtPrice.Text = "";
            txtSize.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string flavor = txtFlavor.Text;
            string price = txtPrice.Text;
            string size = txtSize.Text;

            if (flavor != "" & price != "" & size != "")
            {
                ProductVariantsDTO pvDTO = new ProductVariantsDTO(price,flavor,size,productID);
                ProductVariantsBLL pvBLL = new ProductVariantsBLL();
                pvBLL.addVariant(pvDTO);
                searchAll();
                clearAllFields();
            }
            else
            {
                MessageBox.Show("Please Fill All The Fields!", "Error");
            }
        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4) // update record
            {
                //TODO - Button Clicked - Execute Code Here
                Int64 pvID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string flavor = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string price = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string size = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                updateProductVariants upV = new updateProductVariants(pvID,price,flavor,size,productID);
                upV.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 5) // update record
            {
                //TODO - Button Clicked - Execute Code Here
                Int64 pvID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete record?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductVariantsBLL pvBLL = new ProductVariantsBLL();
                    pvBLL.deleteVariant(pvID);
                    searchAll();

                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

    }
}
