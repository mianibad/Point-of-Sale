using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDTO;
using PointOfSale.POSBLL;
using PointOfSale.POSDAL;
using System.Collections;

namespace PointOfSale.UserControls.ProductManage
{
    public partial class searchClicked_UserControl : UserControl
    {
        ProductManagementBLL productBLL;
        public searchClicked_UserControl()
        {
            InitializeComponent();
        }

        private void searchClicked_UserControl_Load(object sender, EventArgs e)
        {
            getAllProducts();
        }

        void getAllProducts()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            productBLL = new ProductManagementBLL();
            ArrayList arr = productBLL.getAllProducts();

            foreach (object o in arr)
            {
                ProductDTO dto = (ProductDTO)o;

                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = dto.PID;
                dataGridView.Rows[a].Cells[1].Value = dto.PNAME;
                dataGridView.Rows[a].Cells[2].Value = dto.PCODE;
                dataGridView.Rows[a].Cells[3].Value = dto.PCOMPANY;
                dataGridView.Rows[a].Cells[4].Value = dto.PSTOCKUNIT;
                dataGridView.Rows[a].Cells[5].Value = dto.PCATEGORY;
            }
        }
    


        // =================================== search in database type in textbox ============================

        private void nameForSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            productBLL = new ProductManagementBLL();

            string name = nameForSearchtextBox.Text;
            
            ArrayList arr = productBLL.searchRecord(name, name);

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach (object o in arr)
            {
                ProductDTO dto = (ProductDTO)o;

                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = dto.PID;
                dataGridView.Rows[a].Cells[1].Value = dto.PNAME;
                dataGridView.Rows[a].Cells[2].Value = dto.PCODE;
                dataGridView.Rows[a].Cells[3].Value = dto.PCOMPANY;
                dataGridView.Rows[a].Cells[4].Value = dto.PSTOCKUNIT;
                dataGridView.Rows[a].Cells[5].Value = dto.PCATEGORY;
            }
        }

        // =================================== end of search in database type in textbox ============================

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 6)
            {
                Int64 pID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string pName = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string pCode = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string pCompany = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                string pStockUnit = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string pCategory = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();


                ListViewClicked lv = new ListViewClicked(pID, pName, pCode, pCompany, pStockUnit, pCategory);
                lv.Show();
            }
        }


        // ====================================== add variants button click ================================

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6) // update record
            {
                //TODO - Button Clicked - Execute Code Here
                Int64 productID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                ViewProductVariants vpV = new ViewProductVariants(productID);
                vpV.Show();
            }
            /*if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3) // delete record
            {
                Int64 cID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete record?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    

                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }*/
        }

    }
}
