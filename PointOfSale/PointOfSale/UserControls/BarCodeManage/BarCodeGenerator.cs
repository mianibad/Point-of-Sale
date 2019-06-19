using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UserControls.BarCodeManage
{
    public partial class BarCodeGenerator : Form
    {
        string productCode;
        string productPrice;
        public BarCodeGenerator(string pCode, string pPrice)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            productCode = pCode;
            productPrice = pPrice;
        }

        private void BarCodeGenerator_Load(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                PB_BCDrawn.Image = barCode.Draw(productCode+":"+productPrice, 50);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Code To Generate BarCode!", "Error");
            }
        }

        
        private void BarCodeGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        
    }
}
