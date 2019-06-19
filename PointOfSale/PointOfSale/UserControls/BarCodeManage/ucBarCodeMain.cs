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
using System.Collections;

namespace PointOfSale.UserControls.BarCodeManage
{
    public partial class ucBarCodeMain : UserControl
    {
        ProductManagementBLL productBLL;

        public ucBarCodeMain()
        {
            InitializeComponent();
        }

        private void ucBarCodeMain_Load(object sender, EventArgs e)
        {
            getAllProducts();
            btnInsert.Hide();
            btnSearch.Hide(); 
            btnListing.Hide(); 
        }

        void getAllProducts()
        {
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




        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                //TODO - Button Clicked - Execute Code Here
                string pCode = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string pPrice = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                BarCodeGenerator bcGenerator = new BarCodeGenerator(pCode,pPrice);
                bcGenerator.Show();
            }
            
        }


    }
}
