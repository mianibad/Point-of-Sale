using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UserControls.ProductManage
{
    public partial class ucMainProductManagement : UserControl
    {
        public ucMainProductManagement()
        {
            InitializeComponent();
        }

        private void ucMainProductManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new searchClicked_UserControl();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new insert_Clicked_UserControl();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new ProductListing_UserControl();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }
    }
}
