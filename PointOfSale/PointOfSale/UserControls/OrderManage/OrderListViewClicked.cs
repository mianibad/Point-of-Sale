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

namespace PointOfSale.UserControls.OrderManage
{
    public partial class OrderListViewClicked : Form
    {
        OrderDTO orderDTO;
        OrderBLL orderBLL;

        private Int64 oID;
        private string oTitle;
        private DateTime oDate;
        private string oStatus;

        public OrderListViewClicked(Int64 ID, string Title, DateTime Date, string Status)
        {
            InitializeComponent();
            TopMost = true;
            oID = ID; oTitle = Title; oDate = Date; oStatus = Status;
        }

        private void OrderListViewClicked_Load(object sender, EventArgs e)
        {
            txtOrderTitle.Text = oTitle;
            dtpOrderDate.Value = oDate;
            cmbOrderStatus.Text = oStatus;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to update record?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string title = txtOrderTitle.Text;
                DateTime date = dtpOrderDate.Value;
                string status = cmbOrderStatus.Text;

                orderDTO = new OrderDTO(oID,title,date,status,1);
                orderBLL = new OrderBLL();
                orderBLL.UpdateOrder(orderDTO);
                Hide();

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
                orderDTO = new OrderDTO(oID);
                orderBLL = new OrderBLL();
                orderBLL.DeleteOrder(orderDTO);
                Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
