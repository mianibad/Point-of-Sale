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

namespace PointOfSale.UserControls.OrderManage
{
    public partial class UserControlInsert : UserControl
    {
        OrderBLL orderBLL;

        public UserControlInsert()
        {
            InitializeComponent();
        }

        void ClearAllFields()
        {
            txTitle.Text = "";
            dtpDATE.Value = DateTime.Now;
            cmbStatus.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txTitle.Text;
            DateTime date = dtpDATE.Value;
            string status = cmbStatus.Text;
            Int64 admin = 1;

            if (title!="" & status!="")
            {
                OrderDTO dto = new OrderDTO(1, title, date, status, admin);
                orderBLL = new OrderBLL();
                orderBLL.InsertOrder(dto);
                ClearAllFields();
            }
            else
            {
                MessageBox.Show("Please Enter Record In All Fields", "Error");
            }
        }
    }
}
