using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnProdManage_Click(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            pm.Show();
            Hide();
        }

        private void btnInventManage_Click(object sender, EventArgs e)
        {
            InventoryManagement im = new InventoryManagement();
            im.Show();
            Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialoge = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialoge == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialoge == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
