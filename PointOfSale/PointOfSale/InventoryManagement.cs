using PointOfSale.UserControls.BarCodeManage;
using PointOfSale.UserControls.OrderManage;
using PointOfSale.UserControls.ProductManage;
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
    public partial class InventoryManagement : Form
    {
        double zoomFactor = 3;

        public InventoryManagement()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
        }


        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new ucMainOrderManagement();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);
            label2.Hide();
        }


        void hideMenu()
        {
            float a = tableLayoutPanelMainRow2.ColumnStyles[0].Width;

            if (a > 5)
            {
                tableLayoutPanelMainRow2.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[0].Width = 5;
                tableLayoutPanelMainRow2.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[1].Width = 95;
                lblMenuHead.Hide();
                btnAllItemsList.Text = "";
                //btnProdCategory.Text = "";
                btnBarcodeGen.Text = "";
                //btnbarcodePrint.Text = "";
                btnBack.Text = "";
            }
        }


        private void pBMenu_Click(object sender, EventArgs e)
        {
            float a = tableLayoutPanelMainRow2.ColumnStyles[0].Width;
            
            if(a>5)
            { 
                tableLayoutPanelMainRow2.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[0].Width = 5;
                tableLayoutPanelMainRow2.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[1].Width = 95;
                lblMenuHead.Hide();
                btnAllItemsList.Text = "";
               // btnProdCategory.Text = "";
                btnBarcodeGen.Text = "";
                //btnbarcodePrint.Text = "";
                btnBack.Text = "";
            }
            else
            {
                tableLayoutPanelMainRow2.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[0].Width = 20;
                tableLayoutPanelMainRow2.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[1].Width = 80;
                lblMenuHead.Show();
                btnAllItemsList.Text = "Order Management";
               // btnProdCategory.Text = "Product Category";
                btnBarcodeGen.Text = "Barcode Generate";
                //btnbarcodePrint.Text = "Barcode Print";
                btnBack.Text = "Back";
            }
        }


        private void pBCross_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBMaxMin_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void InventoryManagement_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pBMenu_MouseLeave(object sender, EventArgs e)
        {
            pBMenu.Image = Properties.Resources.menuicon;
        }

        private void pBMenu_MouseHover(object sender, EventArgs e)
        {
            Bitmap originalBitmap = new Bitmap(pBMenu.Image);
            Size newSize = new Size((int)(originalBitmap.Width * zoomFactor), (int)(originalBitmap.Height * zoomFactor));
            Bitmap bmp = new Bitmap(originalBitmap, newSize);
            pBMenu.Image = bmp;
        }

        private void pBMenu_MouseEnter(object sender, EventArgs e)
        {
            Bitmap originalBitmap = new Bitmap(pBMenu.Image);
            Size newSize = new Size((int)(originalBitmap.Width * zoomFactor), (int)(originalBitmap.Height * zoomFactor));
            Bitmap bmp = new Bitmap(originalBitmap, newSize);
            pBMenu.Image = bmp;
        }

        
        private void btnBarcodeGen_Click(object sender, EventArgs e)
        {
            label2.Hide();

            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new ucBarCodeMain();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);

            hideMenu();
        }

        private void btnAllItemsList_Click(object sender, EventArgs e)
        {
            label2.Hide();

            panelUCContainer.Controls.Clear();
            panelUCContainer.Show();
            var myControls = new ucMainOrderManagement();
            myControls.Dock = DockStyle.Fill;
            panelUCContainer.Controls.Add(myControls);

            /*UserControl newOne = new ucMainProductManagement();
            newOne.BorderStyle = BorderStyle.FixedSingle;
            newOne.Dock = DockStyle.Fill;
            tableLayoutPanelColumn2.Controls.Add(newOne, 1, 0);*/
            hideMenu();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Hide();
        }
    }
}
