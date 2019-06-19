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
    public partial class ucMainProductCategory : UserControl
    {
        public ucMainProductCategory()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new ucProductCategoryInsert();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new ucProductCSearch();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
        }
    }
}
