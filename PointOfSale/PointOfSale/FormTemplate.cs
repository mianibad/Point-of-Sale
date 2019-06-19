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
    public partial class FormTemplate : Form
    {
        double zoomFactor = 3;

        public FormTemplate()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
            }
            else
            {
                tableLayoutPanelMainRow2.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[0].Width = 20;
                tableLayoutPanelMainRow2.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanelMainRow2.ColumnStyles[1].Width = 80;
                lblMenuHead.Show();
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

        private void ProductManagement_FormClosing(object sender, FormClosingEventArgs e)
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


        private void pBCross_MouseEnter(object sender, EventArgs e)
        {
            Bitmap originalBitmap = new Bitmap(pBCross.Image);
            Size newSize = new Size((int)(originalBitmap.Width * zoomFactor), (int)(originalBitmap.Height * zoomFactor));
            Bitmap bmp = new Bitmap(originalBitmap, newSize);
            pBCross.Image = bmp;
        }

        private void pBCross_MouseLeave(object sender, EventArgs e)
        {
            pBCross.Image = Properties.Resources.crossicon;
        }
    }
}
