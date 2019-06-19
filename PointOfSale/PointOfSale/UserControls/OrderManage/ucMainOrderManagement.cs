using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UserControls.OrderManage
{
    public partial class ucMainOrderManagement : UserControl
    {
        public ucMainOrderManagement()
        {
            InitializeComponent();
        }

        private void ucMainOrderManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new UserControlSearch();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new UserControlInsert();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }

        
    }
}
