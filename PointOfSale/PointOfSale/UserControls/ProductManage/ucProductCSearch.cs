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

namespace PointOfSale.UserControls.ProductManage
{
    public partial class ucProductCSearch : UserControl
    {
        ProductCategoryBLL pcBLL;
        PCategoryDTO pcDTO;
        public ucProductCSearch()
        {
            InitializeComponent();
        }

        private void ucProductCSearch_Load(object sender, EventArgs e)
        {
            searchAll();
        }

        void searchAll()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            pcBLL = new ProductCategoryBLL();
            ArrayList arr = pcBLL.searchAll();

            foreach(object o in arr)
            {
                pcDTO = (PCategoryDTO)o;

                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = pcDTO.CATID;
                dataGridView.Rows[a].Cells[1].Value = pcDTO.CATNAME;
            }
        }



        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 2) // update record
            {
                //TODO - Button Clicked - Execute Code Here
                Int64 cID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string cName = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                pCategoryUpdate pcUpdate = new pCategoryUpdate(cID,cName,1);
                pcUpdate.Show();
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3) // delete record
            {
                Int64 cID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete record?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pcBLL = new ProductCategoryBLL();
                    

                    PCategoryDTO DTO = new PCategoryDTO("", 0);
                    DTO.CATID = cID;
                    pcBLL.deleteCatRecord(DTO);

                    searchAll();

                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
    }
}
