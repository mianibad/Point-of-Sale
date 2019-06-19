using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using PointOfSale.POSDTO;
using PointOfSale.POSBLL;

namespace PointOfSale.UserControls.OrderManage
{
    public partial class UserControlSearch : UserControl
    {
        OrderDTO dto;
        OrderBLL orderBLL;
        DataGridViewButtonColumn btnAddProd, btnViewList;
        public UserControlSearch()
        {
            InitializeComponent();
        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {
            SearchRecord();

            btnAddProd = new DataGridViewButtonColumn();
            dataGridView.Columns.Add(btnAddProd);
            btnAddProd.FlatStyle = FlatStyle.Flat;
            btnAddProd.HeaderText = "Products";
            btnAddProd.Text = "Add Products";
            btnAddProd.Name = "btnAddProd";
            btnAddProd.UseColumnTextForButtonValue = true;


            btnViewList = new DataGridViewButtonColumn();
            dataGridView.Columns.Add(btnViewList);
            btnViewList.FlatStyle = FlatStyle.Flat;
            btnViewList.HeaderText = "List";
            btnViewList.Text = "View List";
            btnViewList.Name = "btnViewList";
            btnViewList.UseColumnTextForButtonValue = true;

        }

        void SearchRecord()
        {
            dto = new OrderDTO(1);
            orderBLL = new OrderBLL();
            ArrayList arr = orderBLL.SearchOrder(dto);
            
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach (object o in arr)
            {
                OrderDTO orderDTO = (OrderDTO)o;
                
                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = orderDTO.ORDERID;
                dataGridView.Rows[a].Cells[1].Value = orderDTO.ORDERTITLE;
                dataGridView.Rows[a].Cells[2].Value = orderDTO.ORDERDATE;
                dataGridView.Rows[a].Cells[3].Value = orderDTO.ORDERSTATUS;
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchRecord();
        }

        

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex==4)
            {
                //TODO - Button Clicked - Execute Code Here
                Int64 orderID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                AddOrderProducts AOP = new AddOrderProducts(orderID);
                AOP.Show();
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex==5)
            {
                Int64 orderID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                ViewOrderProducts VOP = new ViewOrderProducts(orderID);
                VOP.Show();
            }
        }

        

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0) { 
                Int64 oID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                string oTitle = dataGridView.Rows[e.RowIndex].Cells["OrderTitle"].Value.ToString();
                DateTime oDate = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells["ODate"].Value.ToString());
                string oStatus = dataGridView.Rows[e.RowIndex].Cells["oStatus"].Value.ToString();

                OrderListViewClicked olvc = new OrderListViewClicked(oID, oTitle, oDate, oStatus);
               olvc.Show();
            }
        }


        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {   // order search textbox's text change event handling method
            string getText = txtOrderSearch.Text;
            orderBLL = new OrderBLL();
            ArrayList arr = orderBLL.searchByTyping(getText);

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach (object o in arr)
            {
                OrderDTO orderDTO = (OrderDTO)o;

                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = orderDTO.ORDERID;
                dataGridView.Rows[a].Cells[1].Value = orderDTO.ORDERTITLE;
                dataGridView.Rows[a].Cells[2].Value = orderDTO.ORDERDATE;
                dataGridView.Rows[a].Cells[3].Value = orderDTO.ORDERSTATUS;
            }
        }

    }
}
