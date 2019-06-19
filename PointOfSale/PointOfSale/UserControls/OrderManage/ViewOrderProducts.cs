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

namespace PointOfSale.UserControls.OrderManage
{
    public partial class ViewOrderProducts : Form
    {
        OrderProductDTO opDTO;
        OrderProductBLL opBLL;
        ProductManagementBLL productBLL;
        DataGridViewButtonColumn btnDelProd;
        Int64 orderId;

        public ViewOrderProducts(Int64 id)
        {
            InitializeComponent();
            orderId = id;
            btnDelProd = new DataGridViewButtonColumn();
            dataGridView.Columns.Add(btnDelProd);
            btnDelProd.FlatStyle = FlatStyle.Flat;
            btnDelProd.HeaderText = "Action";
            btnDelProd.Text = "Delete Product";
            btnDelProd.Name = "btnDelProd";
            btnDelProd.UseColumnTextForButtonValue = true;
        }

        
        private void ViewOrderProducts_Load(object sender, EventArgs e)
        {
            loadProductsOfOrder();
        }

        void loadProductsOfOrder()
        {
            opDTO = new OrderProductDTO(orderId);
            opBLL = new OrderProductBLL();
            ArrayList arr = opBLL.search(opDTO);

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach (object o in arr)
            {
                OrderProductDTO orderDTO = (OrderProductDTO)o;

                ProductDTO DTO = new ProductDTO(orderDTO.PRODUCTID);
                productBLL = new ProductManagementBLL();
                string productName = productBLL.prodIdToName(DTO);

                int a = dataGridView.Rows.Add();
                dataGridView.Rows[a].Cells[0].Value = productName;
                dataGridView.Rows[a].Cells[1].Value = orderDTO.QUANTITY;
                dataGridView.Rows[a].Cells[2].Value = orderDTO.SIZE;
            }
        }


        void deleteProductOfOrder(string product)
        {
            ProductDTO DTO = new ProductDTO(1, product);
            productBLL = new ProductManagementBLL();
            Int64 productID = productBLL.prodNameToID(DTO);

            OrderProductDTO opDTO = new OrderProductDTO(orderId,productID);
            opBLL = new OrderProductBLL();
            opBLL.delete(opDTO);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DialogResult dialoge = MessageBox.Show("Are you sure want to Delete Product?", "Delete", MessageBoxButtons.YesNo);
                if (dialoge == DialogResult.Yes)
                {
                    string product = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    deleteProductOfOrder(product);
                    dataGridView.Rows.Clear();
                    dataGridView.Refresh();
                    loadProductsOfOrder();
                }
                else if (dialoge == DialogResult.No)
                {
                }
            }
        }
    }
}
